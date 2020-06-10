using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraClase
{
    public partial class Form1 : Form
    {
        ArrayList Personas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona Persona1 = new Persona();
            Persona1.ID = "1010";
            Persona1.Nombres = "Marcelo";
            Persona1.Apellidos = "Guzman";
            Persona1.Correo = "MarceloKiller@gmail.com";
            Persona1.FechaNacimiento = new DateTime(1990, 5, 23);
            Persona1.Salario = 4567887654;
            Personas.Add(Persona1);

            Persona Persona2 = new Persona();
            Persona2.ID = "2020";
            Persona2.Nombres = "Rodrigo";
            Persona2.Apellidos = "Uzumaki";
            Persona2.Correo = "UzumaRod32@gmail.com";
            Persona2.FechaNacimiento = new DateTime(1984, 6, 15);
            Persona2.Salario = 34343443221;
            Personas.Add(Persona2);

            dgvDatos.DataSource = Personas;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Debe colocar un ID del empleado");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

            if (Existe(txtID.Text))
            {
                errorProvider1.SetError(txtID, "El ID del empleado ya ha sido registrado");
                txtID.Focus();
                return;
            }

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe colocar el nombre del empleado");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe colocar el apellido del empleado");
                txtApellidos.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidos, "");

            Regex reEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!reEmail.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe colocar una una direccion de correo valida");
                txtCorreo.Focus();
                return;
            }
            errorProvider1.SetError(txtCorreo, "");

            decimal salario;
            if (!Decimal.TryParse(txtSalario.Text, out salario))
            {
                errorProvider1.SetError(txtSalario, "Debe colocar el salario del empleado");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtSalario, "");

            if (salario < 0)
            {
                errorProvider1.SetError(txtSalario, "Debe colocar un numero positivo");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtSalario, "");

            Persona miPersona = new Persona();
            miPersona.ID = txtID.Text;
            miPersona.Nombres = txtNombre.Text;
            miPersona.Apellidos = txtApellidos.Text;
            miPersona.Correo = txtCorreo.Text;
            miPersona.FechaNacimiento = dtpFechaNacimiento.Value;
            miPersona.Salario = salario;

            Personas.Add(miPersona);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Personas;
            txtID.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            txtID.Focus();
        }
        private bool Existe(string ID)
        {
            foreach (Persona Persona in Personas)
            {
                if (Persona.ID == ID) return true;
            }
            return false;
        }
    }
}
