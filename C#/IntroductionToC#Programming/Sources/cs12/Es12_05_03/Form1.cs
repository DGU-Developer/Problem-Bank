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

namespace Es12_05_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image img = new Bitmap("./석양.jpg");
        ArrayList list = new ArrayList();
        Point startPosition = new Point(0, 0);
        int width = 800, height = 600;
        Rectangle box;


        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle sr = new Rectangle(startPosition.X, startPosition.Y, width, height);
            Rectangle dr = new Rectangle(0, 0, 800, 600);
            g.DrawImage(img, dr, sr, GraphicsUnit.Pixel);
            g.DrawRectangle(Pens.Black, box);
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            list.Clear();
            if (e.Button == MouseButtons.Left)
            {
                Point pt = new Point(e.X, e.Y);
                list.Add(pt);
            }
            else if (e.Button == MouseButtons.Right)
            {
                startPosition.X = startPosition.Y = 0;
                width = 800;
                height = 600;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point pt1 = (Point)list[0];
                Point pt2 = new Point(e.X, e.Y);
                list.Clear();
                list.Add(pt1);
                list.Add(pt2);
                int temp;
                if (pt1.X > pt2.X)
                {
                    temp = pt1.X;
                    pt1.X = pt2.X;
                    pt2.X = temp;
                }
                if (pt1.Y > pt2.Y)
                {
                    temp = pt1.Y;
                    pt1.Y = pt2.Y;
                    pt2.Y = temp;
                }
                Graphics g = CreateGraphics();
                Rectangle r = new Rectangle(pt1.X, pt1.Y, pt2.X - pt1.X, pt2.Y - pt1.Y);
                box = r;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point pt1 = (Point)list[0];
            Point pt2 = (Point)list[1];
            int temp;
            if (pt1.X > pt2.X)
            {
                temp = pt1.X;
                pt1.X = pt2.X;
                pt2.X = temp;
            }
            if (pt1.Y > pt2.Y)
            {
                temp = pt1.Y;
                pt1.Y = pt2.Y;
                pt2.Y = temp;
            }
            startPosition.X = pt1.X;
            startPosition.Y = pt1.Y;
            width = Math.Abs(pt2.X - pt1.X);
            height = Math.Abs(pt2.Y - pt1.Y);
            Rectangle temp1 = new Rectangle(0, 0, 0, 0);
            box = temp1;
            Invalidate();
        }
    }
}
