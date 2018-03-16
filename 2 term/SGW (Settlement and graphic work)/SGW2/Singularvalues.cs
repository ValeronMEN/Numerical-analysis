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
    public partial class Singularvalues : Form
    {
        public Singularvalues()
        {
            InitializeComponent();
        }

        private void Singularvalues_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = this.Owner as Main;
            main.Show();
        }
    }
}
