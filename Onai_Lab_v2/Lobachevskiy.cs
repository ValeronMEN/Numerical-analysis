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
            }
            catch (FormatException exc)
            {
                textBoxError.Text = "Ошибка в значениях коэфициентов";
                ResultBox.Text += "Error: " + textBoxError.Text + "\r\n" + exc;
                return;
            }
            double [] a = new double[8];
            a[7] = Convert.ToDouble(tb7.Text);
            a[6] = Convert.ToDouble(tb6.Text);
            a[5] = Convert.ToDouble(tb5.Text);
            a[4] = Convert.ToDouble(tb4.Text);
            a[3] = Convert.ToDouble(tb3.Text);
            a[2] = Convert.ToDouble(tb2.Text);
            a[1] = Convert.ToDouble(tb1.Text);
            a[0] = Convert.ToDouble(tb0.Text);
            if (a[7] != 1 || a[7] != 0) {
                //
            }
        }
    }
}
