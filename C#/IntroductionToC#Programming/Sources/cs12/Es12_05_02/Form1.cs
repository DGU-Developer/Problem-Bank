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

namespace Es12_05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList list = new ArrayList();
        int mouseCount = 0;

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (list.Count == 2)
            {
                Point[] pt = new Point[list.Count];
                for (int i = 0; i < list.Count; i++)
                    pt[i] = (Point)list[i];
                g.DrawLine(Pens.Black, pt[0], pt[1]);
            }
            else if (list.Count == 4)
            {
                Point[] pt = new Point[list.Count];
                for (int i = 0; i < list.Count; i++)
                    pt[i] = (Point)list[i];
                g.DrawBeziers(Pens.Black, pt);
            }
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (list.Count < 2)
            {
                Point pt = new Point(e.X, e.Y);
                list.Add(pt);
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                if (mouseCount == 2)
                {
                    Point pt1 = new Point(e.X, e.Y);
                    if (list.Count == 4)
                    {
                        list.RemoveAt(1);
                        list.RemoveAt(1);
                    }
                    list.Insert(1, pt1);
                    list.Insert(2, pt1);
                    Invalidate();
                }
                else if (list.Count == 4)
                {
                    Point pt2 = new Point(e.X, e.Y);
                    list.RemoveAt(2);
                    list.Insert(2, pt2);
                    Invalidate();
                }
            }

        }

        private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseCount++;
        }
    }
}
