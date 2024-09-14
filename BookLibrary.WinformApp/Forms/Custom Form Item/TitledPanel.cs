using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary.WinformApp.Forms.Custom_Form_Item
{
    [ToolboxItem(true)]
    public class TitledPanel :Panel
    {
        private string _title = "";
        private Font _titleFont = new Font("Arial", 12);
        private Color _titleBackColor = Color.LightGray;
        private Color _borderColor = Color.Black;
        private Color _titleForeColor = Color.Black;
        private TextAlign _textAlign= TextAlign.Center;

        [Category("Custom Options")]
        [Description("bla1")]
        public string Title
        {
            get { return _title; }
            set { _title = value; Invalidate(); }
        }

        [Category("Custom Options")]
        [Description("bla2")]
        public Font TitleFont
        {
            get { return _titleFont; }
            set { _titleFont = value; Invalidate(); }
        }


        [Category("Custom Options")]
        [Description("bla4")]
        public Color TitleBackColor
        {
            get { return _titleBackColor; }
            set { _titleBackColor = value; Invalidate(); }
        }

        [Category("Custom Options")]
        [Description("bla5")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Custom Options")]
        [Description("bla6")]
        public Color TitleForeColor
        {
            get { return _titleForeColor; }
            set { _titleForeColor = value; Invalidate(); }
        }
        [Category("Custom Options")]
        [Description("bla7")]
        public TextAlign TextAligns
        {
            get { return _textAlign; }
            set { _textAlign = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (TitleFont == null)
            {
                TitleFont = new Font("Ariel", 10);
            }

            Size textSize = TextRenderer.MeasureText(Title, TitleFont);
            int titleHeight = textSize.Height+ textSize.Height/2;

            e.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);
            e.Graphics.DrawLine(Pens.Black, 0, titleHeight+1, Width - 1, titleHeight + 1);

            e.Graphics.FillRectangle(Brushes.LightGray, 1, 1, Width-2, titleHeight-1);

            using (Font font = TitleFont)
            {
                TextRenderer.DrawText(e.Graphics, _title, font, CalculatePosition(textSize,titleHeight), Color.Black);
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }

        private Point CalculatePosition(Size textSize, int titleHeight)
        {
            int titleCenter = (titleHeight / 2) - (int)(textSize.Height / 2);

            switch (_textAlign)
            {
                case TextAlign.Center:
                    int widthCenter = (Width / 2) - (int)(textSize.Width / 2);
                    return new Point(widthCenter, titleCenter);
                case TextAlign.Right:
                    int widthLeft = Width - (textSize.Width) - 10;
                    return new Point(widthLeft, titleCenter);
                case TextAlign.Left:
                    return new Point(10, titleCenter);
                default:
                    return new Point(0, 0);
            }
        }
    }
}
