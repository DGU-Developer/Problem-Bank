using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es10_06_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Menu && e.KeyCode != Keys.ShiftKey)
            {
                if (e.Alt == true)
                    MessageBox.Show(e.KeyCode.ToString() + "+Alt", "누른 키");
                else if (e.Shift == true)
                    MessageBox.Show(e.KeyCode.ToString() + "+Shift", "누른 키");
                else if (e.Control == true)
                    MessageBox.Show(e.KeyCode.ToString() + "+Ctrl", "누른 키");
                else MessageBox.Show(e.KeyCode.ToString(), "누른 키");
            }
        }
    }
}
