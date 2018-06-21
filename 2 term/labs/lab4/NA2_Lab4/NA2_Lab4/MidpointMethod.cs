using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NA2_Lab4
{
    public partial class MidpointMethod : Form
    {
        public delegate double function(double x, double y);

        public MidpointMethod()
        {
            InitializeComponent();
            Module.setImageInPictureBoxFormula(pictureBoxTask);
        }

        private void MiddlePointMethod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = this.Owner as Main;
            main.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxResultH.Text = "";
            textBoxResultX.Text = "";
            textBoxResultY1.Text = "";
            textBoxResultY2.Text = "";
            textBoxResultY3.Text = "";

            double x0 = 0;
            double y0 = 1;
            double a = x0;
            double b = 5;
            int n = 33;
            function func = Module.runTheFunction;

            performMidpointMethod(a, b, func, n, x0, y0);
            performTheHeunMethod(a, b, func, n, x0, y0);
            performTheSimpleEulerMethod(a, b, func, n, x0, y0);
            performTheImprovedEulerMethod(a, b, func, n, x0, y0);
        }

        // Явный метод Эйлера
        private void performTheSimpleEulerMethod(double a, double b, function func, int n, double x0, double y0)
        {
            double length = b - a;
            double h = length / n;
            textBoxResultH.Text += "h = " + h + "\r\n";
            int roundNumber = 8;
            h = h.Truncate(roundNumber) + Math.Pow(10, -roundNumber);
            textBoxResultH.Text += "h = " + h + "\r\n";

            n = n + 1;

            double[] y = new double[n];
            y[0] = y0;
            double[] x = new double[n];
            x[0] = x0;

            for (int i=1; i<n; i++)
            {
                x[i] = x[i - 1] + h;
                y[i] = y[i - 1] + h * func(x[i - 1], y[i - 1]);
            }
            
            printArr(y, "y2", n);
        }

        // Усовершенствованый метод Эйлера
        private void performTheImprovedEulerMethod(double a, double b, function func, int n, double x0, double y0)
        {
            double length = b - a;
            double h = length / n;
            textBoxResultH.Text += "h = " + h + "\r\n";
            int roundNumber = 8;
            h = h.Truncate(roundNumber) + Math.Pow(10, -roundNumber);
            textBoxResultH.Text += "h = " + h + "\r\n";

            n = n + 1;

            double[] y = new double[n];
            y[0] = y0;
            double[] x = new double[n];
            x[0] = x0;

            for (int i = 1; i < n; i++)
            {
                x[i] = x[i - 1] + h;
                y[i] = y[i - 1] + h * (func(x[i - 1], y[i - 1]) + h / 2 * (getDerivativeX(y[i - 1]) + getDerivativeY(x[i - 1], y[i - 1]) * func(x[i - 1], y[i - 1])));
            }

            printArr(y, "y3", n);
        }

        // Метод Хойна
        private void performTheHeunMethod(double a, double b, function func, int n, double x0, double y0)
        {
            double length = b - a;
            double h = length / n;
            textBoxResultH.Text += "h = " + h + "\r\n";
            int roundNumber = 8;
            h = h.Truncate(roundNumber) + Math.Pow(10, -roundNumber);
            textBoxResultH.Text += "h = " + h + "\r\n";

            n = n + 1;

            double[] y = new double[n+1];
            y[0] = y0;
            double[] x = new double[n+1];
            x[0] = x0;

            double y1 = y[0];
            double yd = y[0];

            for (int i = 0; i < n; i++)
            {
                double innerFunction = func(x[i], y1);
                y1 = yd + (h / 2) * (func(x[i], y1) + func(x[i] + h, y1 + h * innerFunction));
                y[i] = yd;
                yd = y1;
                x[i + 1] = x[i] + h;
            }
            
            printArr(y, "y4", n);
        }

        // Метод средней точки
        private void performMidpointMethod(double a, double b, function func, int n, double x0, double y0)
        {
            double length = b - a;
            double h = length / n;
            textBoxResultH.Text += "h = " + h + "\r\n";
            int roundNumber = 8;
            h = h.Truncate(roundNumber) + Math.Pow(10, -roundNumber);
            textBoxResultH.Text += "h = " + h + "\r\n";

            n = n + 1;

            double[] y = new double[n];
            y[0] = y0;
            double[] x = new double[n];
            x[0] = x0;

            for (int i = 0; i < n-1; i++)
            {
                double innerFunction = func(x[i], y[i]);
                y[i+1] = y[i] + h * func(x[i] + h/2, y[i] + (h/2) * innerFunction);
                x[i + 1] = x[i] + h;
            }

            printArr(x, "x", n);
            printArr(y, "y1", n);
        }

        private double getDerivativeX(double y)
        {
            return -(2 / y);
        }

        private double getDerivativeY(double x, double y)
        {
            return 1 + (2 * x)/(Math.Pow(y, 2));
        }

        private void printArr(double[] arr, string name, int n)
        {
            TextBox tb = textBoxResultH;
            if (name == "x")
            {
                tb = textBoxResultX;
            }
            else if (name == "y2")
            {
                tb = textBoxResultY2;
            }
            else if (name == "y3")
            {
                tb = textBoxResultY3;
            }
            else if (name == "y1")
            {
                tb = textBoxResultY1;
            }
            else if (name == "y4")
            {
                tb = textBoxResultY4;
            }
            for (int i = 0; i < n; i++)
            {
                tb.Text += name + ":" + i + " = " + arr[i] + "\r\n";
            }
        }
    }

    static class DoubleExtensions
    {
        public static double Truncate(this double value, int precision)
        {
            var p = 1 / Math.Pow(10, precision);
            return value - (value % p);
        }
    }
}
