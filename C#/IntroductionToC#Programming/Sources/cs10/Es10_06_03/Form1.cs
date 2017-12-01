using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es10_06_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point start;

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int width, height;
            Graphics g = CreateGraphics();
            width = Math.Abs(start.X - e.X);
            height = Math.Abs(start.Y - e.Y);
            if (start.X > e.X)
                start.X = e.X;
            if (start.Y > e.Y)
                start.Y = e.Y;

            g.DrawRectangle(Pens.Black, start.X, start.Y, width, height);
        }
    }
}
