namespace cb_downloader_v2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelsCtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeCtxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartCtxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectCtxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeAllDisconnectedCtxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickAddModelButton = new System.Windows.Forms.Button();
            this.LogOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PasteModelButton = new System.Windows.Forms.Button();
            this.ClearLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modelsGrid = new System.Windows.Forms.DataGridView();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastOnline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.modelsCtxMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsGrid)).BeginInit();
            this.modelsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelsCtxMenu
            // 
            this.modelsCtxMenu.BackColor = System.Drawing.Color.DarkGray;
            this.modelsCtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeCtxMenuItem,
            this.restartCtxMenuItem,
            this.reconnectCtxMenuItem,
            this.toolStripMenuItem2,
            this.removeAllDisconnectedCtxMenuItem});
            this.modelsCtxMenu.Name = "modelsBoxCtxMenu";
            this.modelsCtxMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.modelsCtxMenu.ShowImageMargin = false;
            this.modelsCtxMenu.Size = new System.Drawing.Size(185, 98);
            this.modelsCtxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.modelsBoxCtxMenu_Opening);
            // 
            // removeCtxMenuItem
            // 
            this.removeCtxMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeCtxMenuItem.Name = "removeCtxMenuItem";
            this.removeCtxMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removeCtxMenuItem.Text = "Remove";
            this.removeCtxMenuItem.Click += new System.EventHandler(this.removeMenuItem_Click);
            // 
            // restartCtxMenuItem
            // 
            this.restartCtxMenuItem.ForeColor = System.Drawing.Color.White;
            this.restartCtxMenuItem.Name = "restartCtxMenuItem";
            this.restartCtxMenuItem.Size = new System.Drawing.Size(184, 22);
            this.restartCtxMenuItem.Text = "Restart";
            this.restartCtxMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // reconnectCtxMenuItem
            // 
            this.reconnectCtxMenuItem.ForeColor = System.Drawing.Color.White;
            this.reconnectCtxMenuItem.Name = "reconnectCtxMenuItem";
            this.reconnectCtxMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reconnectCtxMenuItem.Text = "Reconnect";
            this.reconnectCtxMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // removeAllDisconnectedCtxMenuItem
            // 
            this.removeAllDisconnectedCtxMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeAllDisconnectedCtxMenuItem.Name = "removeAllDisconnectedCtxMenuItem";
            this.removeAllDisconnectedCtxMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removeAllDisconnectedCtxMenuItem.Text = "Remove All Disconnected";
            this.removeAllDisconnectedCtxMenuItem.Click += new System.EventHandler(this.removeAllUncheckedToolStripMenuItem_Click_1);
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modelNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.modelNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modelNameTextBox.ForeColor = System.Drawing.Color.White;
            this.modelNameTextBox.Location = new System.Drawing.Point(97, 458);
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.modelNameTextBox.TabIndex = 2;
            this.modelNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modelNameTextBox_KeyDown);
            this.modelNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modelNameTextBox_KeyUp);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadModelsToolStripMenuItem,
            this.saveModelsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadModelsToolStripMenuItem
            // 
            this.loadModelsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadModelsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadModelsToolStripMenuItem.Name = "loadModelsToolStripMenuItem";
            this.loadModelsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadModelsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.loadModelsToolStripMenuItem.Text = "Load Models... ";
            this.loadModelsToolStripMenuItem.Click += new System.EventHandler(this.loadModelsToolStripMenuItem_Click);
            // 
            // saveModelsToolStripMenuItem
            // 
            this.saveModelsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveModelsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveModelsToolStripMenuItem.Name = "saveModelsToolStripMenuItem";
            this.saveModelsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveModelsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.saveModelsToolStripMenuItem.Text = "Save Models...";
            this.saveModelsToolStripMenuItem.Click += new System.EventHandler(this.saveModelsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // quickAddModelButton
            // 
            this.quickAddModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quickAddModelButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickAddModelButton.ForeColor = System.Drawing.Color.White;
            this.quickAddModelButton.Location = new System.Drawing.Point(303, 457);
            this.quickAddModelButton.Name = "quickAddModelButton";
            this.quickAddModelButton.Size = new System.Drawing.Size(117, 23);
            this.quickAddModelButton.TabIndex = 4;
            this.quickAddModelButton.Text = "Add";
            this.quickAddModelButton.UseVisualStyleBackColor = true;
            this.quickAddModelButton.Click += new System.EventHandler(this.quickAddModelButton_Click);
            // 
            // LogOutput
            // 
            this.LogOutput.BackColor = System.Drawing.Color.DimGray;
            this.LogOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutput.ForeColor = System.Drawing.Color.White;
            this.LogOutput.Location = new System.Drawing.Point(0, 19);
            this.LogOutput.Multiline = true;
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogOutput.Size = new System.Drawing.Size(651, 406);
            this.LogOutput.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1089, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(159, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // PasteModelButton
            // 
            this.PasteModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteModelButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteModelButton.ForeColor = System.Drawing.Color.White;
            this.PasteModelButton.Location = new System.Drawing.Point(12, 456);
            this.PasteModelButton.Name = "PasteModelButton";
            this.PasteModelButton.Size = new System.Drawing.Size(79, 23);
            this.PasteModelButton.TabIndex = 7;
            this.PasteModelButton.Text = "Paste";
            this.PasteModelButton.UseVisualStyleBackColor = true;
            this.PasteModelButton.Click += new System.EventHandler(this.PasteModelButton_Click);
            // 
            // ClearLog
            // 
            this.ClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLog.ForeColor = System.Drawing.Color.White;
            this.ClearLog.Location = new System.Drawing.Point(426, 458);
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(651, 23);
            this.ClearLog.TabIndex = 8;
            this.ClearLog.Text = "Clear log";
            this.ClearLog.UseVisualStyleBackColor = true;
            this.ClearLog.Click += new System.EventHandler(this.ClearLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(518, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 425);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // modelsGrid
            // 
            this.modelsGrid.AllowUserToAddRows = false;
            this.modelsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.modelsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.modelsGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.modelsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.modelsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modelsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.modelsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelName,
            this.ModelStatus,
            this.LastOnline});
            this.modelsGrid.ContextMenuStrip = this.modelsCtxMenu;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modelsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.modelsGrid.EnableHeadersVisualStyles = false;
            this.modelsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modelsGrid.Location = new System.Drawing.Point(0, 19);
            this.modelsGrid.Name = "modelsGrid";
            this.modelsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modelsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.modelsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.modelsGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.modelsGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modelsGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.modelsGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.modelsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.modelsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modelsGrid.Size = new System.Drawing.Size(408, 407);
            this.modelsGrid.TabIndex = 0;
            this.modelsGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.modelsGrid_MouseDown);
            // 
            // ModelName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ModelName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ModelName.HeaderText = "Model";
            this.ModelName.Name = "ModelName";
            this.ModelName.ReadOnly = true;
            this.ModelName.Width = 220;
            // 
            // ModelStatus
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ModelStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.ModelStatus.HeaderText = "Status";
            this.ModelStatus.Name = "ModelStatus";
            this.ModelStatus.ReadOnly = true;
            this.ModelStatus.Width = 90;
            // 
            // LastOnline
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.LastOnline.DefaultCellStyle = dataGridViewCellStyle5;
            this.LastOnline.HeaderText = "L Online";
            this.LastOnline.Name = "LastOnline";
            this.LastOnline.ReadOnly = true;
            this.LastOnline.Width = 95;
            // 
            // modelsGroupBox
            // 
            this.modelsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.modelsGroupBox.Controls.Add(this.modelsGrid);
            this.modelsGroupBox.Controls.Add(this.groupBox1);
            this.modelsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelsGroupBox.ForeColor = System.Drawing.Color.White;
            this.modelsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.modelsGroupBox.Name = "modelsGroupBox";
            this.modelsGroupBox.Size = new System.Drawing.Size(408, 426);
            this.modelsGroupBox.TabIndex = 1;
            this.modelsGroupBox.TabStop = false;
            this.modelsGroupBox.Text = "Models";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogOutput);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(426, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 425);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1089, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearLog);
            this.Controls.Add(this.PasteModelButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.quickAddModelButton);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.modelNameTextBox);
            this.Controls.Add(this.modelsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CB Streams Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.modelsCtxMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsGrid)).EndInit();
            this.modelsGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.ContextMenuStrip modelsCtxMenu;
        private System.Windows.Forms.ToolStripMenuItem removeCtxMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveModelsToolStripMenuItem;
        private System.Windows.Forms.Button quickAddModelButton;
        private System.Windows.Forms.ToolStripMenuItem restartCtxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectCtxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllDisconnectedCtxMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TextBox LogOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem loadModelsToolStripMenuItem;
        private System.Windows.Forms.Button PasteModelButton;
        private System.Windows.Forms.Button ClearLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView modelsGrid;
        private System.Windows.Forms.GroupBox modelsGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastOnline;
    }
}

