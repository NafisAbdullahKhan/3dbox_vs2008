using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3d_Box
{
    public partial class Form1 : Form
    {
        char mode = 'R';
        const int a1 = 200,
                  a2 = 300,
                  a3 = 300,
                  a4 = 200,
                  a5 = 275,
                  a6 = 225,
                  a7 = 300,
                  a8 = 200,
                  b1 = 100,
                  b2 = 100,
                  b3 = 200,
                  b4 = 200,
                  b5 = 200,
                  b6 = 200,
                  b7 = 100,
                  b8 = 100;
        int x1 = a1,
            x2 = a2,
            x3 = a3,
            x4 = a4,
            x5 = a5,
            x6 = a6,
            x7 = a7,
            x8 = a8,
            y1 = b1,
            y2 = b2,
            y3 = b3,
            y4 = b4,
            y5 = b5,
            y6 = b6,
            y7 = b7,
            y8 = b8;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush MBrush = new SolidBrush(Color.Red);
            SolidBrush NBrush = new SolidBrush(Color.Blue);
            SolidBrush OBrush = new SolidBrush(Color.Green);
            SolidBrush PBrush = new SolidBrush(Color.Yellow);
            SolidBrush QBrush = new SolidBrush(Color.Chocolate);
            SolidBrush RBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 12);
            Graphics formGraphics = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            // Create points that define polygon.
            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);
            Point point4 = new Point(x4, y4);
            Point point5 = new Point(x5, y5);
            Point point6 = new Point(x6, y6);
            Point point7 = new Point(x7, y7);
            Point point8 = new Point(x8, y8);
            Point[] RPoints =
            {
                 point1,
                 point2,
                 point3,
                 point4,
             };
            Point[] BPoints =
            {
                 point4,
                 point3,
                 point5,
                 point6,
             };
            Point[] GPoints =
            {
                 point6,
                 point5,
                 point7,
                 point8,
             };
            Point[] YPoints =
            {
                 point8,
                 point7,
                 point2,
                 point1,
             };
            Point[] CPoints =
            {
                 point8,
                 point1,
                 point4,
                 point6,
             };
            Point[] WPoints =
            {
                 point2,
                 point7,
                 point5,
                 point3,
             };
            // Draw polygon to screen.
            if (mode == 'R')
            {
                e.Graphics.FillPolygon(PBrush, YPoints);
                e.Graphics.FillPolygon(QBrush, CPoints);
                e.Graphics.FillPolygon(RBrush, WPoints);
                e.Graphics.FillPolygon(OBrush, GPoints);
                e.Graphics.FillPolygon(MBrush, RPoints);
                e.Graphics.FillPolygon(NBrush, BPoints);
            }
            else if (mode == 'G')
            {
                e.Graphics.FillPolygon(PBrush, YPoints);
                e.Graphics.FillPolygon(QBrush, CPoints);
                e.Graphics.FillPolygon(RBrush, WPoints);
                e.Graphics.FillPolygon(MBrush, RPoints);
                e.Graphics.FillPolygon(NBrush, BPoints);
                e.Graphics.FillPolygon(OBrush, GPoints);
            }
            else if (mode == 'Y')
            {
                e.Graphics.FillPolygon(QBrush, CPoints);
                e.Graphics.FillPolygon(RBrush, WPoints);
                e.Graphics.FillPolygon(NBrush, BPoints);
                e.Graphics.FillPolygon(MBrush, RPoints);
                e.Graphics.FillPolygon(OBrush, GPoints);
                e.Graphics.FillPolygon(PBrush, YPoints);
            }
            e.Graphics.DrawString("x1=" + x1 + ",x2=" + x2 + ",x3=" + x3 + ",x4=" + x4 + ",x5=" + x5 + ",x6=" + x6 + ",x7=" + x7 + ",x8=" + x8, drawFont, MBrush, 0, 300);
            e.Graphics.DrawString("y1=" + y1 + ",y2=" + y2 + ",y3=" + y3 + ",y4=" + y4 + ",y5=" + y5 + ",y6=" + y6 + ",y7=" + y7 + ",y8=" + y8, drawFont, MBrush, 0, 350);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (y1 < y4)
                {
                    x1++;
                    x2--;
                    x5++;
                    x6--;
                    x7 = x2;
                    x8 = x1;
                    y3 -= 4;
                    y4 -= 4;
                    y7 += 4;
                    y8 += 4;
                    mode = 'R';
                }
                else if (y1 >= y4 && y3 < y5)
                {
                    x4++;
                    x3--;
                    x7++;
                    x8--;
                    x2 = x3;
                    x1 = x4;
                    y5 -= 4;
                    y6 -= 4;
                    y2 += 4;
                    y1 += 4;
                    mode = 'G';
                }
                else if (y3 >= y5)
                {
                    x6++;
                    x5--;
                    x2++;
                    x1--;
                    x3 = x5;
                    x4 = x6;
                    y7 -= 4;
                    y8 -= 4;
                    y3 += 4;
                    y4 += 4;
                    mode = 'Y';
                }
                Refresh();
            }
            else if (e.KeyCode == Keys.Down)
            {
                Refresh();
            }
        }
    }
}
