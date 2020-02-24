using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personas
{
    public partial class frmPersonas : Form
    {
        ClassPersonas objPersona = new ClassPersonas();
        public frmPersonas()
        {
            InitializeComponent();
            cmbEstado.Items.Add("Nayarit");
            cmbEstado.Items.Add("Estado de México");
            cmbEstado.Items.Add("Jalisco");
            cmbEstado.Items.Add("Michoacán");
            cmbEstado.Items.Add("Sonora");
            cmbEstado.Items.Add("Baja california");
            cmbEstado.Items.Add("Yucatán");
            cmbEstado.Items.Add("Nuevo León");
            cmbEstado.Items.Add("Chiapas");
            cmbEstado.Items.Add("Sinaloa");
            cmbEstado.Items.Add("Guanajuato");
            cmbEstado.Items.Add("Guerrero");
            cmbEstado.Items.Add("Tamaulipas");
            cmbEstado.Items.Add("Morelos");
            cmbEstado.Items.Add("Aguascalientes");
            cmbEstado.Items.Add("Baja California Sur");
            cmbEstado.Items.Add("Chihuahua");
            cmbEstado.Items.Add("Coahuila");
            cmbEstado.Items.Add("Colima");
            cmbEstado.Items.Add("Cuidad de Mexico");
            cmbEstado.Items.Add("Durango");
            cmbEstado.Items.Add("Hidalgo");
            cmbEstado.Items.Add("Oaxaca");
            cmbEstado.Items.Add("Puebla");
            cmbEstado.Items.Add("Querétaro");
            cmbEstado.Items.Add("San Luis Potosí");
            cmbEstado.Items.Add("Tabasco");
            cmbEstado.Items.Add("Tlaxcala");
            cmbEstado.Items.Add("Zacatecas");
            cmbEstado.Items.Add("Quintana Roo");
            cmbEstado.Items.Add("Campeche");
            cmbEstado.Items.Add("Veracruz");
            cmbTipo.Items.Add("Alumno");
            cmbTipo.Items.Add("Maestro");
            cmbTipo.Items.Add("Administrativo");
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpFechaNacimiento_VisibleChanged(object sender, EventArgs e)
        {
            //  DateTime fechaActual = DateTime.Today;
            //  int Edad = fechaActual.Year - dtpFechaNacimiento.Value.Year;
            //if (fechaActual < dtpFechaNacimiento.Value.AddYears(Edad)) Edad--;
            //objPersona.Edad =int.Parse (Edad.ToString());
            

            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text=="")
            {
                error1.SetError(txtNombre, "Introduce el nombre");
                txtNombre.Focus();
                    return;
            }
            error1.SetError(txtNombre, "");

            if (txtApPaterno.Text=="")
            {
                error1.SetError(txtApPaterno, "Introduce el apellido paterno");
                txtApPaterno.Focus();
                return;
            }
            error1.SetError(txtApPaterno, "");

            if (txtApMaterno.Text=="")
            {
                error1.SetError(txtApMaterno, "Introduce el apellido materno");
                txtApMaterno.Focus();
                return;
            }
            error1.SetError(txtApMaterno, "");

            if (cmbEstado.Text=="")
            {
                error1.SetError(cmbEstado, "Selecciona el estado de procedencia");
                cmbEstado.Focus();
                return;
            }
            error1.SetError(cmbEstado, "");

            if (cmbTipo.Text=="")
            {
                error1.SetError(cmbTipo, "Selecciona el tipo de persona");
                cmbTipo.Focus();
                return;
            }
            error1.SetError(cmbTipo, "");

            if (txtTelefono.Text=="")
            {
                error1.SetError(txtTelefono, "Debe introducir un numero de telefono");
                txtTelefono.Focus();
                return;
            }
            error1.SetError(txtTelefono, "");

            objPersona.anioAc = int.Parse(DateTime.Today.Year.ToString());
            objPersona.mesAc = int.Parse(DateTime.Today.Month.ToString());
            objPersona.diaAc = int.Parse(DateTime.Today.Day.ToString());
            objPersona.anioNac = int.Parse(dtpFechaNacimiento.Value.Year.ToString());
            objPersona.mesNac = int.Parse(dtpFechaNacimiento.Value.Month.ToString());
            objPersona.diaNac = int.Parse(dtpFechaNacimiento.Value.Day.ToString());
            objPersona.MayorEdad();

            objPersona.Estado = (cmbEstado.Text);
            objPersona.CantidadNayarit();
            objPersona.Tipo = (cmbTipo.Text.ToString());
            objPersona.CantidadTipo();
            MessageBox.Show("Los datos se capturaron con exito");
            cmbEstado.Text = "";
            cmbTipo.Text = "";
            txtApMaterno.Text = "";
            txtApPaterno.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            

        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            frmInforme informe = new frmInforme();
            informe.lblCantidadPersonas.Text = ("Se han registrado ("+objPersona.CantidadTotal+") personas").ToString();
            informe.lblCantidadMayorEdad.Text = objPersona.mayorEdad.ToString();
            informe.lblCaNayarit.Text = objPersona.caNayarit.ToString();
            informe.lblCantidadAlumnos.Text = objPersona.Alumno.ToString();
            informe.lblCantidadMaestros.Text = objPersona.Maestro.ToString();
            informe.lblCantidadAdmnistrativos.Text = objPersona.Administrativo.ToString();
            informe.Show();
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalirPersonas_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
