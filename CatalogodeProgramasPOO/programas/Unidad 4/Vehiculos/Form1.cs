using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculos
{
    public partial class frmVehiculo : Form
    {
        Aereo objAereo = new Aereo();
        
        public frmVehiculo()
        {
            InitializeComponent();
            cmbIntTiVeAereo.Items.Add("Helicoptero");
            cmbIntTiVeAereo.Items.Add("Avioneta");
            cmbIntTiVeAereo.Items.Add("Avion Comercial");
            cmbIntTiVeAereo.Items.Add("Jet privado");
            cmbIntTiVeAereo.Items.Add("Avion Militar");
            cmbIntTiVeAereo.Items.Add("Globo Aeroestatico");
            cmbIntTiVeAereo.Items.Add("Dirigible");



        }

        private void btnEncenderMotor_Click(object sender, EventArgs e)
        {
            if (cmbIntTiVeAereo.Text == "")
            {
                error1.SetError(cmbIntTiVeAereo, "Coloque el tipo de Vehiculo Aereo");
                cmbIntTiVeAereo.Focus();
                return;
            }
            error1.SetError(cmbIntTiVeAereo, "");
            if (txtIntColor.Text=="")
            {
                error1.SetError(txtIntColor, "Coloque el color de vehiculo Aereo");
                txtIntColor.Focus();
                return;
            }
            error1.SetError(txtIntColor, "");

            if (txtIntNumAlas.Text == "")
            {
                error1.SetError(txtIntNumAlas, "Coloque el numero de alas de vehiculo Aereo");
                txtIntNumAlas.Focus();
                return;
            }
            error1.SetError(txtIntNumAlas, "");

            if (txtIntNumeroLlantas.Text == "")
            {
                error1.SetError(txtIntNumeroLlantas, "Coloque el numero de llantas de vehiculo Aereo");
                txtIntNumeroLlantas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroLlantas, "");

            if (txtIntNumeroPuertas.Text == "")
            {
                error1.SetError(txtIntNumeroPuertas, "Coloque el numero de puertas de vehiculo Aereo");
                txtIntNumeroPuertas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroPuertas, "");

            if (txtIntNumeroVentanas.Text == "")
            {
                error1.SetError(txtIntNumeroVentanas, "Coloque el numero de ventanas de vehiculo Aereo");
                txtIntNumeroVentanas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroVentanas, "");

            if (txtIntNumHelices.Text == "")
            {
                error1.SetError(txtIntNumHelices, "Coloque el numero de helices de vehiculo Aereo");
                txtIntNumHelices.Focus();
                return;
            }
            error1.SetError(txtIntNumHelices, "");

            if (txtIntNumTurbinas.Text == "")
            {
                error1.SetError(txtIntNumTurbinas, "Coloque el numero de turbinas de vehiculo Aereo");
                txtIntNumTurbinas.Focus();
                return;
            }
            error1.SetError(txtIntNumTurbinas, "");

            if (txtIntTipoCom.Text == "")
            {
                error1.SetError(txtIntTipoCom, "Coloque el tipo combustible de vehiculo Aereo");
                txtIntTipoCom.Focus();
                return;
            }
            error1.SetError(txtIntTipoCom, "");

           

            objAereo.tiAereo = cmbIntTiVeAereo.Text.ToString();
            objAereo.estado = "en Vuelo";
            objAereo.sonidoArrancar = " tucutucutuuuuuuu!!!!";
            MessageBox.Show(objAereo.arrancarMotor().ToString());
           
            objAereo.a = 1;
        }

        private void btnApagarMotor_Click(object sender, EventArgs e)
        {
            if (cmbIntTiVeAereo.Text == "")
            {
                error1.SetError(cmbIntTiVeAereo, "Coloque el tipo de Vehiculo Aereo");
                cmbIntTiVeAereo.Focus();
                return;
            }
            error1.SetError(cmbIntTiVeAereo, "");
            if (txtIntColor.Text == "")
            {
                error1.SetError(txtIntColor, "Coloque el color de vehiculo Aereo");
                txtIntColor.Focus();
                return;
            }
            error1.SetError(txtIntColor, "");

            if (txtIntNumAlas.Text == "")
            {
                error1.SetError(txtIntNumAlas, "Coloque el numero de alas de vehiculo Aereo");
                txtIntNumAlas.Focus();
                return;
            }
            error1.SetError(txtIntNumAlas, "");

            if (txtIntNumeroLlantas.Text == "")
            {
                error1.SetError(txtIntNumeroLlantas, "Coloque el numero de llantas de vehiculo Aereo");
                txtIntNumeroLlantas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroLlantas, "");

            if (txtIntNumeroPuertas.Text == "")
            {
                error1.SetError(txtIntNumeroPuertas, "Coloque el numero de puertas de vehiculo Aereo");
                txtIntNumeroPuertas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroPuertas, "");

            if (txtIntNumeroVentanas.Text == "")
            {
                error1.SetError(txtIntNumeroVentanas, "Coloque el numero de ventanas de vehiculo Aereo");
                txtIntNumeroVentanas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroVentanas, "");

            if (txtIntNumHelices.Text == "")
            {
                error1.SetError(txtIntNumHelices, "Coloque el numero de helices de vehiculo Aereo");
                txtIntNumHelices.Focus();
                return;
            }
            error1.SetError(txtIntNumHelices, "");

            if (txtIntNumTurbinas.Text == "")
            {
                error1.SetError(txtIntNumTurbinas, "Coloque el numero de turbinas de vehiculo Aereo");
                txtIntNumTurbinas.Focus();
                return;
            }
            error1.SetError(txtIntNumTurbinas, "");

            if (txtIntTipoCom.Text == "")
            {
                error1.SetError(txtIntTipoCom, "Coloque el tipo combustible de vehiculo Aereo");
                txtIntTipoCom.Focus();
                return;
            }
            error1.SetError(txtIntTipoCom, "");

            objAereo.tiAereo = cmbIntTiVeAereo.Text.ToString();
            objAereo.estado = "se cae";
            objAereo.sonidoParar = "(puuuuuf!!!)";
            MessageBox.Show(objAereo.pararMotor().ToString());
            objAereo.a = 2;
            
        }

        private void btnEstadoDeVehiculoAereo_Click(object sender, EventArgs e)
        {
            if (cmbIntTiVeAereo.Text == "")
            {
                error1.SetError(cmbIntTiVeAereo, "Coloque el tipo de Vehiculo Aereo");
                cmbIntTiVeAereo.Focus();
                return;
            }
            error1.SetError(cmbIntTiVeAereo, "");
            if (txtIntColor.Text == "")
            {
                error1.SetError(txtIntColor, "Coloque el color de vehiculo Aereo");
                txtIntColor.Focus();
                return;
            }
            error1.SetError(txtIntColor, "");

            if (txtIntNumAlas.Text == "")
            {
                error1.SetError(txtIntNumAlas, "Coloque el numero de alas de vehiculo Aereo");
                txtIntNumAlas.Focus();
                return;
            }
            error1.SetError(txtIntNumAlas, "");

            if (txtIntNumeroLlantas.Text == "")
            {
                error1.SetError(txtIntNumeroLlantas, "Coloque el numero de llantas de vehiculo Aereo");
                txtIntNumeroLlantas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroLlantas, "");

            if (txtIntNumeroPuertas.Text == "")
            {
                error1.SetError(txtIntNumeroPuertas, "Coloque el numero de puertas de vehiculo Aereo");
                txtIntNumeroPuertas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroPuertas, "");

            if (txtIntNumeroVentanas.Text == "")
            {
                error1.SetError(txtIntNumeroVentanas, "Coloque el numero de ventanas de vehiculo Aereo");
                txtIntNumeroVentanas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroVentanas, "");

            if (txtIntNumHelices.Text == "")
            {
                error1.SetError(txtIntNumHelices, "Coloque el numero de helices de vehiculo Aereo");
                txtIntNumHelices.Focus();
                return;
            }
            error1.SetError(txtIntNumHelices, "");

            if (txtIntNumTurbinas.Text == "")
            {
                error1.SetError(txtIntNumTurbinas, "Coloque el numero de turbinas de vehiculo Aereo");
                txtIntNumTurbinas.Focus();
                return;
            }
            error1.SetError(txtIntNumTurbinas, "");

            if (txtIntTipoCom.Text == "")
            {
                error1.SetError(txtIntTipoCom, "Coloque el tipo de combustible de vehiculo Aereo");
                txtIntTipoCom.Focus();
                return;
            }
            error1.SetError(txtIntTipoCom, "");
            if (objAereo.a==1)
            {
                MessageBox.Show("El "+objAereo.tiAereo +" esta en el aire");

            }
            else if (objAereo.a==2)
            {
                MessageBox.Show("El avion "+objAereo.tiAereo+ " esta callendo");
            }
              
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbIntTiVeAereo.Text == "")
            {
                error1.SetError(cmbIntTiVeAereo, "Coloque el tipo de Vehiculo Aereo");
                cmbIntTiVeAereo.Focus();
                return;
            }
            error1.SetError(cmbIntTiVeAereo, "");
            if (txtIntColor.Text == "")
            {
                error1.SetError(txtIntColor, "Coloque el color de vehiculo Aereo");
                txtIntColor.Focus();
                return;
            }
            error1.SetError(txtIntColor, "");

            if (txtIntNumAlas.Text == "")
            {
                error1.SetError(txtIntNumAlas, "Coloque el numero de alas de vehiculo Aereo");
                txtIntNumAlas.Focus();
                return;
            }
            error1.SetError(txtIntNumAlas, "");

            if (txtIntNumeroLlantas.Text == "")
            {
                error1.SetError(txtIntNumeroLlantas, "Coloque el numero de llantas de vehiculo Aereo");
                txtIntNumeroLlantas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroLlantas, "");

            if (txtIntNumeroPuertas.Text == "")
            {
                error1.SetError(txtIntNumeroPuertas, "Coloque el numero de puertas de vehiculo Aereo");
                txtIntNumeroPuertas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroPuertas, "");

            if (txtIntNumeroVentanas.Text == "")
            {
                error1.SetError(txtIntNumeroVentanas, "Coloque el numero de ventanas de vehiculo Aereo");
                txtIntNumeroVentanas.Focus();
                return;
            }
            error1.SetError(txtIntNumeroVentanas, "");

            if (txtIntNumHelices.Text == "")
            {
                error1.SetError(txtIntNumHelices, "Coloque el numero de helices de vehiculo Aereo");
                txtIntNumHelices.Focus();
                return;
            }
            error1.SetError(txtIntNumHelices, "");

            if (txtIntNumTurbinas.Text == "")
            {
                error1.SetError(txtIntNumTurbinas, "Coloque el numero de turbinas de vehiculo Aereo");
                txtIntNumTurbinas.Focus();
                return;
            }
            error1.SetError(txtIntNumTurbinas, "");

            if (txtIntTipoCom.Text == "")
            {
                error1.SetError(txtIntTipoCom, "Coloque el tipo de combustible de vehiculo Aereo");
                txtIntTipoCom.Focus();
                return;
            }
            error1.SetError(txtIntTipoCom, "");

            objAereo.tipoDeCombustible = txtIntTipoCom.Text.ToString();
            objAereo.color = txtIntColor.Text.ToString();
            objAereo.numeroLlantas =int.Parse( txtIntNumeroLlantas.Text.ToString());
            objAereo.numeroPuertas = int.Parse(txtIntNumeroPuertas.Text.ToString());
            objAereo.NumeroVentanas = int.Parse(txtIntNumeroVentanas.Text.ToString());
            objAereo.numAlas = int.Parse(txtIntNumAlas.Text.ToString());
            objAereo.numTurbina =int.Parse(txtIntNumTurbinas.Text.ToString());
            objAereo.numHelices = int.Parse(txtIntNumHelices.Text.ToString());
            objAereo.tiAereo = cmbIntTiVeAereo.Text.ToString();

            MessageBox.Show("La informacion de vehiculo "+objAereo.tiAereo+ " se guardo correctamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
