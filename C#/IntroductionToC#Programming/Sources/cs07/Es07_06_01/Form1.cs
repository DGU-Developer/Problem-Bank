using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es07_06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (Width > 500)
                Width = 500;
            else if (Width < 300)
                Width = 300;

            if (Height > 700)
                Height = 700;
            else if (Height < 300)
                Height = 300;
        }
    }
}
