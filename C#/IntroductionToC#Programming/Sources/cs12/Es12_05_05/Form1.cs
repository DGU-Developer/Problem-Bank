using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_05_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            comboBox1.SelectedItem = "굴림";
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(15, 80, 264, 170);
            Font f = new Font(comboBox1.SelectedItem.ToString(), (int)numericUpDown1.Value);
            g.DrawString(textBox1.Text, f, Brushes.Black, r);
        }
    }
}
