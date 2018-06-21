using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NA2_Lab4
{
    class Module
    {
        public static double getDoubleValueFromString(string tb, TextBox tbr)
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
                tbr.Text += "Error with parts[0]: \r\n" + exc;
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
                tbr.Text += "Error with parts[1]: \r\n" + exc;
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

        public static void setImageInPictureBoxFormula(PictureBox pb)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\DrLove\Documents\Visual Studio 2015\Projects\NA2_Lab4\NA2_Lab4\24_1.JPG", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            pb.Image = img;
        }

        public static double runTheFunction(double x, double y)
        {
            return y - ((2 * x) / y);
        }
    }
}
