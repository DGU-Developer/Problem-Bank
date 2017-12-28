using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_05_07_01
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
            KnownColor[] a = new KnownColor[] {
                KnownColor.ActiveBorder,
                KnownColor.ActiveCaption,
                KnownColor.ActiveCaptionText,
                KnownColor.AliceBlue,
                KnownColor.AntiqueWhite,
                KnownColor.AppWorkspace,
                KnownColor.Aqua,
                KnownColor.Aquamarine,
                KnownColor.Azure,
                KnownColor.Beige,
                KnownColor.Bisque,
                KnownColor.Black,
                KnownColor.BlanchedAlmond,
                KnownColor.Blue,
                KnownColor.BlueViolet,
                KnownColor.Brown,
                KnownColor.BurlyWood,
                KnownColor.CadetBlue,
                KnownColor.Chartreuse,
                KnownColor.Chocolate,
                KnownColor.Control,
                KnownColor.ControlDark,
                KnownColor.ControlDarkDark,
                KnownColor.ControlLight,
                KnownColor.ControlLightLight,
                KnownColor.ControlText,
                KnownColor.Coral,
                KnownColor.CornflowerBlue,
                KnownColor.Cornsilk,
                KnownColor.Crimson,
                KnownColor.Cyan,
                KnownColor.DarkBlue,
                KnownColor.DarkCyan,
                KnownColor.DarkGoldenrod,
                KnownColor.DarkGray,
                KnownColor.DarkGreen,
                KnownColor.DarkKhaki,
                KnownColor.DarkMagenta,
                KnownColor.DarkOliveGreen,
                KnownColor.DarkOrange,
                KnownColor.DarkOrchid,
                KnownColor.DarkRed,
                KnownColor.DarkSalmon,
                KnownColor.DarkSeaGreen,
                KnownColor.DarkSlateBlue,
                KnownColor.DarkSlateGray,
                KnownColor.DarkTurquoise,
                KnownColor.DarkViolet,
                KnownColor.DeepPink,
                KnownColor.DeepSkyBlue,
                KnownColor.Desktop,
                KnownColor.DimGray,
                KnownColor.DodgerBlue,
                KnownColor.Firebrick,
                KnownColor.FloralWhite,
                KnownColor.ForestGreen,
                KnownColor.Fuchsia,
                KnownColor.Gainsboro,
                KnownColor.GhostWhite,
                KnownColor.Gold,
                KnownColor.Goldenrod,
                KnownColor.Gray,
                KnownColor.GrayText,
                KnownColor.Green,
                KnownColor.GreenYellow,
                KnownColor.Highlight,
                KnownColor.HighlightText,
                KnownColor.Honeydew,
                KnownColor.HotPink,
                KnownColor.HotTrack,
                KnownColor.InactiveBorder,
                KnownColor.InactiveCaption,
                KnownColor.InactiveCaptionText,
                KnownColor.IndianRed,
                KnownColor.Indigo,
                KnownColor.Info,
                KnownColor.InfoText,
                KnownColor.Ivory,
                KnownColor.Khaki,
                KnownColor.Lavender,
                KnownColor.LavenderBlush,
                KnownColor.LawnGreen,
                KnownColor.LemonChiffon,
                KnownColor.LightBlue,
                KnownColor.LightCoral,
                KnownColor.LightCyan,
                KnownColor.LightGoldenrodYellow,
                KnownColor.LightGray,
                KnownColor.LightGreen,
                KnownColor.LightPink,
                KnownColor.LightSalmon,
                KnownColor.LightSeaGreen,
                KnownColor.LightSkyBlue,
                KnownColor.LightSlateGray,
                KnownColor.LightSteelBlue,
                KnownColor.LightYellow,
                KnownColor.Lime,
                KnownColor.LimeGreen,
                KnownColor.Linen,
                KnownColor.Magenta,
                KnownColor.Maroon,
                KnownColor.MediumAquamarine,
                KnownColor.MediumBlue,
                KnownColor.MediumOrchid,
                KnownColor.MediumPurple,
                KnownColor.MediumSeaGreen,
                KnownColor.MediumSlateBlue,
                KnownColor.MediumSpringGreen,
                KnownColor.MediumTurquoise,
                KnownColor.MediumVioletRed,
                KnownColor.Menu,
                KnownColor.MenuText,
                KnownColor.MidnightBlue,
                KnownColor.MintCream,
                KnownColor.MistyRose,
                KnownColor.Moccasin,
                KnownColor.NavajoWhite,
                KnownColor.Navy,
                KnownColor.OldLace,
                KnownColor.Olive,
                KnownColor.OliveDrab,
                KnownColor.Orange,
                KnownColor.OrangeRed,
                KnownColor.Orchid,
                KnownColor.PaleGoldenrod,
                KnownColor.PaleGreen,
                KnownColor.PaleTurquoise,
                KnownColor.PaleVioletRed,
                KnownColor.PapayaWhip,
                KnownColor.PeachPuff,
                KnownColor.Peru,
                KnownColor.Pink,
                KnownColor.Plum,
                KnownColor.PowderBlue,
                KnownColor.Purple,
                KnownColor.Red,
                KnownColor.RosyBrown,
                KnownColor.RoyalBlue,
                KnownColor.SaddleBrown,
                KnownColor.Salmon,
                KnownColor.SandyBrown,
                KnownColor.ScrollBar,
                KnownColor.SeaGreen,
                KnownColor.SeaShell,
                KnownColor.Sienna,
                KnownColor.Silver,
                KnownColor.SkyBlue,
                KnownColor.SlateBlue,
                KnownColor.SlateGray,
                KnownColor.Snow,
                KnownColor.SpringGreen,
                KnownColor.SteelBlue,
                KnownColor.Tan,
                KnownColor.Teal,
                KnownColor.Thistle,
                KnownColor.Tomato,
                KnownColor.Transparent,
                KnownColor.Turquoise,
                KnownColor.Violet,
                KnownColor.Wheat,
                KnownColor.White,
                KnownColor.WhiteSmoke,
                KnownColor.Window,
                KnownColor.WindowFrame,
                KnownColor.WindowText,
                KnownColor.Yellow,
                KnownColor.YellowGreen,
            };
            int x = 0, y = 0, cx = 5;
            int h = Font.Height * 4 / 2;
            int w = Width / cx;
            for (int i = 0; i < a.Length; i++)
            {
                Color bc = Color.FromKnownColor(a[i]);
                if (bc.IsSystemColor == true)   // True:색상, False:시스템색상
                    continue;

                Rectangle r = new Rectangle(x * w, y * h, w, h);

                g.FillRectangle(new SolidBrush(Color.FromKnownColor(a[i])), r);

                SizeF sa = g.MeasureString(a[i].ToString(), Font);

                Rectangle tr = new Rectangle(r.X, r.Y, (int)sa.Width + 1, (int)sa.Height + 2);
                g.FillRectangle(Brushes.White, tr);
                tr.Offset(0, 2);
                g.DrawString(a[i].ToString(), Font, Brushes.Black, tr);

                g.DrawRectangle(Pens.Black, r);
                x++;
                if (x == cx)
                {
                    y++;
                    x = 0;
                }

                // 색상이름을 가운데 정렬로 표시
                //				Color bc = Color.FromKnownColor((KnownColor)i);
                //				if (bc.IsSystemColor == false)
                //					continue;
                //
                //				Rectangle r = new Rectangle(x * w, y * h, w, h);
                //				StringFormat sf = new StringFormat();
                //				sf.Alignment = StringAlignment.Center;        // 수평 정렬
                //				sf.LineAlignment = StringAlignment.Center;	// 수직 정렬
                //
                //				g.FillRectangle(new SolidBrush(bc), r);
                //				g.DrawRectangle(Pens.Black, r);
                //
                //				Color fc1 = bc.GetBrightness() >= 0.5 ? Color.Black : Color.White;
                //				g.DrawString(((KnownColor)i).ToString(), Font, new SolidBrush(fc1), r, sf);
                //				x++;
                //				if (x == cx)
                //				{
                //					y++;
                //					x = 0;
                //				}
            }
            if (x != 0) y++;
            Height = (y * h) + 1;// + (Height - ClientSize.Height);
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
        }
    }
}
