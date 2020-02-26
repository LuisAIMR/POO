using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculo
{
    public partial class frmVehiculo : Form
    {
        ClassVehiculo objVehiculo = new ClassVehiculo();
        public frmVehiculo()
        {
            InitializeComponent();
            cmbTipoVehiculo.Items.Add("Motociclista");
            cmbTipoVehiculo.Items.Add("Automóvil");
            cmbTipoVehiculo.Items.Add("Autobús");
            cmbTipoVehiculo.Items.Add("Tráiler");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCantidadAcobrar.Text = "";
            cmbTipoVehiculo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (cmbTipoVehiculo.Text == "") 
            {
                error1.SetError(cmbTipoVehiculo, "Debe colocar el tipo de vehiculo");
                cmbTipoVehiculo.Focus();
                return;
            }
            error1.SetError(cmbTipoVehiculo, "");

            objVehiculo.tipo = (cmbTipoVehiculo.Text.ToString());
            objVehiculo.cantidadCobro();
            lblCantidadAcobrar.Text = "$" + objVehiculo.cantidadCO.ToString();
            
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
