using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosRestaurante
{
    public partial class frmEmpleados : Form
    {
        Mesero objMesero;
        Cajero objCajero;
        Repartidor objRepartidor;
        public frmEmpleados()
        {
            InitializeComponent();
            cmbDiasTeMe.Items.Add("1");
            cmbDiasTeMe.Items.Add("2");
            cmbDiasTeMe.Items.Add("3");
            cmbDiasTeMe.Items.Add("4");
            cmbDiasTeMe.Items.Add("5");
            cmbDiasTeMe.Items.Add("6");
            cmbDiasTeMe.Items.Add("7");

            cmbDiasTraCa.Items.Add("1");
            cmbDiasTraCa.Items.Add("2");
            cmbDiasTraCa.Items.Add("3");
            cmbDiasTraCa.Items.Add("4");
            cmbDiasTraCa.Items.Add("5");
            cmbDiasTraCa.Items.Add("6");
            cmbDiasTraCa.Items.Add("7");
            
            cmbDiasTraRe.Items.Add("1");
            cmbDiasTraRe.Items.Add("2");
            cmbDiasTraRe.Items.Add("3");
            cmbDiasTraRe.Items.Add("4");
            cmbDiasTraRe.Items.Add("5");
            cmbDiasTraRe.Items.Add("6");
            cmbDiasTraRe.Items.Add("7");

            cmbCaja.Items.Add("1");
            cmbCaja.Items.Add("2");

            cmbZona.Items.Add("1");
            cmbZona.Items.Add("2");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcularSalarioMe_Click(object sender, EventArgs e)
        {
            Mesero objMesero = new Mesero();
            if (txtNomMe.Text == "")
            {
                errorProvider1.SetError(txtNomMe, "falta llenar esta casilla");
                txtNomMe.Focus();
                return;
            }
            errorProvider1.SetError(txtNomMe, "");

            if (dtpFechaDeNacimientoMe.Text == "")
            {
                errorProvider1.SetError(dtpFechaDeNacimientoMe, "falta llenar esta casilla");
                dtpFechaDeNacimientoMe.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaDeNacimientoMe, "");

            if (txtCalSalarioMe.Text == "")
            {
                errorProvider1.SetError(txtCalSalarioMe, "falta llenar esta casilla");
                txtCalSalarioMe.Focus();
                return;
            }
            errorProvider1.SetError(txtCalSalarioMe, "");

            if (cmbDiasTeMe.Text == "")
            {
                errorProvider1.SetError(cmbDiasTeMe, "falta llenar esta casilla");
                cmbDiasTeMe.Focus();
                return;
            }
            errorProvider1.SetError(cmbDiasTeMe, "");

            if (txtCalPropMe.Text == "")
            {
                errorProvider1.SetError(txtCalPropMe, "falta llenar esta casilla");
                txtCalPropMe.Focus();
                return;
            }
            errorProvider1.SetError(txtCalPropMe, "");

            objMesero.Nombre = txtNomMe.Text;
            objMesero.FechadeNacimientos = dtpFechaDeNacimientoMe.Text;
            objMesero.Sueldo = Convert.ToDouble(txtCalSalarioMe.Text);
            objMesero.DiasTrabajados = int.Parse(cmbDiasTeMe.Text);
            objMesero.PropinaSemanal = Convert.ToDouble (txtCalPropMe.Text);
            objMesero.CalcularSueldo();
            MessageBox.Show("El sueldo de "+objMesero.Nombre+ " es de $"+ objMesero.SueldoSemanal,"Sueldo semanal",MessageBoxButtons.OK,MessageBoxIcon.Information );

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCalCa_Click(object sender, EventArgs e)
        {        
            Cajero objCajero = new Cajero();

            if (txtNomCa.Text == "")
            {
                errorProvider1.SetError(txtNomCa, "falta llenar esta casilla");
                txtNomCa.Focus();
                return;
            }
            errorProvider1.SetError(txtNomCa, "");

            if (dtpFechaDeNacimientoCa.Text == "")
            {
                errorProvider1.SetError(dtpFechaDeNacimientoCa, "falta llenar esta casilla");
                dtpFechaDeNacimientoMe.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaDeNacimientoCa, "");

            if (txtCalSueldoCa.Text == "")
            {
                errorProvider1.SetError(txtCalSueldoCa, "falta llenar esta casilla");
                txtCalSueldoCa.Focus();
                return;
            }
            errorProvider1.SetError(txtCalSueldoCa, "");

            if (cmbDiasTraCa.Text == "")
            {
                errorProvider1.SetError(cmbDiasTraCa, "falta llenar esta casilla");
                cmbDiasTraCa.Focus();
                return;
            }
            errorProvider1.SetError(cmbDiasTraCa, "");

            if (cmbCaja.Text == "")
            {
                errorProvider1.SetError(cmbCaja, "falta llenar esta casilla");
                cmbCaja.Focus();
                return;
            }
            errorProvider1.SetError(cmbCaja, "");

            objCajero.Nombre = txtNomCa.Text;
            objMesero.FechadeNacimientos = dtpFechaDeNacimientoCa.Text;
            objCajero.Sueldo = Convert.ToDouble(txtCalSueldoCa.Text);
            objCajero.DiasTrabajados = int.Parse(cmbDiasTraCa.Text);
            objCajero.NumCaja = int.Parse(cmbCaja.Text);
            objCajero.CalcularSueldo();
            MessageBox.Show("El sueldo de "+objCajero.Nombre+" es de $"+objCajero.SueldoSemanal,"Sueldo semanal",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalcularRe_Click(object sender, EventArgs e)
        {
            Repartidor objRepartidor = new Repartidor();

            if (txtNomRe.Text == "")
            {
                errorProvider1.SetError(txtNomRe, "falta llenar esta casilla");
                txtNomRe.Focus();
                return;
            }
            errorProvider1.SetError(txtNomRe, "");

            if (dtpFechaDeNacimientoRe.Text == "")
            {
                errorProvider1.SetError(dtpFechaDeNacimientoRe, "falta llenar esta casilla");
                dtpFechaDeNacimientoRe.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaDeNacimientoRe, "");

            if (txtCalSueldoRe.Text == "")
            {
                errorProvider1.SetError(txtCalSueldoRe, "falta llenar esta casilla");
                txtCalSueldoRe.Focus();
                return;
            }
            errorProvider1.SetError(txtCalSueldoRe, "");

            if (cmbDiasTraRe.Text == "")
            {
                errorProvider1.SetError(cmbDiasTraRe, "falta llenar esta casilla");
                cmbDiasTraRe.Focus();
                return;
            }
            errorProvider1.SetError(cmbDiasTraRe, "");

            

            objRepartidor.Nombre = txtNomRe.Text;
            objRepartidor.FechadeNacimientos = dtpFechaDeNacimientoRe.Text;
            objRepartidor.Sueldo = Convert.ToDouble(txtCalSueldoRe.Text);
            objRepartidor.DiasTrabajados = int.Parse(cmbDiasTraRe.Text);
            objRepartidor.ZonaDeReparto = int.Parse(cmbZona.Text);
            objRepartidor.PedidosRealizados = int.Parse(txtPedidosRealizados.Text);
            objRepartidor.CalcularSueldo();
            MessageBox.Show("El sueldo de "+objRepartidor.Nombre+" es de $"+ objRepartidor.SueldoSemanal,"Sueldo semanal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gpxCajero_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
