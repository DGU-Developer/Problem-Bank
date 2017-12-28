using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es09_06_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            fontDialog1.ShowApply = !fontDialog1.ShowApply;
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            fontDialog1.ShowColor = !fontDialog1.ShowColor;
        }
    }
}
