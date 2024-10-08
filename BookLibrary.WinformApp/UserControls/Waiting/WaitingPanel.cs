
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace BookLibrary.WinformApp.UserControlComponents.Waiting
{
    public partial class WaitingPanel : UserControl
    {
        System.Windows.Forms.Timer _timer;
        private int _angle;
        private Brush _brush = Brushes.Blue;
        private Color _color = Color.Blue;
        private string _text = "Waiting...";
        public WaitingPanel()
        {
            InitializeComponent();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 100;
            _timer.Tick += TimerTick;
            _timer.Start();
            this.DoubleBuffered = true;
        }

        public void TimerTick(object sender, EventArgs e)
        {
            _angle += 10;
            if(_angle >= 360)
            {
                _angle = 0;
            }
            this.Invalidate();
        }


        public void Success()
        {
            _timer.Stop();
            _angle = 360;

            _color = Color.Green;
            _brush = Brushes.Green;
            _text = "Success";

            this.Invalidate();
        }

        public void Fail()
        {
            _timer.Stop();
            _angle = 360;

            _color = Color.Red;
            _brush = Brushes.Red;
            _text = "Failed";

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(this.Width/2-80,this.Height/2-80, 160,160);

            using(Pen pen = new Pen(_color,4))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                e.Graphics.DrawArc(pen, rect,0, _angle);
            }

            using(Font font = new Font("Arial", 10))
            {
                SizeF textSize = e.Graphics.MeasureString(_text , font);
                float x = (this.Width  - textSize.Width)  / 2;
                float y = (this.Height - textSize.Height) / 2;

                e.Graphics.DrawString(_text,font,_brush,x,y);
            }
        }
    }
}
