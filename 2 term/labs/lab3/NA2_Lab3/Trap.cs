using System;
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
    public partial class Trap : Form
    {
        public delegate double function(double x);

        public Trap()
        {
            InitializeComponent();
            setImageInPictureBoxFormula();
        }

        private void setImageInPictureBoxFormula()
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\DrLove\Documents\Visual Studio 2015\Projects\NA2_Lab3\NA2_Lab3\images\lab23_formula.JPG", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            pictureBoxFormula.Image = img;
        }

        private void Trap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = this.Owner as Main;
            main.Show();
        }

        // Function:
        // y = (sin(x)*cos(x))/(sqrt((cos(x))^2 - (sin(x))^2)) + 4*e^(x)*cos(x)
        private double runTheFunction(double x)
        {
            double sqrtValue = Math.Sqrt(Math.Cos(2 * x));
            if (Double.IsNaN(sqrtValue))
            {
                return 0;
            }
            return (Math.Sin(x)*Math.Cos(x)) / sqrtValue + 4 * Math.Exp(x) * Math.Cos(x);
        }

        private double runTheSecondDerivativeFunction(double x)
        {
            return Math.Sin(x) * Math.Cos(x) * (((3*Math.Pow(Math.Sin(2*x),2))/ (Math.Pow((Math.Cos(2 * x)), 2.5))) + ((2*Math.Cos(2*x))/(Math.Pow((Math.Cos(2*x)),1.5)))) - 8*Math.Exp(x)*Math.Sin(x);
        }

        // wolfram alpha check:
        // integrate ((sin(x)*cos(x))/(sqrt((cos(x))^2 - (sin(x))^2)) + 4*e^(x)*cos(x)) dx  from  x = 3 to 7
        private void compositeQuadratureFormulaOfTrapezium()
        {
            double n = getDoubleValueFromString(textBoxGapsSize.Text);
            textBoxResult.Text = "The gaps size: " + n + "\r\n";
            double a = 3;
            double b = 7;
            double h = (b - a) / n;
            double sigma = 3; // from a to b
            // textBoxResult.Text += "Test value: " + runTheFunction(4) + "\r\n";
            double result = getIntegral(h, a, b, n, runTheFunction, runTheSecondDerivativeFunction, sigma);
            textBoxResult.Text += "Result: " + result + "\r\n";
        }

        private double getIntegral(double hVar, double aVar, double bVar, double nVar, function f, function fDer2, double sigma)
        {
            double itValue = getIT(hVar, nVar, f, aVar);
            textBoxResult.Text += "I^T: " + itValue + "\r\n";
            double rtValue = getRT(hVar, aVar, bVar, fDer2, sigma);
            textBoxResult.Text += "Observational error (r^T): " + rtValue + "\r\n";
            return itValue + rtValue;
        }

        private double getIT(double hVar, double nVar, function f, double aVar)
        {
            double result = 0;
            for (int i = 0; i <= nVar; i++)
            {
                double yVar = f(aVar + i * hVar);
                if (i == 0 || i==nVar)
                {
                    result += (yVar / 2);
                }
                else
                {
                    result += yVar;
                }
            }
            return result * hVar;
        }

        private double getRT(double hVar, double aVar, double bVar, function fDer2, double sigma)
        {
            double fDer2Val = fDer2(sigma);
            return ((aVar - bVar) * Math.Pow(hVar, 2) * fDer2Val) / 12;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            compositeQuadratureFormulaOfTrapezium();
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
                return (integer + fraction - 0.1) *minus;
            }
            return (integer + fraction) * minus;
        }
    }
}
