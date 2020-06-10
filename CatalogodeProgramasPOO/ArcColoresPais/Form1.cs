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

namespace ArcColoresPais
{
    public partial class Form1 : Form
    {
        Pais ObjPais = new Pais();

        StreamWriter DocPais;
        public Form1()
        {
            InitializeComponent();
            btnImprimir.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //secccion para verficar que todos los datos del programa son datos validos
            if (txtNombrePais.Text == "")
            {
                errorProvider1.SetError(txtNombrePais, "Introduce el nombre del pais");
                txtNombrePais.Focus();
                return;
            }
            errorProvider1.SetError(txtNombrePais, "");

            //Verificar si los datos introducidos de poblacion son numericos y positivos
            decimal verificar;
            if (!Decimal.TryParse(txtTotalPoblacion.Text, out verificar))
            {
                errorProvider1.SetError(txtTotalPoblacion, "Debe introducir datos numericos");
                txtTotalPoblacion.Focus();
                return;
            }
            errorProvider1.SetError(txtTotalPoblacion, "");

            if (verificar <= 0)
            {
                errorProvider1.SetError(txtTotalPoblacion, "Introduzca datos validos (numeros positivos)");
                txtTotalPoblacion.Focus();
                return;
            }
            errorProvider1.SetError(txtTotalPoblacion, "");

            //secccion para verficar que todos los datos del programa son datos validos
            if (txtIdiomaPredominante.Text == "")
            {
                errorProvider1.SetError(txtIdiomaPredominante, "Introduce el idioma predominante del pais");
                txtIdiomaPredominante.Focus();
                return;
            }
            errorProvider1.SetError(txtIdiomaPredominante, "");

            if (txtColor1.Text == "")
            {
                errorProvider1.SetError(txtColor1, "Introduce el primer color del pais");
                txtColor1.Focus();
                return;
            }
            errorProvider1.SetError(txtColor1, "");

            if (txtColor2.Text == "")
            {
                errorProvider1.SetError(txtColor2, "Introduce el segundo color del pais, sino cuenta con uno coloca (Sin color)");
                txtColor2.Focus();
                return;
            }
            errorProvider1.SetError(txtColor2, "");

            if (txtColor3.Text == "")
            {
                errorProvider1.SetError(txtColor3, "Introduce el tercer color del pais, sino cuenta con uno coloca (Sin color)");
                txtColor3.Focus();
                return;
            }
            errorProvider1.SetError(txtColor3, "");

            ObjPais.NombrePais = txtNombrePais.Text;
            ObjPais.TotalPoblacion = Convert.ToInt32(txtTotalPoblacion.Text);
            ObjPais.IdiomaPredominante = txtIdiomaPredominante.Text;
            //introducir el tamaño del arreglo
            ObjPais.ColoresBandera = new string[3];
            //definir en que indice del arreglo va a recibir cada dato
            ObjPais.ColoresBandera[0] = txtColor1.Text.ToString();
            ObjPais.ColoresBandera[1] = txtColor2.Text.ToString();
            ObjPais.ColoresBandera[2] = txtColor3.Text.ToString();
            //mensaje para mostrar que los datos se han guardado
            MessageBox.Show("Datos guardados", "Se guardaron los datos con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limpiar los controles para posteriormente de usarlos
            txtNombrePais.Clear();
            txtTotalPoblacion.Clear();
            txtIdiomaPredominante.Clear();
            txtColor1.Clear();
            txtColor2.Clear();
            txtColor3.Clear();
            btnImprimir.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string Dato = "";
            DocPais = new StreamWriter("DocumentoPais.txt");
            //Enviar los datos a la zona donde de van a imprimir
            Dato += "Nombre del pais: ";
            lblResNombrePais.Text = ObjPais.NombrePais;
            Dato += ObjPais.NombrePais + "\n";
            Dato += "Total de la poblacion del pais: ";
            lblResTotaPoblacion.Text = ObjPais.TotalPoblacion.ToString();
            Dato += ObjPais.TotalPoblacion.ToString() + "\n";
            Dato += "Idioma predominante del pais: ";
            lblResIdiomaPredominante.Text = ObjPais.IdiomaPredominante;
            Dato += ObjPais.IdiomaPredominante + "\n";
            Dato += "Los 3 colores principales de la bandera del pais" + "\n";
            Dato += "Primer color: ";
            lblResColor1.Text = ObjPais.ColoresBandera[0];
            Dato += ObjPais.ColoresBandera[0] + "\n";
            Dato += "Segundo color: ";
            lblResColor2.Text = ObjPais.ColoresBandera[1];
            Dato += ObjPais.ColoresBandera[1] + "\n";
            Dato += "Tercer color: ";
            lblResColor3.Text = ObjPais.ColoresBandera[2];
            Dato += ObjPais.ColoresBandera[2] + "\n";

            DocPais.Write(Dato);
            DocPais.Close();
        }
    }
}
