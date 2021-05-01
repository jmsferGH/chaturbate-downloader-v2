using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using cb_downloader_v2.Utils;
using log4net;
using System.Windows.Input;

namespace cb_downloader_v2
{
    public partial class MainForm : Form
    {
        public static readonly string OutputFolderName = "Recordings";
        // public string  AppendTextBox { set { LogOutput.Text += value; } }
        private static readonly ILog Log = LogManager.GetLogger(typeof(MainForm));
        private static readonly string ModelsFileName = "models.txt";
        private IDownloaderProcessManager _manager;
        private ModelsGridWrapper models;
        private Color MainColor = Color.FromArgb(64, 64, 64);
        // TODO fix issue where if you remove a model, it can still attempt to start it (something to do with task.delay/start pipeline i imagine)

        public MainForm()
        {
            InitializeComponent();

            models = new ModelsGridWrapper(modelsGrid);
            models.SortByModelNameAscending();
            modelsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.modelsGrid_CellFormatting);
            modelsGrid.ScrollBars = ScrollBars.None;
            modelsGrid.AllowUserToResizeRows = false;
            modelsGrid.MouseWheel += new MouseEventHandler(mousewheel);

            this.Update();

            toolStripStatusLabel1.Text = "Setup output folder.";
            PrepareOutputFolder();
            toolStripStatusLabel1.Text = "Initialise manager.";
            InitializeManager();

            toolStripStatusLabel1.Text = "Check for streamlink.";
            CheckStreamlinkInstall();
            toolStripStatusLabel1.Text = "Load models list for autocomplete.";
            LoadModelNamesResourceFile();
            Log.Info("Starting up ...");

            this.Update();

            ClipboardNotification.ClipboardUpdate += ClipboardNotification_ClipboardUpdate;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

            // In the forms Load()
            this.menuStrip.Renderer = new MenuStripRenderer();
            this.menuStrip.BackColor = MainColor;
            this.menuStrip.ForeColor = Color.White;
            
        }

        private void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && modelsGrid.FirstDisplayedScrollingRowIndex > 0)
            {
                modelsGrid.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                modelsGrid.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void CheckStreamlinkInstall()
        {
            if (!FileHelper.IsFileAccessible(Properties.Settings.Default.StreamlinkExecutable))
            {
                var binary = Properties.Settings.Default.StreamlinkExecutable;
                Log.Error($"Streamlink binary not found: {binary}");
                MessageBox.Show(this, $"'{binary}' inaccessible, the application may fail to work properly.\r\n" +
                                      "Please ensure it is either in the current working directory, or in your system path variable.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadModelsFile()
        {
            // Checking if file exists
            if (!File.Exists(ModelsFileName))
                return;

            // Reading model file content
            var r = new StreamReader(ModelsFileName);
            var modelNames = await r.ReadToEndAsync();
            r.Close();

            string[] xxx = Regex.Split(modelNames, Environment.NewLine);

            toolStripProgressBar1.Maximum = xxx.Count();

            // MessageBox.Show( xxx.Count().ToString(),"Info", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            Int32 countModelProgress = 0;

            // Parsing lines, we filter out comments and empty lines
            foreach (var modelName in xxx
                .Select(line => line.Trim())
                .Where(modelName => modelName.Length != 0 && !modelName.StartsWith("#")))
            {
                _manager.AddModel(modelName);
                countModelProgress += 1;
                toolStripProgressBar1.Value = countModelProgress;
                this.Update();
                toolStripStatusLabel1.Text = "Loading model: " + modelName;
            }

            toolStripProgressBar1.Value = xxx.Count();
            toolStripStatusLabel1.Text = "Finished loading models.";
        }

        private void LoadModelNamesResourceFile()
        {
            var modelNames = EmbeddedResourceHelper.ReadText("cb_downloader_v2.models_list.txt");
            var col = new AutoCompleteStringCollection();
            col.AddRange(Regex.Split(modelNames, Environment.NewLine));
            modelNameTextBox.AutoCompleteCustomSource = col;
        }

        private void InitializeManager()
        {
            _manager = new DownloaderProcessManager(this, models);
            _manager.Start();
        }

        public void RemoveInvalidUrlModel(string modelName)
        {
            // Telling user URL was invalid
            Log.Warn($"Invalid model: {modelName}");
            Invoke((MethodInvoker)(() => MessageBox.Show(this, $"Unregistered model detected: {modelName}",
                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)));

            // Removing from listeners
            if (_manager.RemoveModel(modelName))
            {
                // Removing from UI
                models.RemoveModel(modelName);
            }
        }

        private void PrepareOutputFolder()
        {
            try
            {
                // Creating recordings folder if non-existent
                if (!Directory.Exists(OutputFolderName))
                {
                    Directory.CreateDirectory(OutputFolderName);
                }
            }
            catch (Exception e)
            {
                // We exit since an issue occured when creating the folder
                if (MessageBox.Show(this, $"Error creating output folder: {e.Message}\r\nApplication will now exit.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void quickAddModelButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Adding model ...";
            // Adding user to listener and start immediately
            string modelName = modelNameTextBox.Text;
            _manager.AddModel(modelName, true);
            modelNameTextBox.Text = "";
            toolStripStatusLabel1.Text = "Model added.";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Asking user to confirm action
            if (_manager.Count > 0 && MessageBox.Show(this, "Are you sure you want to quit, all active streams being listened to will be terminated.",
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

            // Terminating manager + download listeners
            _manager.Stop();
        }

        private void modelNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            // Handling textbox enter key press
            if (e.KeyCode != Keys.Enter)
                return;
            _manager.AddModel(modelNameTextBox.Text, true);
            modelNameTextBox.Text = "";
            e.Handled = e.SuppressKeyPress = true;
        }

        private void modelNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Suppressing beeping sound for text box enter press
            if (e.KeyCode == Keys.Enter && modelNameTextBox.Text.Length > 0)
            {
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        internal void SetStatus(string modelName, Status status)
        {
            models.SetStatus(modelName, status);
        }

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var modelName in models.SelectedModelNames)
            {
                // Terminating process
                var listener = _manager[modelName];
                listener.Terminate();

                // Removing listener from collections
                if (_manager.RemoveModel(modelName))
                {
                    models.RemoveModel(modelName);
                    Log.Debug($"{modelName}: Remove");
                    AppendTextBox ( $"{modelName}: Remove" + Environment.NewLine );
                }
                else
                {
                    Log.Debug($"{modelName}: Remove failed");
                    AppendTextBox ( $"{modelName}: Remove failed" + Environment.NewLine );
                }
            }
        }

        private void saveModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prepare dialog
            SaveFileDialog dialog = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = ".txt",
                Filter = "Text File|*.txt|All Files|*.*",
                FileName = "models"
            };

            // Show dialog and save if chosen to
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                // Construct file content
                var fileContent = models.CreateModelsFileContent();

                // Attempt to save content
                var fileName = dialog.FileName;

                try
                {
                    // Writing new file
                    File.WriteAllText(fileName, fileContent);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, $"Error saving file to: {fileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var modelName in models.SelectedModelNames)
            {
                // Fetching process
                var listener = _manager[modelName];

                // Cancel restart if the listener is already running
                if (listener.Status != Status.Disconnected)
                    return;

                // Otherwise, continue with the manual start
                listener.Start(true);
                Log.Debug($"{modelName}: Manual restart");

                AppendTextBox ( $"{modelName}: Manual restart" + Environment.NewLine );
            }
        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var modelName in models.SelectedModelNames)
            {
                // Fetching process
                var listener = _manager[modelName];

                // Cancel restart if the listener is not running
                if (listener.Status != Status.Connected)
                    return;
                // Fetching process

                // Initiating termination
                listener.Terminate();

                // Continue with the forced recconect
                listener.Start(true);
                Log.Debug($"{modelName}: Forced recconect");

                AppendTextBox($"{modelName}: Forced reconnect" + Environment.NewLine);
            }
        }

        private void removeAllUncheckedToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Log.Debug($"Remove all disconnected");

            // Gather IDs
            var modelNames = models.ModelsWithStatus(Status.Disconnected);

            // Batch remove
            foreach (var modelName in modelNames)
            {
                // Fetching process
                var listener = _manager[modelName];

                // Initiating termination
                listener.Terminate();

                // Removing listener from lists
                if (_manager.RemoveModel(modelName))
                {
                    models.RemoveModel(modelName);
                    // Log.Debug($"{modelName}: Remove all disconnected");
                    AppendTextBox( $"{modelName}: Remove all disconnected" + Environment.NewLine );
                }
            }
        }

        private void modelsBoxCtxMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // TODO inspect
            var idx = models.SelectedIndex;

            //  Disable element if selectedindex=-1
            removeCtxMenuItem.Enabled = idx != null;

            //  Disable element if selectedindex=-1 not checked
            restartCtxMenuItem.Enabled = idx != null
                && models.GetStatus(idx.Value) == Status.Disconnected;

            //  Disable element if selectedindex=-1 not checked
            reconnectCtxMenuItem.Enabled = idx != null
                && models.GetStatus(idx.Value) == Status.Connected;

            // if there is more than 0 unchecked models
            removeAllDisconnectedCtxMenuItem.Enabled = models.ModelsWithStatus(Status.Disconnected).Count > 0;
        }
        
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog(this);
            form.Dispose();
        }


        //private void modelsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Update the balance column whenever the value of any cell changes.
        //    modelsGrid_CellFormatting(object sender, DataGridViewCellEventArgs e);
        //}


        private void modelsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in modelsGrid.Rows)
            {

                // Log.Info(row.Cells["ModelStatus"].Value);

                if (row.Cells["ModelStatus"].Value.ToString() == "Connected")
                {
                    row.Cells["ModelStatus"].Style.ForeColor = Color.LimeGreen;
                }
                else if (row.Cells["ModelStatus"].Value.ToString() == "Disconnected")
                {
                    row.Cells["ModelStatus"].Style.ForeColor = Color.OrangeRed;
                }
                else 
                {
                    row.Cells["ModelStatus"].Style.ForeColor = Color.Yellow;
                }
            }
        }

        private async void loadModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prepare dialog

            toolStripStatusLabel1.Text = "Load models file.";

            OpenFileDialog dialog = new OpenFileDialog
            {
                AddExtension = true,
                DefaultExt = ".txt",
                Filter = "Text File|*.txt|All Files|*.*",
                FileName = "models"
            };

            // Show dialog and save if chosen to
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {

                // Attempt to save content
                var fileName = dialog.FileName;


                var r = new StreamReader(fileName);
                var modelNames = await r.ReadToEndAsync();
                r.Close();

                string[] xxx = Regex.Split(modelNames, Environment.NewLine);

                toolStripProgressBar1.Maximum = xxx.Count();

                // MessageBox.Show( xxx.Count().ToString(),"Info", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                Int32 countModelProgress = 0;

                // Parsing lines, we filter out comments and empty lines
                foreach (var modelName in xxx
                    .Select(line => line.Trim())
                    .Where(modelName => modelName.Length != 0 && !modelName.StartsWith("#")))
                {
                    _manager.AddModel(modelName);
                    countModelProgress += 1;
                    toolStripProgressBar1.Value = countModelProgress;
                    this.Update();
                    toolStripStatusLabel1.Text = "Loading model: " + modelName;
                }

                toolStripProgressBar1.Value = xxx.Count();
                toolStripStatusLabel1.Text = "Finished loading models.";

               
            }
        }

        private void PasteModelButton_Click(object sender, EventArgs e)
        {
            string modelName = Clipboard.GetText();


                // Adding user to listener and start immediately
                toolStripStatusLabel1.Text = "Paste model from clipboard. Adding mode ...";
                modelNameTextBox.Text = modelName;
                
                _manager.AddModel(modelName, true);

                Thread.Sleep(3000);
                modelNameTextBox.Text = "";
                toolStripStatusLabel1.Text = "Model added.";


        }
        void ClipboardNotification_ClipboardUpdate(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string modelName = Clipboard.GetText();

                if (UrlHelper.IsChaturbateUrl(modelName))
                {
                    toolStripStatusLabel1.Text = "Paste model from clipboard ( auto detect URL ). Adding mode ...";
                    modelNameTextBox.Text = modelName;
                    
                    _manager.AddModel(modelName, true);
                    Thread.Sleep(3000);
                    modelNameTextBox.Text = "";
                    toolStripStatusLabel1.Text = "Model added.";
                }
                
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }

            LogOutput.AppendText( value );

        }



        private void ClearLog_Click(object sender, EventArgs e)
        {
            LogOutput.Clear();
        }

        private void modelsGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = modelsGrid.HitTest(e.X, e.Y);
                modelsGrid.ClearSelection();
                modelsGrid.Rows[hti.RowIndex].Selected = true;
            }
        }
    }
}
