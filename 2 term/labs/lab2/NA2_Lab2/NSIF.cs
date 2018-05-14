using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NA2_Lab2
{
    public partial class NSIF : Form
    {
        public NSIF()
        {
            InitializeComponent();
        }

        private void newtonSecondInterpolationFormula()
        {
            // fill the result text box with an emptiness
            textBoxResult.Text = "";

            // take H and X0 values
            double hVar = getDoubleValueFromString(textBoxH.Text);
            double x0Var = getDoubleValueFromString(textBoxX0.Text);

            // Is it the function or input Y values?
            int size = 0;
            string[] ysStr = new string[1];
            if (textBoxFunction.Text == "Yes")
            {
                try
                {
                    Convert.ToInt32(textBoxSize.Text);
                }
                catch (FormatException exc)
                {
                    textBoxResult.Text += "Error with X's size: \r\n" + exc;
                    return;
                }
                size = Convert.ToInt32(textBoxSize.Text);
            }
            else
            {
                ysStr = textBoxInputNumbers.Text.Split(';');
                size = ysStr.Length;
                if (ysStr.Length == 1)
                {
                    textBoxResult.Text += "Type more than one number in 'y' input numbers!\r\n";
                    return;
                }
            }
            
            // create the big table of X, Y and finite differences
            double[,] mainArr = new double[size, size + 1];
            for (int i=0; i<size; i++)
            {
                // create an instance of X value from X0 and H
                mainArr[i, 0] = x0Var + hVar * i;
                if (textBoxFunction.Text == "Yes")
                {
                    mainArr[i, 1] = runTheFunction(mainArr[i, 0]);
                }
                else
                {
                    mainArr[i, 1] = getDoubleValueFromString(ysStr[i]);
                }
            }
            double[,] filledMainArr = fillMainArr(mainArr, size);
            printMainArr(filledMainArr, size);

            // get the task values from the text box
            string[] xsStr = textBoxInputTasks.Text.Split(';');

            // the last value in the table for XN
            double xnVar = filledMainArr[size - 1,0];

            // calculate the wanted Xs
            for (int i=0; i<xsStr.Length; i++)
            {
                double xVar = getDoubleValueFromString(xsStr[i]);
                double qVar = getQVar(xVar, xnVar, hVar);
                double polinomial = getPolinomial(qVar, filledMainArr, size);
                textBoxResult.Text += "For x = " + xVar + " polinomial is " + polinomial + "\r\n";
            }
        }

        private double getQVar(double x, double xn, double hVar)
        {
            return (x - xn) / hVar;
        }

        private double[,] fillMainArr(double[,] mainArr, int size)
        {
            for (int diff = 2; diff <= size; diff++)
            {
                for (int i = size - 2 - (diff-2); i >= 0; i--)
                {
                    mainArr[i, diff] = mainArr[i + 1, diff - 1] - mainArr[i, diff - 1];
                }
            }
            return mainArr;
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
            while(fractionInt >= 1)
            {
                fractionInt = fraction = fractionInt / 10;
            }
            return integer + fraction;
        }

        private void printMainArr(double[,] mainArr, int size)
        {
            textBoxResult.Text += "Finite differences:\r\n";
            for (int j = 0; j < size + 1; j++)
            {
                if (j == 0)
                {
                    textBoxResult.Text += "x  ";
                }
                else if(j == 1)
                {
                    textBoxResult.Text += "y ";
                }
                else
                {
                    textBoxResult.Text += "d"+(j-1)+"y ";
                }
            }
            textBoxResult.Text += "\r\n";
            for (int i=0; i<size; i++)
            {
                for (int j=0; j<size+1; j++)
                {
                    textBoxResult.Text += mainArr[i,j] + "  ";
                }
                textBoxResult.Text += "\r\n";
            }
        }
        
        private double getOneConjunction(double qVar, double[,] mainArr, int n, int size)
        {
            double qPart = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    qPart *= (qVar + (i - 1)) / i;
                }
            }
            return mainArr[(size-1)-n, 1 + n] * qPart;
        }

        private double getPolinomial(double qVar, double[,] mainArr, int size)
        {
            double result = 0;
            for (int n=0; n<size; n++)
            {
                result += getOneConjunction(qVar, mainArr, n, size);
            }
            return result;
        }

        private void buttonInterpolNewton_Click(object sender, EventArgs e)
        {
            newtonSecondInterpolationFormula();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNumberOfExample.SelectedIndex)
            {
                case 0:
                    textBoxX0.Text = "1";
                    textBoxH.Text = "1";
                    textBoxInputNumbers.Text = "1;4;9;16;25";
                    textBoxInputTasks.Text = "1.5;2.5";
                    break;
                case 1:
                    textBoxX0.Text = "1";
                    textBoxH.Text = "1.1";
                    textBoxInputNumbers.Text = "-13.021;-13.791;-14.989";
                    textBoxInputTasks.Text = "-13.111";
                    break;
                case 2:
                    textBoxX0.Text = "3";
                    textBoxH.Text = "0.3";
                    textBoxInputNumbers.Text = "";
                    textBoxInputNumbers.BackColor =SystemColors.InactiveBorder;
                    textBoxSize.BackColor = SystemColors.Window;
                    textBoxSize.Text = "10";
                    textBoxSize.ReadOnly = false;
                    textBoxFunction.Text = "Yes";
                    textBoxInputTasks.Text = "3.821;3.828;3.833;4.012;4.08;4.516;4.837;4.841;4.903;5.221;5.494;6.978;7.205";
                    break;
                default:
                    break;
            }
        }

        private Dictionary<double, string> getDistancesBetweenNumbers()
        {
            Dictionary<double, string> dict = new Dictionary<double, string>();
            double[] arr = new double[35] { -14.989, -13.791, -13.021, -12.542, -12.002, -11.753,
            -11.595, -10.826, -10.603, -7.992, -6.047, -4.11, -4.106, -3.683, -3.391, -3.251, -2.668,
            -2.179, -2.063, -1.524, -0.07, 0.327, 1.472, 2.379, 2.939, 3.163, 3.716, 3.964, 4.04,
            4.338, 4.454, 5.451, 6.756, 6.777, 6.779};
            for (int i=0; i<arr.Length; i++)
            {
                for (int j=i+1; j<(arr.Length-i); j++)
                {
                    double key = arr[j] - arr[i];
                    string value = i + "-" + j;
                    if (dict.ContainsKey(key)) {
                        string existed = dict[key];
                        dict.Remove(key);
                        value += "; " + existed;
                    }
                    dict.Add(key, value);
                }
            }
            foreach (KeyValuePair<double, string> kvp in dict)
            {
                textBoxResult.Text += "Key = " + kvp.Key + "; Value = " + kvp.Value;
            }
            return dict;
        }

        private double runTheFunction(double x)
        {
            return x * Math.Sin(x) + Math.Pow(x, 2) * Math.Exp(x) + Math.Log(Math.Pow(x, 3));
        }

        private void textBoxInputNumbers_TextChanged(object sender, EventArgs e)
        {
            textBoxSize.BackColor = SystemColors.InactiveBorder;
            textBoxSize.Text = "";
            textBoxSize.ReadOnly = true;
            textBoxInputNumbers.BackColor = SystemColors.Window;
            textBoxFunction.Text = "No";
        }

        private void NSIF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = this.Owner as Main;
            main.Show();
        }
    }
}
