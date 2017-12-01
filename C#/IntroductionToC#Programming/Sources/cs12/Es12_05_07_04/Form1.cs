using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_05_07_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int brushIndex = 0;

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush b;

            switch (brushIndex)
            {
                case 0:
                    // SolidBrush
                    b = new SolidBrush(Color.Lime);
                    break;

                case 1:
                    // 
                    Image img = new Bitmap("image.jpg");
                    b = new TextureBrush(img);
                    img.Dispose();
                    break;

                case 2:
                    // HatchBrush
                    b = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.Green);
                    break;

                case 3:
                    // LinearGradientBrush
                    b = new LinearGradientBrush(new Point(0, 0), new Point(40, 30),
                                                      Color.Blue, Color.Red);
                    break;

                case 4:
                    // PathGradientBrush
                    Point[] pts = new Point[] {
                        new Point(ClientRectangle.Width/2, 0),
                        new Point(0, ClientRectangle.Height),
                        new Point(ClientRectangle.Width, ClientRectangle.Height),
                    };
                    b = new PathGradientBrush(pts);
                    break;

                default:
                    b = new SolidBrush(Color.Black);
                    break;
            }

            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            brushIndex++;
            brushIndex %= 5;
            Invalidate();
        }
    }
}
