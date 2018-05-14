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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonNSIF_Click(object sender, EventArgs e)
        {
            NSIF ev = new NA2_Lab2.NSIF();
            ev.Owner = this;
            ev.Show();
            this.Hide();
        }

        private void buttonNFIF_Click(object sender, EventArgs e)
        {
            NFIF ev = new NA2_Lab2.NFIF();
            ev.Owner = this;
            ev.Show();
            this.Hide();
        }
    }
}
