using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es09_06_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form2 form2 = new Form2();
            if (radioButton1.Checked == true)
            {
                form2.Text = "ModalDialogBox";
                form2.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                form2.Text = "ModalessDialogBox";
                form2.Show();
            }
        }
    }
}
