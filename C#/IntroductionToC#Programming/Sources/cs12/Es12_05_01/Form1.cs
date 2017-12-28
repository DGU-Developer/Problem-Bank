using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList list = new ArrayList();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                list.Add(p);
            }
            else if (e.Button == MouseButtons.Right)
                list.Clear();
            Invalidate();
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (list.Count > 1)
            {
                if (radioButton1.Checked == true)
                {
                    for (int i = 0; i < list.Count - 1; i++)
                        g.DrawLine(Pens.Black, (Point)list[i], (Point)list[i + 1]);
                }
                else if (radioButton2.Checked == true)
                {
                    Point[] pt = new Point[list.Count];
                    for (int i = 0; i < list.Count; i++)
                        pt[i] = (Point)list[i];
                    g.DrawPolygon(Pens.Black, pt);
                }
                else if (radioButton3.Checked == true)
                {
                    Point[] pt = new Point[list.Count];
                    for (int i = 0; i < list.Count; i++)
                        pt[i] = (Point)list[i];
                    g.DrawCurve(Pens.Black, pt);
                }
                else if (radioButton4.Checked == true && list.Count > 2)
                {
                    Point[] pt = new Point[list.Count];
                    for (int i = 0; i < list.Count; i++)
                        pt[i] = (Point)list[i];
                    g.DrawClosedCurve(Pens.Black, pt);
                }
            }

        }

        private void radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            Invalidate();
        }
    }
}
