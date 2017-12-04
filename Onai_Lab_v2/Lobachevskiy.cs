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
            double eps = Convert.ToDouble(textBoxE.Text);
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
            a = new double[n+1];
            a = aNew;
            ResultBox.AppendText("Extent of equation is " + n.ToString() + "\r\n");
            displayArray(a, n, "Coefficients");
            a = shortArrayInNumber(a);
            methodLobachevskiy(eps, a, n);
        }

        private void methodLobachevskiy(double eps, double[] a, int n)
        {
            double criterion;
            int numberOfIteration = 0;
            while (true)
            {
                ResultBox.AppendText(numberOfIteration + " iteration...\r\n");
                double[] b = methodLobachevskiyIteration(a, n);
                displayArray(b, n, "Coefficients");
                if (checkOverflow(b))
                {
                    displayArray(calculateRoots(a, n, numberOfIteration), n, "Roots");
                    return;
                }
                numberOfIteration++;
                criterion = methodLobachevskiyCriterion(a, b, n);
                ResultBox.AppendText("Criterion: " + criterion + "; epsilon = " + eps + "\r\n");
                if (criterion < eps)
                {
                    displayArray(calculateRoots(b, n, numberOfIteration), n, "Roots");
                    return;
                }
                a = b;
            }
        }

        private double[] calculateRoots(double[] b, int n, int numberOfIteration)
        {
            double[] x = new double[n + 1];
            for (int i = 1; i <= n; i++)
            {
                x[i] = Math.Pow(((b[n - i]) / (b[n - i + 1])), 1 / (Math.Pow(2, numberOfIteration)));
                ResultBox.AppendText(i + ") root is " + x[i].ToString() + "\r\n");
            }
            return b;
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

        private double getMinCoef(double[] a)
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

        private double[] shortArrayInNumber(double[] a)
        {
            double magicNumber = 30;
            double minCoef = getMinCoef(a);
            if (minCoef > magicNumber)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = a[i] / minCoef;
                    a[i] = Math.Round(a[i], 3);
                }
                displayArray(a, a.Length-1, "Shorted coefficients");
            }
            return a;
        }

        private bool checkSimularNumbersInArray(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    if (a[i] == a[j] && a[i] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private double[] methodLobachevskiyIteration(double[] a, int n)
        {
            double[] b = new double[8];
            double sum = 0;
            for (int k = 0; k <= n; k++)
            {
                sum = 0;
                for (int j = 1; j <= n - k; j++)
                {
                    if (k + j > n || k - j < 0)
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

        private void displayArray(double[] a, int n, string arrayOf)
        {
            ResultBox.SelectionColor = Color.Blue;
            ResultBox.AppendText(arrayOf + " :\r\n");
            ResultBox.SelectionColor = Color.Black;
            ResultBox.AppendText("[ ");
            for (int i=n; i>=0; i--)
            {
                ResultBox.SelectionColor = Color.BlueViolet;
                ResultBox.AppendText(a[i].ToString());
                ResultBox.SelectionColor = Color.Black;
                if (i != 0)
                {
                    ResultBox.AppendText(", ");
                }
            }
            ResultBox.AppendText(" ]\r\n");
        }

        private double methodLobachevskiyCriterion(double[] a, double[] b, int n)
        {
            double sum = 0;
            for (int i = n; i >= 0; i--)
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
            textBoxE.Text = "0,001";
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
            textBoxE.Text = "0,001";
        }
    }
}
