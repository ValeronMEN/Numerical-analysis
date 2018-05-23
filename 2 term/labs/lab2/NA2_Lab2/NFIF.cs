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
    public partial class NFIF : Form
    {
        public NFIF()
        {
            InitializeComponent();
        }

        private void NFIF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = this.Owner as Main;
            main.Show();
        }

        private void comboBoxNumberOfExample_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNumberOfExample.SelectedIndex)
            {
                case 0:
                    textBoxInputYs.Text = "1;9;25;36";
                    textBoxInputXs.Text = "1;3;5;6";
                    textBoxInputTasks.Text = "2;4";
                    break;
                case 1:
                    textBoxInputYs.Text = "28.599;12.64;5.627;4.786;7.187;9.254;10.779;19.148;21.381;18.429;11.448;19.671;19.681;20.507;20.645;20.595;19.768;18.682;18.428;17.471;18.188;19.021;21.827;26.401;33.339;37.801;55.291;67.272;71.614;92.317;102.173;254.08;882.586;900.889;902.393";
                    textBoxInputXs.Text = "-14.989;-13.791;-13.021;-12.542;-12.002;-11.753;-11.595;-10.826;-10.603;-7.992;-6.047;-4.11;-4.106;-3.683;-3.391;-3.251;-2.668;-2.179;-2.063;-1.524;-0.07;0.327;1.472;2.379;2.939;3.163;3.716;3.964;4.04;4.338;4.454;5.451;6.756;6.777;6.779";
                    textBoxInputTasks.Text = "-11.915;-10.211;-10.159;-8.875;-5.828;-5.243;-4.305;-4.123;-3.361;-3.303;-2.755;-1.191;-0.052;3.226;3.661";
                    break;
                default:
                    break;
            }
        }

        private void buttonNFIF_Click(object sender, EventArgs e)
        {
            newtonFirstInterpolationFormula();
        }

        private void newtonFirstInterpolationFormula()
        {
            // fill the result text box with an emptiness
            textBoxResult.Text = "";

            string[] ysStr = textBoxInputYs.Text.Split(';');
            string[] xsStr = textBoxInputXs.Text.Split(';');
            string[] wantedXsStr = textBoxInputTasks.Text.Split(';');

            if (ysStr.Length != xsStr.Length)
            {
                textBoxResult.Text = "Error: Xs and Ys string lengths aren't the same!\r\n";
                return;
            }
            int size = ysStr.Length;

            double[,] mainArr = new double[size, size + 1];
            for (int i=0; i<size; i++)
            {
                mainArr[i, 0] = getDoubleValueFromString(xsStr[i]);
                mainArr[i, 1] = getDoubleValueFromString(ysStr[i]);
            }

            double[,] filledMainArr = fillMainArr(mainArr, size);
            printMainArr(filledMainArr, size);

            for (int i=0; i<wantedXsStr.Length; i++)
            {
                double x = getDoubleValueFromString(wantedXsStr[i]);
                double polinomial = getPolinomial(mainArr, size, x);
                textBoxResult.Text += "For x = " + x + " polinomial is " + polinomial + "\r\n";
            }
        }

        private double getPolinomial(double[,] mainArr, int size, double x)
        {
            double result = 0;
            for (int n = 0; n < size; n++)
            {
                result += getOneConjunction(mainArr, n, size, x);
            }
            return result;
        }

        private double getOneConjunction(double[,] mainArr, int n, int size, double x)
        {
            double rightPart = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    rightPart *= (x - mainArr[i-1,0]);
                }
            }
            return mainArr[n, 1+n] * rightPart;
        }

        // This function fills array with the difference ratios:
        // f(x0, x1) = (f(x1) - f(x0))/(x1 - x0)
        // f(x1, x2) = (f(x2) - f(x1))/(x2 - x1)
        // f(x0,x1,x2) = (f(x1,x2) - f(x0,x1))/(x2 - x0)
        private double[,] fillMainArr(double[,] mainArr, int size)
        {
            for (int diff=2; diff<=size; diff++)
            {
                for (int i=(diff-1); i<size; i++)
                {
                    mainArr[i, diff] = (mainArr[i, diff - 1] - mainArr[i-1, diff - 1])/(mainArr[i,0]-mainArr[i-(diff-1), 0]);
                }
            }
            return mainArr;
        }

        private void printMainArr(double[,] mainArr, int size)
        {
            textBoxResult.Text += "Finite differences:\r\n";
            for (int j = 0; j < size + 1; j++)
            {
                if (j == 0)
                {
                    textBoxResult.Text += String.Format("{0,25}", "x");
                }
                else if (j == 1)
                {
                    textBoxResult.Text += String.Format("{0,25}", "y");
                }else
                {
                    textBoxResult.Text += String.Format("{0,35}", "d^"+j);
                }
            }
            textBoxResult.Text += "\r\n";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size + 1; j++)
                {
                    textBoxResult.Text += String.Format("{0,20}", mainArr[i, j]);
                }
                textBoxResult.Text += "\r\n";
            }
        }

        private double getDoubleValueFromString(string tb)
        {
            double minus = 1;
            if (tb[0] == '-')
            {
                minus *= -1;
                tb = tb.Split('-')[1];
            }
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
            bool isSplitted = false;
            if (parts[1][0] == '0')
            {
                parts[1] = "1" + parts[1].Remove(0, 1);
                isSplitted = true;
            }
            double fractionInt = Convert.ToDouble(parts[1]);
            double fraction = 0;
            while (fractionInt >= 1)
            {
                fractionInt = fraction = fractionInt / 10;
            }
            if (isSplitted)
            {
                return (integer + fraction - 0.1) * minus;
            }
            return (integer + fraction) * minus;
        }
    }
}
