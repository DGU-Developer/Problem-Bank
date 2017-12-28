using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex08_07_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleLeft;

        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleRight;
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Bold);
                label3.Font = font;
            }
            else
            {
                Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Bold);
                label3.Font = font;
            }

        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
                label3.Font = font;
            }
            else
            {
                Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Underline);
                label3.Font = font;
            }
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Italic);
                label3.Font = font;
            }
            else
            {
                Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Italic);
                label3.Font = font;
            }
        }

        private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Strikeout);
                label3.Font = font;
            }
            else
            {
                Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Strikeout);
                label3.Font = font;
            }
        }
    }
}
