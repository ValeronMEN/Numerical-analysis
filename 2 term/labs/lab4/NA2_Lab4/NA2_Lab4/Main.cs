using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NA2_Lab4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonMiddlePoint_Click(object sender, EventArgs e)
        {
            MidpointMethod ev = new NA2_Lab4.MidpointMethod();
            ev.Owner = this;
            ev.Show();
            this.Hide();
        }

        private void buttonKM_Click(object sender, EventArgs e)
        {
            KuttaMersonMethod ev = new NA2_Lab4.KuttaMersonMethod();
            ev.Owner = this;
            ev.Show();
            this.Hide();
        }
    }
}
