using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es09_06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MessageBoxButtons button = MessageBoxButtons.OK;

        private void Form1_Click(object sender, System.EventArgs e)
        {
            if ((int)button > 5)
                button = MessageBoxButtons.OK;
            MessageBox.Show("MessageBox", "Title Bar", button++);
        }
    }
}
