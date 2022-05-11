using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezierLine
{
    public partial class Form1 : Form
    {
        private const double Step = 0.01;
        private int pointCount = 3;
        private List<Point> points = new List<Point>();
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (points.Count < pointCount)
            {
                int x = this.PointToClient(Cursor.Position).X;
                int y = this.PointToClient(Cursor.Position).Y;
                graphics.DrawRectangle(new Pen(Color.Black, 4), new Rectangle(x, y, 1, 1));

                points.Add(new Point(x, y));
            } 
            else
            {
                MessageBox.Show("Point count exceeded, enter bigger point count");
            }
        }

        private void pointCountButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(pointCountTextBox.Text, out pointCount))
            {
                if (pointCount < 2)
                {
                    MessageBox.Show("Point count must be bigger than or equal to two");
                }
                else
                {
                    graphics.Clear(Color.LightGray);
                    points = new List<Point>();
                }
            }
            else
            {
                MessageBox.Show("Point count must be an integer number");
            }
        }

        private void DrawBezierCurve(List<Point> controlPoints)
        {
            Point prevPoint = controlPoints.ElementAt(0);
            int n = controlPoints.Count;
            for (double t = Step; t <= 1; t += Step)
            {
                double x = 0, y = 0;
                double Bernstein;
                for (int i = 0; i < n; ++i)
                {
                    Bernstein = CalculateBernsteinPolynomValue(n - 1, i, t);
                    x += Bernstein * controlPoints[i].X;
                    y += Bernstein * controlPoints[i].Y;

                }

                Point newPoint = new Point((int) x, (int) y);

                graphics.DrawLine(new Pen(new SolidBrush(Color.Red)), prevPoint, newPoint);
                prevPoint = newPoint;
            }
            graphics.DrawLine(new Pen(new SolidBrush(Color.Red)), prevPoint, controlPoints.ElementAt(controlPoints.Count - 1));
        }

        private double CalculateBernsteinPolynomValue(int n, int i, double t)
        {
            double value = (Factorial(n) * Math.Pow(1.0 - t, n - i) * Math.Pow(t, i)) / (Factorial(i) * Factorial(n - i));
            return value;
        }

        private long Factorial(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; ++i)
            {
                factorial *= i;
            }
            return factorial;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (points.Count > 1)
            {
                DrawBezierCurve(points);
            } 
        }
    }
}
