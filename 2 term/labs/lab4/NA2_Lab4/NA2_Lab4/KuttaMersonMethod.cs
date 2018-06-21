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
    public partial class KuttaMersonMethod : Form
    {
        public delegate double function(double x, double y);

        public KuttaMersonMethod()
        {
            InitializeComponent();
            Module.setImageInPictureBoxFormula(pictureBoxTask);
        }

        private void KutteMersonMethod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = this.Owner as Main;
            main.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxResultX.Text = "";
            textBoxResultY.Text = "";
            textBoxResultH.Text = "";

            double x0 = 0;
            double y0 = 1;
            double a = x0;
            double b = 5;
            int n = 33;
            function func = Module.runTheFunction;

            performKutteMersonMethod(func, x0, y0, b, a, n);
        }

        private void performKutteMersonMethod(function func, double x0, double y0, double b, double a, int n)
        {
            double epsilon = Module.getDoubleValueFromString(textBoxEps.Text, textBoxResultH);
            double length = b - a;
            double h = length / n;
            textBoxResultH.Text += "h = " + h + "\r\n";
            int roundNumber = 8;
            h = h.Truncate(roundNumber) + Math.Pow(10, -roundNumber);
            textBoxResultH.Text += "Rounded h = " + h + "\r\n";

            n = n + 1;

            double[] y = new double[n];
            y[0] = y0;
            double[] yT = new double[n];
            double[] x = new double[n];
            x[0] = x0;
            double[,] k = new double[5, 33];
            double R = 0;

            for (int i=0; i<n-1; i++)
            {
                k[0, i] = func(x[i], y[i]);
                while (true)
                {
                    k[1, i] = func(x[i] + h / 3, y[i] + k[0, i] * h / 3);
                    k[2, i] = func(x[i] + h / 3, y[i] + (h / 6) * (k[0, i] + k[1, i]));
                    k[3, i] = func(x[i] + h / 2, y[i] + (k[0, i] * h / 8) + (k[1, i] * 3 * h / 8));
                    k[4, i] = func(x[i] + h, y[i] + (k[0, i] * h / 2) - (k[2, i] * 3 * h / 2) + (k[3, i] * 2 * h));
                    yT[i + 1] = y[i] + (h / 2) * (k[0, i] - 3 * k[2, i] + 4 * k[3, i]);
                    y[i + 1] = y[i] + (h / 6) * (k[0, i] + 4 * k[3, i] + k[4, i]);

                    R = 0.2 * Math.Abs(y[i + 1] - yT[i + 1]);
                    if (R > epsilon)
                    {
                        h = h / 2;
                    }
                    else
                    {
                        break;
                    }
                }
                x[i + 1] = x[i] + h;
            }
            printArr(y, "y");
            printArr(x, "x");
        }

        private void printArr(double[] arr, string name)
        {
            TextBox tb = textBoxResultH;
            if (name == "x")
            {
                tb = textBoxResultX;
            }
            else if (name == "y")
            {
                tb = textBoxResultY;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                tb.Text += name + i + " = " + arr[i] + "\r\n";
            }
        }
    }
}
