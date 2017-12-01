using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es07_06_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, System.EventArgs e)
        {

            Font f = new Font("Times New Roman", 12, FontStyle.Regular);
            Graphics g = CreateGraphics();
            g.Clear(System.Drawing.SystemColors.Control);
            g.DrawString(DateTime.Now.ToString(), f, Brushes.Black, 50, 100);
        }
    }
}
