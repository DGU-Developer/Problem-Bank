using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_05_07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 0, y = 0, cx = 4;
            int h = Font.Height * 4 / 2;
            int w = Width / cx;

            HatchStyle[] a = new HatchStyle[] {
                HatchStyle.BackwardDiagonal,
                HatchStyle.Cross,
                HatchStyle.DarkDownwardDiagonal,
                HatchStyle.DarkHorizontal,
                HatchStyle.DarkUpwardDiagonal,
                HatchStyle.DarkVertical,
                HatchStyle.DashedDownwardDiagonal,
                HatchStyle.DashedHorizontal,
                HatchStyle.DashedUpwardDiagonal,
                HatchStyle.DashedVertical,
                HatchStyle.DiagonalBrick,
                HatchStyle.DiagonalCross,
                HatchStyle.Divot,
                HatchStyle.DottedDiamond,
                HatchStyle.DottedGrid,
                HatchStyle.ForwardDiagonal,
                HatchStyle.Horizontal,
                HatchStyle.HorizontalBrick,
                HatchStyle.LargeCheckerBoard,
                HatchStyle.LargeConfetti,
                HatchStyle.LargeGrid,
                HatchStyle.LightDownwardDiagonal,
                HatchStyle.LightHorizontal,
                HatchStyle.LightUpwardDiagonal,
                HatchStyle.LightVertical,
                HatchStyle.Max,
                HatchStyle.Min,
                HatchStyle.NarrowHorizontal,
                HatchStyle.NarrowVertical,
                HatchStyle.OutlinedDiamond,
                HatchStyle.Percent05,
                HatchStyle.Percent10,
                HatchStyle.Percent20,
                HatchStyle.Percent25,
                HatchStyle.Percent30,
                HatchStyle.Percent40,
                HatchStyle.Percent50,
                HatchStyle.Percent60,
                HatchStyle.Percent70,
                HatchStyle.Percent75,
                HatchStyle.Percent80,
                HatchStyle.Percent90,
                HatchStyle.Plaid,
                HatchStyle.Shingle,
                HatchStyle.SmallCheckerBoard,
                HatchStyle.SmallConfetti,
                HatchStyle.SmallGrid,
                HatchStyle.SolidDiamond,
                HatchStyle.Sphere,
                HatchStyle.Trellis,
                HatchStyle.Vertical,
                HatchStyle.Wave,
                HatchStyle.Weave,
                HatchStyle.WideDownwardDiagonal,
                HatchStyle.WideUpwardDiagonal,
                HatchStyle.ZigZag,
            };
            string[] s = new string[] {
                "BackwardDiagonal",
                "Cross",
                "DarkDownwardDiagonal",
                "DarkHorizontal",
                "DarkUpwardDiagonal",
                "DarkVertical",
                "DashedDownwardDiagonal",
                "DashedHorizontal",
                "DashedUpwardDiagonal",
                "DashedVertical",
                "DiagonalBrick",
                "DiagonalCross",
                "Divot",
                "DottedDiamond",
                "DottedGrid",
                "ForwardDiagonal",
                "Horizontal",
                "HorizontalBrick",
                "LargeCheckerBoard",
                "LargeConfetti",
                "LargeGrid",
                "LightDownwardDiagonal",
                "LightHorizontal",
                "LightUpwardDiagonal",
                "LightVertical",
                "Max",
                "Min",
                "NarrowHorizontal",
                "NarrowVertical",
                "OutlinedDiamond",
                "Percent05",
                "Percent10",
                "Percent20",
                "Percent25",
                "Percent30",
                "Percent40",
                "Percent50",
                "Percent60",
                "Percent70",
                "Percent75",
                "Percent80",
                "Percent90",
                "Plaid",
                "Shingle",
                "SmallCheckerBoard",
                "SmallConfetti",
                "SmallGrid",
                "SolidDiamond",
                "Sphere",
                "Trellis",
                "Vertical",
                "Wave",
                "Weave",
                "WideDownwardDiagonal",
                "WideUpwardDiagonal",
                "ZigZag",
            };
            for (int i = 0; i < a.Length; i++)
            {
                Rectangle r = new Rectangle(x * w, y * h, w, h);

                g.FillRectangle(new HatchBrush(a[i], Color.Black, Color.White), r);

                SizeF sa = g.MeasureString(s[i], Font);
                Rectangle tr = new Rectangle(r.X, r.Y, (int)sa.Width + 1, (int)sa.Height + 2);
                g.FillRectangle(Brushes.White, tr);
                tr.Offset(0, 2);
                g.DrawString(s[i], Font, Brushes.Black, tr);

                g.DrawRectangle(Pens.Black, r);
                x++;
                if (x == cx)
                {
                    y++;
                    x = 0;
                }
            }
            //			foreach (HatchStyle i in Enum.GetValues(typeof(HatchStyle)))
            //			{
            //				Rectangle r = new Rectangle(x * w, y * h, w, h);
            //
            //				g.FillRectangle(new HatchBrush(i, Color.Black, Color.White), r);
            //
            //				SizeF sa = g.MeasureString(i.ToString(), Font);
            //				Rectangle tr = new Rectangle(r.X, r.Y, (int)sa.Width+1, (int)sa.Height + 2);
            //				g.FillRectangle(Brushes.White, tr);
            //				tr.Offset(0, 2);
            //				g.DrawString(i.ToString(), Font, Brushes.Black, tr);
            //
            //				g.DrawRectangle(Pens.Black, r);
            //				x++;
            //				if (x == cx)
            //				{
            //					y++;
            //					x = 0;
            //				}
            //			}
            if (x != 0) y++;
            Height = (y * h) + 1;// + (Height - ClientSize.Height);
        }
    }
}
