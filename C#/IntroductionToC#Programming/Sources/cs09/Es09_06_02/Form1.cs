using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es09_06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MessageBoxDefaultButton selectButton = MessageBoxDefaultButton.Button1;

        private void Form1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("MessageBoxDefaultButton", "Title Bar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, selectButton);
            if (selectButton == MessageBoxDefaultButton.Button1)
                selectButton = MessageBoxDefaultButton.Button2;
            else if (selectButton == MessageBoxDefaultButton.Button2)
                selectButton = MessageBoxDefaultButton.Button3;
            else selectButton = MessageBoxDefaultButton.Button1;
        }
    }
}
