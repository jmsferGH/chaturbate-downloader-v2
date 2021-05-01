using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cb_downloader_v2
{
   

    public class MenuStripRenderer : ToolStripProfessionalRenderer
    {
        private readonly Color MainColor = Color.FromArgb(64, 64, 64);
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);

            if (e.Item.Selected)
            {
                Color color = Color.FromArgb(44, 44, 44);
                using (SolidBrush brush = new SolidBrush(color))
                    e.Graphics.FillRectangle(brush, rect);
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(MainColor))
                    e.Graphics.FillRectangle(brush, rect);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.Item.ForeColor = Color.White;
            base.OnRenderItemText(e);
        }

        //protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        //{
        //    base.OnRenderSeparator(e);
        //}
       
        public MenuStripRenderer() : base(new MenuStripColors()) { }
    }

    public class MenuStripColors : ProfessionalColorTable
    {
        public Color MainColor { get; private set; }
        public override Color ToolStripDropDownBackground
        {
            get { return MainColor; }
        }

        //public override Color ToolStripContentPanelGradientBegin
        //{
        //    get { return MainColor; }
        //}

        //public override Color ToolStripContentPanelGradientEnd
        //{
        //    get { return MainColor; }
        //}

        public override Color MenuItemSelected
        {
            get { return MainColor; }
        }

        public override Color MenuBorder
        {
            get { return MainColor; }
        }
        public override Color MenuItemBorder
        {
            get { return MainColor; }
        }

        //public override Color MenuItemSelectedGradientBegin
        //{
        //    get { return MainColor; }
        //}

        //public override Color MenuItemSelectedGradientEnd
        //{
        //    get { return MainColor; }
        //}

        public override Color SeparatorLight
        {
            get { return MainColor; }
        }

        public override Color SeparatorDark
        {
            get { return MainColor; }
        }

       
    }
}
