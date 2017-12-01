using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_05_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            numericUpDown1.Value = DateTime.Today.Year;
            comboBox1.SelectedItem = DateTime.Today.Month.ToString();
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            string[] dayOfWeekConst = { "일", "월", "화", "수", "목", "금", "토" };
            Graphics g = e.Graphics;

            int j = 0;

            int yearCount, monthCount, dayOfWeek = 1;
            for (yearCount = 1; yearCount < (int)numericUpDown1.Value; yearCount++)
            {
                if (DateTime.IsLeapYear(yearCount))
                    dayOfWeek += 366;
                else dayOfWeek += 365;
            }
            for (monthCount = 1; monthCount < int.Parse(comboBox1.SelectedItem.ToString()); monthCount++)
                dayOfWeek += DateTime.DaysInMonth(yearCount, monthCount);
            dayOfWeek %= 7;

            for (int i = 0; i < 7; i++)
            {
                Font f = new Font("굴림", 10);
                if (i == 0)
                    g.DrawString(dayOfWeekConst[i], f, Brushes.Red, 15 + i * 40, 50);
                else if (i == 6)
                    g.DrawString(dayOfWeekConst[i], f, Brushes.Blue, 15 + i * 40, 50);
                else
                    g.DrawString(dayOfWeekConst[i], f, Brushes.Black, 15 + i * 40, 50);
            }
            for (int i = 1; i <= DateTime.DaysInMonth((int)numericUpDown1.Value, int.Parse(comboBox1.SelectedItem.ToString())); i++)
            {
                Font f = new Font("굴림", 10); ;
                if (i == DateTime.Today.Day)
                {
                    f = new Font("굴림", 10, FontStyle.Bold);
                    g.FillRectangle(Brushes.White, 15 + dayOfWeek * 40, 70 + j * 20, 20, 15);
                }
                if (dayOfWeek == 0)
                    g.DrawString(i.ToString(), f, Brushes.Red, 15 + dayOfWeek * 40, 70 + j * 20);
                else if (dayOfWeek == 6)
                    g.DrawString(i.ToString(), f, Brushes.Blue, 15 + dayOfWeek * 40, 70 + j * 20);
                else
                    g.DrawString(i.ToString(), f, Brushes.Black, 15 + dayOfWeek * 40, 70 + j * 20);

                if (dayOfWeek == 6)
                {
                    dayOfWeek = 0;
                    j++;
                }
                else dayOfWeek++;
            }

        }

        private void date_Changed(object sender, System.EventArgs e)
        {
            Invalidate();
        }
    }
}
