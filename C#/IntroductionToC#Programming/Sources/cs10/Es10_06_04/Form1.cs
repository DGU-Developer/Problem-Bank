using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es10_06_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                Graphics g = CreateGraphics();
                Point pt1 = new Point(e.X, e.Y);
                Rectangle r = new Rectangle(e.X - 1, e.Y - 1, 2, 2);
                Brush br = Brushes.Black;
                if (radioButton1.Checked == true)
                    br = Brushes.Black;
                else if (radioButton2.Checked == true)
                    br = Brushes.Red;
                else if (radioButton3.Checked == true)
                    br = Brushes.Purple;
                else if (radioButton4.Checked == true)
                    br = Brushes.Green;

                g.FillRectangle(br, r);
            }
        }
    }
}
