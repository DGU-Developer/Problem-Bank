using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es10_06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnu_Click(object sender, System.EventArgs e)
        {
            string temp = sender.ToString();
            MessageBox.Show(temp.Substring(temp.IndexOf("Text: ") + 6, temp.IndexOf('(') - (temp.IndexOf("Text: ") + 6)));
        }
    }
}
