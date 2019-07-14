using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PathPointer
{
    public partial class GradientPanel : Panel
    {
        public Color LeftTopColor { get { return Color.FromArgb(255, 96, 114, 137); } }
        public Color RightBottomColor { get { return Color.FromArgb(255, 36, 46, 55); } }

        public AutoScaleMode AutoScaleMode { get; set; }

        public GradientPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new PointF(0,0), new PointF(Width, Height), LeftTopColor, RightBottomColor);
            Graphics g = e.Graphics;
            g.FillRectangle(linearGradientBrush, ClientRectangle);
            
            base.OnPaint(e);

        }

    }
}
