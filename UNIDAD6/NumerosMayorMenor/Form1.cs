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

namespace NumerosMayorMenor
{
    public partial class frmNumeros : Form
    {
        numeros ObjNumero = new numeros();
        StreamWriter Numeros;
        public frmNumeros()
        {
            InitializeComponent();
            btnResultado.Enabled = false;
        }

        private void lblCantidadNumeros_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           if  (txtCantidadNumeros.Text=="")
            {
                errorProvider1.SetError(txtCantidadNumeros, "introduce la cantidad de numeros a introducir");
                txtCantidadNumeros.Focus();
                return;

            }
            errorProvider1.SetError(txtCantidadNumeros, "");

            ObjNumero.ArregloNumeros = new int[Convert.ToInt16( txtCantidadNumeros.Text)];
            for (int f = 0; f < ObjNumero.ArregloNumeros.Length; f++)
            {
                ObjNumero.ArregloNumeros[f] = Convert.ToInt32(Interaction.InputBox("Introduce el numero #" + (f + 1)));
            }
            btnResultado.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numeros = new StreamWriter("NumeroMayorMenor.txt");
            string almacenador="";
            MessageBox.Show(ObjNumero.CalcularMayorMenor(),"Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            almacenador += "El numero mayor es: "+ObjNumero.Mayor+"\n";
            almacenador += "El numero Menor es: " + ObjNumero.Menor;
            Numeros.Write(almacenador);
            Numeros.Close();
            btnAgregar.Enabled = true;
            txtCantidadNumeros.Clear();
        }

        private void frmNumeros_Load(object sender, EventArgs e)
        {

        }
    }
}
