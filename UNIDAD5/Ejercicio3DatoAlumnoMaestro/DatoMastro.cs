using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3DatoAlumnoMaestro
{
    public partial class frmDatoMaestro : Form
    {
        Maestro ObjMaestro = new Maestro();
        int cargado;
        public frmDatoMaestro()
        {
            InitializeComponent();
        }

        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            //Validación de caja de texto nombre
            Regex reNombre = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un dato valido, ingrese solo letras");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            //Validación de la caja de texto curp
            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);

            if (!reCurp.IsMatch(txtCurp.Text))
            {
                errorProvider1.SetError(txtCurp, "Ingrese una curp válida");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");

            //Validación de la caja de texto teléfono
            decimal telefono;

            if (!Decimal.TryParse(txtTelefono.Text, out telefono))
            {
                errorProvider1.SetError(txtTelefono, "introduzca numeros");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            //Validación del correo 
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Ingrese una dirección de correo válida");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");


            //expresion regular para validar que se introduzcan numeros en el campo
            Regex reNumMaestro = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumMaestro.IsMatch(txtNumMaestro.Text))
            {
                errorProvider1.SetError(txtNumMaestro, "Ingrese el numero del maestro");
                txtNumMaestro.Focus();
                return;
            }
            errorProvider1.SetError(txtNumMaestro, "");

            
            decimal Salario;

            //Validación de la cada de texto Sueldo
            if (!Decimal.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "Ingrese datos validos, ingrese numeros");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtSalario, "");

            if (Salario < 0)
            {
                errorProvider1.SetError(txtSalario, "Ingrese numeros positivos");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtSalario, "");           
            if (cargado == 0)
            {
                ObjMaestro.Nombre = txtNombre.Text;
                ObjMaestro.FechaNacimiento = dtpFechaNacimiento.Value;
                ObjMaestro.Curp = txtCurp.Text;
                ObjMaestro.Telfono = Convert.ToInt32(txtTelefono.Text);
                ObjMaestro.Email = txtEmail.Text;

                cargado = 1;

                frmMateriasImpartidasMestro materias = new frmMateriasImpartidasMestro();
                materias.Show();
            }
        }

        private void frmDatoMaestro_Load(object sender, EventArgs e)
        {

        }
    }
}
