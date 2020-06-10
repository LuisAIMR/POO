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

namespace ArchEjercicioAlumnoMaestr
{
    public partial class DatoAlumno : Form
    {
        Alumno ObjAlumno = new Alumno();
        int cargado = 0;
        string almacenador = "";
        public DatoAlumno()
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
            Regex reNumControl = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumControl.IsMatch(txtNumeroControl.Text))
            {
                errorProvider1.SetError(txtNumeroControl, "Ingrese el numero de control valido");
                txtNumeroControl.Focus();
                return;
            }
            errorProvider1.SetError(txtNumeroControl, "");
            if (txtCarrera.Text == "")
            {
                errorProvider1.SetError(txtCarrera, "Ingrese el nombre de la carrera");
                txtCarrera.Focus();
                return;
            }
            errorProvider1.SetError(txtCarrera, "");

            //cargar solo una vez datos                        
            if (cargado == 0)
            {
                almacenador += "Nombre del Alumno: ";
                ObjAlumno.Nombre = txtNombre.Text;
                almacenador += ObjAlumno.Nombre + "\n";
                almacenador += "Fecha de nacimineto: ";
                ObjAlumno.FechaNacimiento = dtpFechaNacimiento.Value;
                almacenador += ObjAlumno.FechaNacimiento + "\n";
                almacenador += "Curp: ";
                ObjAlumno.Curp = txtCurp.Text;
                almacenador += ObjAlumno.Curp + "\n";
                almacenador += "Telefono: ";
                ObjAlumno.Telefono = txtTelefono.Text;
                almacenador += ObjAlumno.Telefono + "\n";
                almacenador += "E-mail: ";
                ObjAlumno.Email = txtEmail.Text;
                almacenador += ObjAlumno.Email + "\n";

                cargado = 1;

                frmMateriasAlumno materias = new frmMateriasAlumno();
                materias.almacenador = almacenador;
                materias.Show();
            }
        }
    }
}
