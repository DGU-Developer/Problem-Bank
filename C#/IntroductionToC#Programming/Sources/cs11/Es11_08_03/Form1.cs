using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es11_08_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            trackBar_Scroll(sender, e);
        }

        private void trackBar_Scroll(object sender, System.EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
            label6.Text = trackBar2.Value.ToString();
            label7.Text = trackBar3.Value.ToString();
            label1.BackColor = System.Drawing.Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
    }
}
