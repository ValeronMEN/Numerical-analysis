﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NA2_Lab3
{
    public partial class RecTrap : Form
    {
        public delegate double function(double x);

        public RecTrap()
        {
            InitializeComponent();
            setImageInPictureBoxFormula();
        }

        private void RecTrap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = this.Owner as Main;
            main.Show();
        }

        private void setImageInPictureBoxFormula()
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\DrLove\Documents\Visual Studio 2015\Projects\NA2_Lab3\NA2_Lab3\images\lab23_formula.JPG", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            pictureBoxFormula.Image = img;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double b = 7;
            double a = 3;
            double epsilon = getDoubleValueFromString(textBoxPrecision.Text);
            rectangleTrapeziumAlgorithm(b, a, runTheFunction, epsilon);
        }

        private void rectangleTrapeziumAlgorithm(double b, double a, function func, double epsilon)
        {
            int maxArrSize = 30; // this is my value for an array max size

            int n = 1;
            double H = b - a;
            double ItH = (H / 2) * (func(b) + func(a)); // I^T(H)

            double Ich; // result
            double[,] resultArr = new double[maxArrSize,4];
            resultArr[0, 0] = ItH;
            // there will be more elements for this array:
            // resultArr[0, 1] = IpH;
            // resultArr[0, 2] = Ith;
            // resultArr[0, 3] = Rth;

            int j = 0; // the 'while' count
            while (true)
            {
                double h = H / 2;
                double x = a + h;
                double y;
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (i != 1)
                    {
                        x = x + H;
                    }
                    y = func(x);
                    sum += y;
                }
                double IpH = resultArr[j, 1] = sum * H; // I^P(H)

                double Ith = resultArr[j, 2] = 0.5 * (IpH + ItH); // I^T(h)
                double Rth = resultArr[j, 3] = (1 / 3) * (Ith - ItH); // R^T(h)

                Rth = Math.Abs(Rth);
                if (Rth > epsilon)
                {
                    n = 2 * n;
                    H = h;
                    resultArr[j+1, 0] = ItH = Ith;
                }
                else
                {
                    Ich = Ith + Rth;
                    break;
                }
                j++;
            }
            textBoxResult.Text += "Result (I^C(h)): " + Ich + "\r\n";
            printTheResultTable(resultArr, j+1);
        }

        private void printTheResultTable(double [,] resultArr, int size)
        {
            textBoxResult.Text += ">>> ItH IpH Ith Rth\r\n";
            for (int i=0; i<size; i++)
            {
                textBoxResult.Text += "n=" + i + ": ";
                for (int j=0; j<4; j++)
                {
                    textBoxResult.Text += resultArr[i, j] + " ";
                }
                textBoxResult.Text += "\r\n";
            }
        }

        // function
        private double runTheFunction(double x)
        {
            double sqrtValue = Math.Sqrt(Math.Cos(2 * x));
            if (Double.IsNaN(sqrtValue))
            {
                return 0;
            }
            return (Math.Sin(x) * Math.Cos(x)) / sqrtValue + 4 * Math.Exp(x) * Math.Cos(x);
        }

        private double getDoubleValueFromString(string tb)
        {
            string[] parts = tb.Split('.');
            try
            {
                Convert.ToDouble(parts[0]);
            }
            catch (FormatException exc)
            {
                textBoxResult.Text += "Error with parts[0]: \r\n" + exc;
            }
            if (parts.Length == 1)
            {
                return Convert.ToDouble(parts[0]);
            }
            try
            {
                Convert.ToDouble(parts[1]);
            }
            catch (FormatException exc)
            {
                textBoxResult.Text += "Error with parts[1]: \r\n" + exc;
            }
            double integer = Convert.ToDouble(parts[0]);
            double fractionInt = Convert.ToDouble(parts[1]);
            double fraction = 0;
            while (fractionInt >= 1)
            {
                fractionInt = fraction = fractionInt / 10;
            }
            return integer + fraction;
        }
    }
}
