using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es11_08_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Form1 form1 = new Form1();
        static Rectangle[] snakeBlock = new Rectangle[100];
        static int blockCount = 4;
        static int direction = -1;
        static int itemX = -1, itemY, itemCount = 0;


        public void setItem()
        {
            bool conflict = true;
            while (true)
            {
                Random r = new Random();
                itemX = r.Next(24) * 10;
                itemY = r.Next(24) * 10;
                for (int i = 0; i < blockCount; i++)
                {
                    if (snakeBlock[i].X == itemX && snakeBlock[i].Y == itemY)
                        conflict = false;
                }
                if (conflict == true) break;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            snakeBlock[0] = new Rectangle(150, 200, 10, 10);
            snakeBlock[1] = new Rectangle(160, 200, 10, 10);
            snakeBlock[2] = new Rectangle(170, 200, 10, 10);
            snakeBlock[3] = new Rectangle(180, 200, 10, 10);
            blockCount = 4;
            timer1.Interval = 500 / (int)numericUpDown1.Value;
            progressBar1.Value = 0;
            progressBar1.Maximum = 5 + (int)numericUpDown1.Value * 5;
            itemCount = 0;
            direction = 0;
            setItem();
            timer1.Start();
            panel1.Invalidate();
            textBox1.Focus();
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int i;
            if (direction == -1) ;
            else if (direction == 0)  // left
            {
                for (i = blockCount - 1; i > 0; i--)
                    snakeBlock[i] = snakeBlock[i - 1];
                snakeBlock[0].X = snakeBlock[1].X - 10;
            }

            else if (direction == 1)  // right
            {
                for (i = blockCount - 1; i > 0; i--)
                    snakeBlock[i] = snakeBlock[i - 1];
                snakeBlock[0].X = snakeBlock[1].X + 10;
            }

            else if (direction == 2)  // up
            {
                for (i = blockCount - 1; i > 0; i--)
                    snakeBlock[i] = snakeBlock[i - 1];
                snakeBlock[0].Y = snakeBlock[1].Y - 10;
            }

            else if (direction == 3)  // down
            {
                for (i = blockCount - 1; i > 0; i--)
                    snakeBlock[i] = snakeBlock[i - 1];
                snakeBlock[0].Y = snakeBlock[1].Y + 10;
            }

            if (itemX != -1)
            {
                Rectangle item = new Rectangle(itemX, itemY, 10, 10);
                g.FillRectangle(System.Drawing.Brushes.Red, item);
            }

            for (i = 0; i < blockCount; i++)
                g.FillRectangle(System.Drawing.Brushes.Black, snakeBlock[i]);


            textBox1.Focus();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            snakeBlock[0] = new Rectangle(150, 200, 10, 10);
            snakeBlock[1] = new Rectangle(160, 200, 10, 10);
            snakeBlock[2] = new Rectangle(170, 200, 10, 10);
            snakeBlock[3] = new Rectangle(180, 200, 10, 10);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (snakeBlock[0].X == itemX && snakeBlock[0].Y == itemY)
            {
                itemCount++;
                progressBar1.Value++;
                setItem();
                blockCount++;
                panel1.Invalidate();
            }
            if (itemCount == progressBar1.Maximum)
            {
                numericUpDown1.Value++;
                button1_Click(sender, e);
            }
            if (snakeBlock[0].X > panel1.Width - 10 || snakeBlock[0].X < 0 || snakeBlock[0].Y > panel1.Height - 10 || snakeBlock[0].Y < 0)
            {
                timer1.Stop();
                MessageBox.Show("You die");
            }
            for (int i = 1; i < blockCount; i++)
            {
                if (snakeBlock[0].X == snakeBlock[i].X && snakeBlock[0].Y == snakeBlock[i].Y)
                {
                    timer1.Stop();
                    MessageBox.Show("You die");
                }
            }


            panel1.Invalidate();
        }

        private void textBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (direction == 2 || direction == 3)
                        direction = 0;
                    break;
                case Keys.Right:
                    if (direction == 2 || direction == 3)
                        direction = 1;
                    break;
                case Keys.Up:
                    if (direction == 0 || direction == 1)
                        direction = 2;
                    break;
                case Keys.Down:
                    if (direction == 0 || direction == 1)
                        direction = 3;
                    break;
            }
        }
    }
}
