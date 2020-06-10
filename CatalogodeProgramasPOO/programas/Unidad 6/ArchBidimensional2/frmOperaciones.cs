using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchBidimensional2
{
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }
        int[,] arrayA = new int[100, 100];
        int[,] arrayB = new int[100, 100];
        int[,] arrayC = new int[100, 100];
        int fil;
        int col;
        int i, j;
        string acumA;
        string acumB;
        string acumC;

        StreamWriter Operacion;
        private void btnTamañoMatriz_Click(object sender, EventArgs e)
        {
            fil = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Cuantas filas tiene la matriz?"));
            col = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Cuantas columnas?"));
        }

        private void btnIngresarDatosA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz A", "Ingresar datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            for (i = 0; i < fil; i++)
            {
                acumA += "\r\n";
                for (j = 0; j < col; j++)
                {
                    arrayA[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz A  " + i + "," + j));
                    acumA += arrayA[i, j] + "\n";
                    txtA.Text = acumA;
                }
            }
        }

        private void btnIngresarDatosB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz B", "Ingresar datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            for (i = 0; i < fil; i++)
            {
                acumB += "\r\n";
                for (j = 0; j < col; j++)
                {
                    arrayB[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz B " + i + "," + j));
                    acumB += arrayB[i, j] + "\n";
                    txtB.Text = acumB;
                }
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            acumC = "";
            Operacion = new StreamWriter("ResultadoSuma.txt");
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                    acumC += arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }
            }
            Operacion.Write(acumC);
            Operacion.Close();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            acumC = "";
            Operacion = new StreamWriter("ResultadoMultiplicacion.txt");
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] * arrayB[i, j];
                    acumC += arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }
            }
            Operacion.Write(acumC);
            Operacion.Close();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            acumC = "";
            Operacion = new StreamWriter("ResultadoResta.txt");
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
                    acumC += arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }
            }
            Operacion.Write(acumC);
            Operacion.Close();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            acumC = "";
            Operacion = new StreamWriter("ResultadoDivision.txt");
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] / arrayB[i, j];
                    acumC += arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }
            }
            Operacion.Write(acumC);
            Operacion.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 uno = new Form1();
            uno.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        public void LimpiarControles()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            acumA = "";
            acumB = "";
            acumC = "";
        }
    }
}
