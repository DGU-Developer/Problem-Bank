using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es08_07_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("버튼");
            listBox1.Items.Add("체크 상자");
            listBox1.Items.Add("라디오 버튼");
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("리스트 상자");
            listBox1.Items.Add("콤보 상자");
            listBox1.Items.Add("체크 리스트 상자");
        }
    }
}
