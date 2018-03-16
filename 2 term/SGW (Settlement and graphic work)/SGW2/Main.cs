using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGW2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            label1.Text = "Welcome to Onai settlement and graphic work 9001";
        }

        private void eigenvaluesButton_Click(object sender, EventArgs e)
        {
            Eigenvalues ev = new SGW2.Eigenvalues();
            ev.Owner = this;
            ev.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Singularvalues ev = new SGW2.Singularvalues();
            ev.Owner = this;
            ev.Show();
            this.Hide();
        }
    }
}
