using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_05_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int angle = 45;
        private System.Windows.Forms.Timer timer1;
        int movingDistance = 305;

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(50, 50, 150, 150);
            g.FillEllipse(Brushes.Red, movingDistance, 115, 20, 20);
            g.FillPie(Brushes.Yellow, r, angle, 360 - angle * 2);
            g.DrawPie(Pens.Black, r, angle, 360 - angle * 2);
            g.FillEllipse(Brushes.Black, 119, 81, 16, 16);
            g.FillEllipse(Brushes.White, 130, 86, 6, 6);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (angle == 0)
                timer1.Stop();
            else
            {
                angle--;
                movingDistance -= 3;
                Invalidate();
            }
        }
    }
}
