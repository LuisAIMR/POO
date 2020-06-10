using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo
{
    public partial class Form1 : Form
    {
        ClassRecibo objRecibo = new ClassRecibo();
        public Form1()
        {
            InitializeComponent();
            cmbTipoContrato.Items.Add("Hogar");
            cmbTipoContrato.Items.Add("Negocio");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalCaPagar_Click(object sender, EventArgs e)
        {
            if (txtCaWatts.Text == "")
            {
                errorProvider1.SetError(txtCaWatts, "Introduce la cantidad de kilowatts");
                cmbTipoContrato.Focus();
                return;
            }
            errorProvider1.SetError(txtCaWatts, "");
            if (cmbTipoContrato.Text == "")
            {
                errorProvider1.SetError(cmbTipoContrato, "Introduce el tipo de contrato");
                cmbTipoContrato.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoContrato, "");

            objRecibo.tipoContrato = cmbTipoContrato.Text.ToString();
            objRecibo.CaWatts = int.Parse(txtCaWatts.Text.ToString());
            objRecibo.CaPagar();
            lblResultCaPagar.Text = "$" + objRecibo.CantidadPagar.ToString();
            lblResultTiContrato.Text = objRecibo.tipoContrato.ToString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
