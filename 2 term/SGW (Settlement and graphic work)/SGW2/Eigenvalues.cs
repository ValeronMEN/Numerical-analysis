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
    public partial class Eigenvalues : Form
    {
        public Eigenvalues()
        {
            InitializeComponent();

            int[,] aMatrix = new int[,] { 
                { -289, -29, 679, -416, 534 }, 
                { -166, -947, 627, 327, -705 }, 
                { 710, -107, -622, 186, -752 },
                { 397, -133, 347, -569, -227 }, 
                { -595, -33, -404, 453, -436 }
            };

            int[,] bMatrix = new int[,] {
                { 966, 665, -281, 156, -155 },
                { 665, 783, -237, 51, -211 },
                { -281, -237, 882, -582, -429 },
                { 156, 51, -582, 717, 100 },
                { -155, -211, -429, 100, 907 }
            };

            displayMatrix(aMatrix, matrixLabelA, 5);
            displayMatrix(bMatrix, matrixLabelB, 5);
        }

        private void displayMatrix(int [,] matrix, Label label, int size)
        {
            String display = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    display += matrix[i, j].ToString() + ", ";
                }
                display += "\n";
            }
            label.Text = display;
        }

        private void Eigenvalues_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = this.Owner as Main;
            main.Show();
        }
    }
}
