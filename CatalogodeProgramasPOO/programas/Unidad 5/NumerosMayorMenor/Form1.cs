using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosMayorMenor
{
    public partial class frmNumeros : Form
    {
        numeros ObjNumero = new numeros();
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
            errorProvider1.SetError(txtCantidadNumeros, "introduce la cantidad de numeros a introducir");

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
            MessageBox.Show(ObjNumero.CalcularMayorMenor(),"Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnAgregar.Enabled = true;
            txtCantidadNumeros.Clear();
        }
    }
}
