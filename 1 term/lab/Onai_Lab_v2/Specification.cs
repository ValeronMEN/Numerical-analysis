﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onai_Lab_v2
{
    public partial class Specification : Form
    {
        private String example16 = "(cosx)^3 + x^3 * (log2(sinh(x) + cosh(x)))^3 - x^3 = 5";
        private String example24 = "x^3 - (cos(x))^2 - 5x = 3";

        public delegate double function(double x);

        public Specification()
        {
            InitializeComponent();
        }

        private void Specification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxError.Text = "";
            switch (comboBoxNumberOfExample.SelectedIndex)
            {
                case 0:
                    equation.Text = example24;
                    textBoxMethod.Text = "Method of chords";
                    textBoxE.Text = "0,00000001";
                    break;
                case 1:
                    equation.Text = example16;
                    textBoxMethod.Text = "Simple iterations method";
                    textBoxE.Text = "0,0001";
                    break;
                case 2:
                    equation.Text = example16;
                    textBoxMethod.Text = "Simplified Newton method";
                    textBoxE.Text = "0,0001";
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            textBoxError.Text = "";
            ResultBox.Text = "Starting...\r\n";
            if (comboBoxNumberOfExample.SelectedIndex == -1)
            {
                textBoxError.Text = "Method and example aren't defined";
                ResultBox.Text += "Error: " + textBoxError.Text + "\r\n";
                return;
            }
            try
            {
                Convert.ToDouble(textBoxA.Text);
                Convert.ToDouble(textBoxB.Text);
                Convert.ToDouble(textBoxE.Text);
            }
            catch (FormatException exc)
            {
                textBoxError.Text = "Error in a, b or E values";
                ResultBox.Text += "Error: " + textBoxError.Text + "\r\n" + exc;
                return;
            }
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double e = Convert.ToDouble(textBoxE.Text);
            double result;
            switch (comboBoxNumberOfExample.SelectedIndex)
            {
                case 0:
                    if (!checkErrorsInInterval(a, b, example24Function))
                        return;
                    result = methodOfChords(a, b, e, example24Function, example24FunctionDerivative1, example24FunctionDerivative2);
                    break;
                case 1:
                    if (!checkErrorsInInterval(a, b, example16Function))
                        return;
                    result = methodOfSimpleIterations(a, b, e, example16Function, example16FunctionDerivative1);
                    break;
                case 2:
                    if (!checkErrorsInInterval(a, b, example16Function))
                        return;
                    result = methodOfNewtonMod(a, b, e, example16Function, example16FunctionDerivative1, example16FunctionDerivative2);
                    break;
                default:
                    throw new Exception("Incorrect method!");
            }
            ResultBox.AppendText("Result: " + result.ToString());
            MessageBox.Show("Success!\r\nResult: " + result.ToString());
            return;
        }

        private bool checkErrorsInInterval(double a, double b, function f)
        {
            if (!checkReducingOrIncreasing(a, b, f))
            {
                textBoxError.Text = "The line segment is not monotonous!";
                ResultBox.Text += "Error: " + textBoxError.Text + "\r\n";
                return false;
            }
            if ((f(a) >= 0 && f(b) >= 0) || (f(a) < 0 && f(b) < 0))
            {
                textBoxError.Text = "Function doesn't cross Ox in this line segment!";
                ResultBox.Text += "Error: " + textBoxError.Text + "\r\n";
                return false;
            }
            return true;
        }

        private bool checkReducingOrIncreasing(double a, double b, function f)
        {
            double d = 0.001;
            double c = a;
            int n = 0;
            while (c < b)
            {
                c += d;
                if ((f(c) >= 0 && f(c - d) < 0) || (f(c) < 0 && f(c - d) >= 0))
                {
                    if (n == 1)
                    {
                        return false;
                    }
                    else if (n == 0)
                    {
                        n++;
                    }
                }
            }
            return true;
        }

        private double example24Function(double x)
        {
            return Math.Pow(x, 3) - Math.Pow(Math.Cos(x), 2) - 5 * x - 3;
        }

        private double example24FunctionDerivative1(double x)
        {
            return 3 * Math.Pow(x, 2) + Math.Sin(2 * x) - 5;
        }

        private double example24FunctionDerivative2(double x)
        {
            return 2 * (3 * x + Math.Cos(2 * x));
        }

        private double methodOfChords(double a, double b, double e, function f, function fder1, function fder2)
        {
            if (f(a) * fder2(a) < 0)
            {
                double c = a;
                a = b;
                b = c;
            }
            int n = 1;
            double b1;
            while (true)
            {
                b1 = methodOfChordsIteration(a, b, f);
                ResultBox.AppendText("b" + n.ToString() + " = " + b1.ToString() + " (a = " + a.ToString() + ")\r\n");
                ResultBox.AppendText("root: " + b1.ToString() + ", iteration №" + n.ToString() + "\r\n");
                if (methodOfChordsCriterion(b, b1, e, f, fder1))
                {
                    return b1;
                }
                b = b1;
                n++;
            }
        }

        private double methodOfChordsIteration(double a, double bn, function f)
        {
            return bn - ((a - bn) * f(bn)) / (f(a) - f(bn));
        }

        private bool methodOfChordsCriterion(double x1, double x2, double e, function f, function fder1)
        {
            double c = Math.Abs(fder1(x1));
            ResultBox.Text += "Criterion: |f(x(n+1))| = " + Math.Abs(f(x2)) + "; alpha * epsilon = " + c * e + "\r\n";
            return Math.Abs(f(x2)) < c * e;
        }

        private double example16Function(double x)
        {
            return Math.Pow(Math.Cos(x), 3) + Math.Pow(x, 3) * Math.Pow(Math.Log((Math.Sinh(x) + Math.Cosh(x)), 2), 3) - Math.Pow(x, 3) - 5;
        }

        //(-3 * x^2 - 3 * sin(x) * (cos(x))^2 + (3 * x^3 * (log(sinh(x) + cosh(x)))^2) / (log(2)^3) + (3 * x^2 * (log(sinh(x) + cosh(x)))^3) / (log(2)^3))'
        private double example16FunctionDerivative1(double x)
        {
            return Math.Pow(x, 2) * (-3) - 3 * Math.Sin(x) * Math.Pow(Math.Cos(x), 2) +
                (3 * Math.Pow(x, 3) * Math.Pow(Math.Log(Math.Sinh(x) + Math.Cosh(x)), 2)) / (Math.Pow(Math.Log(2), 3)) +
                (3 * Math.Pow(x, 2) * Math.Pow(Math.Log(Math.Sinh(x) + Math.Cosh(x)), 3)) / (Math.Pow(Math.Log(2), 3));
        }

        private double example16FunctionDerivative2(double x)
        {
            return (-6) * x - 3 * Math.Pow(Math.Cos(x), 3) + 6 * Math.Cos(x) * Math.Pow(Math.Sin(x), 2) +
                (6 * x * Math.Pow(Math.Log(Math.Sinh(x) + Math.Cosh(x)), 3)) / (Math.Pow(Math.Log(2), 3)) +
                (6 * Math.Pow(x, 3) * Math.Log(Math.Sinh(x) + Math.Cosh(x))) / (Math.Pow(Math.Log(2), 3)) +
                (18 * Math.Pow(x, 2) * Math.Pow(Math.Log(Math.Sinh(x) + Math.Cosh(x)), 2)) / (Math.Pow(Math.Log(2), 3));
        }

        private double methodOfNewtonMod(double a, double b, double e, function f, function fder1, function fder2)
        {
            int n = 0;
            if (f(a) * fder2(a) < 0)
            {
                double c = a;
                a = b;
                b = c;
            }
            double a1, a0 = a;
            while (true)
            {
                a1 = methodOfNewtonModIteartion(a, a0, f, fder1);
                ResultBox.AppendText("a" + n.ToString() + " = " + a1.ToString() + " (b = " + b.ToString() + ")\r\n");
                if (methodOfChordsCriterion(a, a1, e, f, fder1))
                {
                    return a1;
                }
                a = a1;
                n++;
            }
        }

        private double methodOfNewtonModIteartion(double a, double a0, function f, function fder1)
        {
            return a - (f(a)/ fder1(a0));
        }

        private double methodOfSimpleIterations(double a, double b, double e, function f, function fder1)
        {
            if (a > b)
            {
                double c = a;
                a = b;
                b = c;
            }
            double j1 = fder1(a);
            double j2 = fder1(b);
            double lambda = 2 / (j1 + j2);
            double q = (j2 - j1) / (j2 + j1);
            ResultBox.AppendText("alpha = " + j1 + "; gamma = " + j2 + "; lambda = " + lambda + "; q = " + q + "\r\n");

            double xn1 = a, xn2;
            int n = 1;
            while (true)
            {
                xn2 = xn1 - lambda * f(xn1);
                ResultBox.AppendText(n.ToString() + " iteration. Root: " + xn2.ToString() + "\r\n");
                if (Math.Abs(xn2 - xn1) <= ((1 - q) / q) * e)
                {
                    return xn2;
                }
                n++;
                if (n > 2000)
                {
                    ResultBox.AppendText("The iteration number became more than 2000. Overflow!\r\nAborting...\r\n");
                    return xn2;
                }
                xn1 = xn2;
            }
        }
    }
}
