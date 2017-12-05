using System;
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
    public partial class Lobachevskiy : Form
    {
        public Lobachevskiy()
        {
            InitializeComponent();
        }

        private void Lobachevskiy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxError.Text = "";
            ResultBox.Text = "Starting...\r\n";
            try
            {
                Convert.ToDouble(tb7.Text);
                Convert.ToDouble(tb6.Text);
                Convert.ToDouble(tb5.Text);
                Convert.ToDouble(tb4.Text);
                Convert.ToDouble(tb3.Text);
                Convert.ToDouble(tb2.Text);
                Convert.ToDouble(tb1.Text);
                Convert.ToDouble(tb0.Text);
                Convert.ToDouble(textBoxE.Text);
                Convert.ToInt32(textBoxCancel.Text);
            }
            catch (FormatException exc)
            {
                textBoxError.Text = "Ошибка в значениях коэфициентов";
                ResultBox.Text += "Error: " + textBoxError.Text + "\r\n" + exc;
                return;
            }
            double [] a = new double[8];
            int n = 5;
            a[7] = Convert.ToDouble(tb7.Text);
            a[6] = Convert.ToDouble(tb6.Text);
            a[5] = Convert.ToDouble(tb5.Text);
            a[4] = Convert.ToDouble(tb4.Text);
            a[3] = Convert.ToDouble(tb3.Text);
            a[2] = Convert.ToDouble(tb2.Text);
            a[1] = Convert.ToDouble(tb1.Text);
            a[0] = Convert.ToDouble(tb0.Text);
            for (int i = 7; i >= 0; i--)
            {
                if (a[i] != 0)
                {
                    if (i == 0)
                    {
                        textBoxError.Text = "Неправильное уравнение!";
                        ResultBox.Text += "Error: " + textBoxError.Text + "\r\n";
                        return;
                    }
                    n = i;
                    break;
                }
            }

            double[] aNew = new double[n+1];
            for (int i = 0; i<(n+1); i++)
            {
                aNew[i] = a[i];
            }

            ResultBox.AppendText("Extent of equation is " + n.ToString() + "\r\n");
            displayArray(aNew, "Coefficients");
            int minCoefWhenWeNeedToShortCoefs = 30;
            aNew = shortArrayInNumber(aNew, minCoefWhenWeNeedToShortCoefs, getMinCoefAbs(a));

            displayTitle("Finding roots with Lobachevskiy method");
            double[] x = methodLobachevskiy(Convert.ToDouble(textBoxE.Text), aNew);

            displayTitle("Checking signs of roots");
            int cancel = Convert.ToInt32(textBoxCancel.Text);
            ResultBox.AppendText("Cancel is " + cancel + "\r\n");
            x = getSignedRoots(x, aNew, cancel);
            displayArray(x, "Proper roots (NaN appears when it's impossible to define sign)");

            displayTitle("Simple method of finding boundaries");
            double R = calculateBigRadius(aNew);
            double r = calculateSmallRadius(aNew);
            displayBoundaries(R, r);
            string boundariesResult1 = "Range of positive numbers: (" + r.ToString() + "; " + R.ToString() + ")\r\nRange of negative numbers: (-" + R.ToString() + "; -" + r.ToString() + ")\r\n";
            ResultBox.AppendText(boundariesResult1);

            displayTitle("Westerfield method of finding boundaries");
            R = getRadiusOverWesterfieldMethod(aNew);
            r = getRadiusOverWesterfieldMethod(inverseArray(aNew));
            displayBoundaries(R, r);
            string boundariesResult2 = "Range of positive numbers: (0; " + R.ToString() + ")\r\nRange of negative numbers: (-" + r.ToString() + "; 0)\r\n";
            ResultBox.AppendText(boundariesResult2);
            ResultBox.AppendText("Sending results...");

            MessageBox.Show("Success!\r\nRoots: " + getPrintedArray(x) + "\r\nI method:\r\n" + boundariesResult1 + "II method:\r\n" + boundariesResult2);
        }

        private double[] getSignedRoots(double [] x, double [] a, int cancel)
        {
            double[] yPos = new double [x.Length];
            double[] yNeg = new double[x.Length];
            for (int i=0; i<x.Length; i++)
            {
                yPos[i] = Math.Round(solveEquation(x[i], a), cancel);
                yNeg[i] = Math.Round(solveEquation(-1*x[i], a), cancel);
            }
            displayArray(yPos, "Ys with positive substituted roots");
            displayArray(yNeg, "Ys with negative substituted roots");
            for (int i=0; i<x.Length; i++)
            {
                if (yPos[i] == 0)
                {
                    x[i] = x[i];
                }
                else if (yNeg[i] == 0)
                {
                    x[i] = (-1) * x[i];
                }
                else
                {
                    x[i] = double.NaN;
                }
            }
            return x;
        }

        private double solveEquation(double x, double [] a)
        {
            double sum = 0;
            for (int i=0; i<a.Length; i++)
            {
                sum += a[i] * Math.Pow(x, i);
            }
            return sum;
        }

        private double[] inverseArray(double [] a)
        {
            double[] toReturn = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                toReturn[a.Length - 1 - i] = a[i];
            }
            return toReturn;
        }

        private double getRadiusOverWesterfieldMethod(double [] a)
        {
            if (a[a.Length - 1] != 1)
            {
                a = shortArrayInNumber(a, 0, a[a.Length - 1]);
            }
            double max1 = 0, max2 = 0, current;
            for (int t = 1; t < a.Length; t++)
            {
                current = Math.Pow(Math.Abs(a[a.Length - 1 - t]), (1 / Convert.ToDouble(t)));
                if (t == 1)
                {
                    max1 = current;
                }
                else if (t == 2)
                {
                    max2 = current;
                }
                else
                {
                    if (current > max1)
                    {
                        max1 = current;
                    }
                    else
                    {
                        if (current > max2)
                        {
                            max2 = current;
                        }
                    }
                }
            }
            return max1 + max2;
        }

        private double calculateBigRadius(double[] a)
        {
            return 1 + (getMaxCoefWithBounds(a, 0, a.Length - 1) / Math.Abs(a[a.Length - 1]));
        }

        private double calculateSmallRadius(double[] a)
        {
            return 1/(1 + getMaxCoefWithBounds(a, 1, a.Length) / Math.Abs(a[0]));
        }

        private double[] methodLobachevskiy(double eps, double[] a)
        {
            double criterion;
            int numberOfIteration = 0;
            while (true)
            {
                ResultBox.AppendText(numberOfIteration + " iteration...\r\n");
                double[] b = methodLobachevskiyIteration(a);
                displayArray(b, "Coefficients");
                if (checkOverflow(b))
                {
                    double[] x = calculateRoots(a, numberOfIteration);
                    displayArray(x, "Roots");
                    return x;
                }
                numberOfIteration++;
                criterion = methodLobachevskiyCriterion(a, b);
                ResultBox.AppendText("Criterion: " + criterion + "; epsilon = " + eps + "\r\n");
                if (criterion < eps)
                {
                    double[] x = calculateRoots(b, numberOfIteration);
                    displayArray(x, "Roots");
                    return x;
                }
                a = b;
            }
        }

        private double[] calculateRoots(double[] b, int numberOfIteration)
        {
            double[] x = new double[b.Length-1];
            for (int i = 1; i < b.Length; i++)
            {
                x[i-1] = Math.Pow(((b[b.Length - 1 - i]) / (b[b.Length - i])), 1 / (Math.Pow(2, numberOfIteration)));
                ResultBox.AppendText(i + ") root is " + x[i-1].ToString() + "\r\n");
            }
            return x;
        }

        private bool checkOverflow(double[] a)
        {
            for (int i=0; i<a.Length; i++)
            {
                if (double.IsNaN(a[i]) || double.IsInfinity(a[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private double getMinCoefAbs(double[] a)
        {
            double min = Math.Abs(a[0]);
            double current;
            for (int i=1; i<a.Length; i++)
            {
                current = Math.Abs(a[i]);
                if (current < min)
                {
                    min = current;
                }
            }
            return min;
        }

        private double getMaxCoefWithBounds(double[] a, int bound1, int bound2)
        {
            double max = Math.Abs(a[bound1]);
            double current;
            for (int i = (bound1+1); i < bound2; i++)
            {
                current = Math.Abs(a[i]);
                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }

        private double[] shortArrayInNumber(double[] a, double magicNumber, double intentOfShorting)
        {
            if (intentOfShorting > magicNumber)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = a[i] / intentOfShorting;
                    a[i] = Math.Round(a[i], 3);
                }
                displayArray(a, "Shorted coefficients");
            }
            return a;
        }

        private double[] methodLobachevskiyIteration(double[] a)
        {
            double[] b = new double[a.Length];
            double sum = 0;
            for (int k = 0; k < a.Length; k++)
            {
                sum = 0;
                for (int j = 1; j < a.Length - k; j++)
                {
                    if (k + j >= a.Length || k - j < 0)
                    {
                        continue;
                    }
                    sum += Math.Pow(-1, j) * a[k - j] * a[k + j];
                }
                b[k] = Math.Pow(a[k], 2) + 2 * sum;
                b[k] = Math.Round(b[k], 3);
            }
            return b;
        }

        private void displayTitle(string title)
        {
            ResultBox.SelectionColor = Color.Magenta;
            ResultBox.AppendText(title + "\r\n");
            ResultBox.SelectionColor = Color.Black;
        }

        private void displayArray(double[] a, string arrayOf)
        {
            ResultBox.SelectionColor = Color.Blue;
            ResultBox.AppendText(arrayOf + " :\r\n");
            ResultBox.SelectionColor = Color.Black;
            ResultBox.AppendText("[ ");
            for (int i= a.Length-1; i>=0; i--)
            {
                ResultBox.SelectionColor = Color.BlueViolet;
                ResultBox.AppendText(a[i].ToString());
                ResultBox.SelectionColor = Color.Black;
                if (i != 0)
                {
                    ResultBox.AppendText("; ");
                }
            }
            ResultBox.AppendText(" ]\r\n");
        }

        private void displayBoundaries(double R, double r)
        {
            ResultBox.AppendText("Upper boundary (R) = " + R + "\r\nLower boundary (r) = " + r + "\r\n");
        }

        private string getPrintedArray(double[] a)
        {
            string result = "[ ";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i].ToString();
                if (i != 0)
                {
                    result += "; ";
                }
            }
            return result + " ]\r\n";
        }

        private double methodLobachevskiyCriterion(double[] a, double[] b)
        {
            double sum = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                sum += Math.Pow(1 - (b[i] / Math.Pow(a[i], 2)), 2);
            }
            return Math.Sqrt(sum);
        }

        private void buttonSet1_Click(object sender, EventArgs e)
        {
            tb7.Text = "0";
            tb6.Text = "0";
            tb5.Text = "0";
            tb4.Text = "1";
            tb3.Text = "3";
            tb2.Text = "-4";
            tb1.Text = "-5";
            tb0.Text = "2";
            textBoxE.Text = "0,0000001";
            textBoxCancel.Text = "10";
        }

        private void buttonSet2_Click(object sender, EventArgs e)
        {
            tb7.Text = "-46";
            tb6.Text = "-257";
            tb5.Text = "-146";
            tb4.Text = "831";
            tb3.Text = "819";
            tb2.Text = "-596";
            tb1.Text = "-568";
            tb0.Text = "78";
            textBoxE.Text = "0,00001";
            textBoxCancel.Text = "0";
        }
    }
}
