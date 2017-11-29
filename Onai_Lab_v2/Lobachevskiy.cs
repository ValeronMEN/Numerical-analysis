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
            ResultBox.AppendText("Extent of equation is " + n.ToString() + "\r\n");
            if (!checkSimularNumbersInArray(a, n))
            {
                textBoxError.Text = "Некоторые коэфициенты одинаковые!";
                ResultBox.Text += "Error: " + textBoxError.Text + "\r\n";
                return;
            }
            displayArray(a, n);
            double criterion;
            int numberOfIteration = 0;
            while (true)
            {
                double[] b = methodLobachevskiyIteration(a, n);
                displayArray(b, n);
                criterion = methodLobachevskiyCriterion(a, b, n);
                ResultBox.AppendText("Criterion: " + criterion + "; epsilon = " + eps + "\r\n");
                numberOfIteration++;
                if (criterion < eps)
                {
                    /*
                    double[] x = new double[n];
                    for (int i=0; i<=n; i++)
                    {
                        x[i] = Math.Pow(((b[n+i-2])/(b[n+i-1])), 1/(Math.Pow(2, numberOfIteration)));
                        ResultBox.AppendText("Roots:\r\n");
                        displayArray(x, n);
                    }
                    */
                    return;
                }
                if (numberOfIteration > 20)
                {
                    return;
                }
                a = b;
            }
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
                for (int j=1; j <= n-k; j++)
                {
                    if (k+j > n || k-j < 0)
                    {
                        continue; // 
                    }
                    sum += Math.Pow(-1, j) * a[k - j] * a[k + j];
                }
                //ResultBox.AppendText(k + " - k + " + sum + " - sum\r\n");
                b[k] = Math.Pow(a[k], 2) + 2 * sum;
            }
            return b;
        }

        private void displayArray(double[] a, int n)
        {
            ResultBox.AppendText("Coefficients are:\r\n");
            string coefs = "";
            for (int i=n; i>=0; i--)
            {
                coefs += a[i] + " ";
            }
            ResultBox.AppendText(coefs + "\r\n");
        }

        private double methodLobachevskiyCriterion(double[] a, double[] b, int n)
        {
            double sum = 0;
            for (int i = n; i >= 0; i--)
            {
                //ResultBox.AppendText((b[i] / a[i]).ToString());
                sum += Math.Pow(1 - (b[i] / Math.Pow(a[i], 2)), 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
