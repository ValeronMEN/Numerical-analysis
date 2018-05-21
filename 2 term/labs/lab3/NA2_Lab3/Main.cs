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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonTrap_Click(object sender, EventArgs e)
        {
            Trap ev = new NA2_Lab3.Trap();
            ev.Owner = this;
            ev.Show();
            this.Hide();
        }

        private void buttonRecTrap_Click(object sender, EventArgs e)
        {
            RecTrap ev = new NA2_Lab3.RecTrap();
            ev.Owner = this;
            ev.Show();
            this.Hide();
        }
    }
}
