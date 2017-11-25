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
    public partial class Specification : Form
    {
        private String example16 = "(cosx)^3 + x^3 * (log2(sh(x) + ch(x)))^3 - x^3 = 5";
        private String example24 = "x^3 - (cos(x))^2 - 5x = 3";

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
                    textBoxMethod.Text = "Метод хорд";
                    break;
                case 1:
                    equation.Text = example16;
                    textBoxMethod.Text = "Метод простых итераций";
                    break;
                case 2:
                    equation.Text = example16;
                    textBoxMethod.Text = "Упрощенный метод Ньютона";
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            textBoxError.Text = "";
            ResultBox.Text = "Starting...";
            if (comboBoxNumberOfExample.SelectedIndex == -1)
            {
                textBoxError.Text = "Метод и пример не заданы";
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
                textBoxError.Text = "Ошибка в значениях a, b или E";
                return;
            }
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double e = Convert.ToDouble(textBoxE.Text);
            switch (comboBoxNumberOfExample.SelectedIndex)
            {
                case 0:
                    double result = methodOfChords(a, b, e);
                    ResultBox.Text += "Result: " + result.ToString();
                    MessageBox.Show("Success!\r\nResult: " + result.ToString());
                    return;
                case 1:
                    //equation.Text = example16;
                    //textBoxMethod.Text = "Метод простых итераций";
                    break;
                case 2:
                    //equation.Text = example16;
                    //textBoxMethod.Text = "Упрощенный метод Ньютона";
                    break;
                default:
                    return;
            }
            MessageBox.Show("Success!");
        }

        private double example24Function(double x) {
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

        private double methodOfChords(double a, double b, double e)
        {
            int n = 1;
            while (true)
            {
                if (example24Function(a) * example24FunctionDerivative2(a) < 0)
                {
                    double c = a;
                    a = b;
                    b = c;
                }
                double b_old = b;
                b = methodOfChordsIteration(a, b);
                ResultBox.Text += "b" + n.ToString() + " = " + b.ToString() + " (a = " + a.ToString() + ")\r\n";
                if (n > 20) {
                    return -1;
                }
                if (methodOfChordsCriterion(b_old, b, e))
                {
                    return b;
                }
                n++;
            }
        }

        private double methodOfChordsIteration(double a, double bn)
        {
            return bn - ((a - bn) * example24Function(bn)) / (example24Function(a) - example24Function(bn));
        }

        private bool methodOfChordsCriterion(double b1, double b2, double e)
        {
            double c = Math.Abs(example24FunctionDerivative1(b1));
            ResultBox.Text += "Criterion: |f(b(n+1))| = " + Math.Abs(example24Function(b2)) + "; alpha * epsilon = " + c * e + "\r\n";
            return Math.Abs(example24Function(b2)) < c * e;
        }

        private double example16Function(double x)
        {
            return Math.Pow(Math.Cos(x), 3) + Math.Pow(x, 3) * Math.Pow(Math.Log((Math.Sinh(x) + Math.Cosh(x)), 2), 3) - Math.Pow(x, 3) - 5;
        }
    }
}
