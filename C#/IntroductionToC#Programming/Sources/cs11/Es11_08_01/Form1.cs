using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es11_08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems[0].Text == "메모장")
                Process.Start("Notepad.exe");
            else if (listView1.SelectedItems[0].Text == "계산기")
                Process.Start("Calc.exe");
            else if (listView1.SelectedItems[0].Text == "그림판")
                Process.Start("Mspaint.exe");

        }
    }
}
