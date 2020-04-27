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
    public partial class frmDatoAlumno : Form
    {
        Alumno ObjAlumno = new Alumno();       
        int cargado = 0;        
        public frmDatoAlumno()
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
            if (txtCarrera.Text=="")
            {
                errorProvider1.SetError(txtCarrera, "Ingrese el nombre de la carrera");
                txtCarrera.Focus();
                return;
            }
            errorProvider1.SetError(txtCarrera, "");

            //cargar solo una vez datos                        
            if (cargado==0)
            {
                ObjAlumno.Nombre = txtNombre.Text;
                ObjAlumno.FechaNacimiento = dtpFechaNacimiento.Value;
                ObjAlumno.Curp = txtCurp.Text;
                ObjAlumno.Telfono = Convert.ToInt32(txtTelefono.Text);
                ObjAlumno.Email = txtEmail.Text;
                
                cargado = 1;

                frmMateriasDelAlumno materias = new frmMateriasDelAlumno();
                materias.Show();
            }   
                               
        }

        private void frmDatoAlumno_Load(object sender, EventArgs e)
        {

        }

        private void gbxDatosAlumno_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregarMaterias_Click(object sender, EventArgs e)
        {
            

        
        }
        

        private void btnImprimr_Click(object sender, EventArgs e)
        {
            

        }       
    }
}
