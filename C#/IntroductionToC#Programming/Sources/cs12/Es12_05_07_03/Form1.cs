using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_05_07_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen[] p = new Pen[8];
            for (int i = 0; i < 8; i++)
                p[i] = new Pen(Brushes.Black, 10);
            p[0].StartCap = p[0].EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            p[1].StartCap = p[1].EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            p[2].StartCap = p[2].EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            p[3].StartCap = p[3].EndCap = System.Drawing.Drawing2D.LineCap.Round;
            p[4].StartCap = p[4].EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            p[5].StartCap = p[5].EndCap = System.Drawing.Drawing2D.LineCap.Square;
            p[6].StartCap = p[6].EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            p[7].StartCap = p[7].EndCap = System.Drawing.Drawing2D.LineCap.Triangle;

            Font f = new Font("Arial", 10);
            for (int i = 0, y = 10; i < 8; i++, y += 30)
            {
                g.DrawString(p[i].StartCap.ToString(), f, Brushes.Black, 40, y);
                y += 30;
                g.DrawLine(p[i], 40, y, 130, y);
            }
        }
    }
}
