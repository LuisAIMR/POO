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

namespace Ejercicio4DatosAlumnosMaestros
{
    public partial class DatosAlumnos : Form
    {
        Alumno ObjAlumno = new Alumno();
        int contador=1;
        public DatosAlumnos()
        {
            InitializeComponent();
            ObjAlumno.Nombre = new string[102];
            ObjAlumno.FechaNac = new DateTime[102];
            ObjAlumno.Curp = new string[102];
            ObjAlumno.Telefono = new decimal[102];
            ObjAlumno.Email = new string[102];
            ObjAlumno.NumControl = new int[102];
            ObjAlumno.Carrera = new string[102];
            ObjAlumno.Materia = new string[102];
            ObjAlumno.Calificacion = new double[102];

        }

        private void dgvDatosAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            //Validar nombre
            Regex reNombre = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre válido");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            //Validar curp
            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);

            if (!reCurp.IsMatch(txtCurp.Text))
            {
                errorProvider1.SetError(txtCurp, "Ingrese una curp válida");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");

            //Validar teléfono
            decimal telefono;

            if (!Decimal.TryParse(txtTelefono.Text, out telefono))
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar números en el campo Teléfono");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            //Validar correo 
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

            //Validar número de control
            Regex reNumControl = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumControl.IsMatch(txtNumControl.Text))
            {
                errorProvider1.SetError(txtNumControl, "Ingrese números en el campo número de control");
                txtNumControl.Focus();
                return;
            }
            errorProvider1.SetError(txtNumControl, "");

            //Validar carrera          
            if (txtCarrera.Text=="")
            {
                errorProvider1.SetError(txtCarrera, "Ingrese una carrera válida");
                txtCarrera.Focus();
                return;
            }
            errorProvider1.SetError(txtCarrera, "");

            //Validar materia
            Regex reMateria = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reMateria.IsMatch(txtMateria.Text))
            {
                errorProvider1.SetError(txtMateria, "Ingrese una materia válida");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            //Validar calificacion
            Regex reCalificacion = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (txtCalMateria.Text == "")
            {
                errorProvider1.SetError(txtCalMateria, "Ingrese una calificación válida");
                txtCalMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtCalMateria, "");           
            if (ObjAlumno.Nombre.Length != 102)
            {
                //Agniar indice en el que obtendra los datos a partir del cotador
                ObjAlumno.Nombre[contador] = txtNombre.Text;
                ObjAlumno.FechaNac[contador] = dtpFechaNac.Value;
                ObjAlumno.Curp[contador] = txtCurp.Text;
                ObjAlumno.Telefono[contador] = telefono;
                ObjAlumno.Email[contador] = txtEmail.Text;
                ObjAlumno.NumControl[contador] = int.Parse(txtNumControl.Text);
                ObjAlumno.Carrera[contador] = txtCarrera.Text;
                ObjAlumno.Materia[contador] = txtMateria.Text;
                ObjAlumno.Calificacion[contador] = double.Parse(txtCalMateria.Text);

                LimpiarControles();
                //Contador
                contador++;
            }            
            else
            {
                //se incializan los nuevos arreglos.
                //Se indica la posición de cada uno de los arreglos
                ObjAlumno.Nombre = new string[100];                
                ObjAlumno.Nombre[0] = txtNombre.Text;             
                ObjAlumno.FechaNac = new DateTime[100];
                ObjAlumno.FechaNac[0] = dtpFechaNac.Value;                
                ObjAlumno.Curp = new string[100];            
                ObjAlumno.Curp[0] = txtCurp.Text;
                ObjAlumno.Telefono = new decimal[100];               
                ObjAlumno.Telefono[0] = telefono;       
                ObjAlumno.Email = new string[100];              
                ObjAlumno.Email[0] = txtEmail.Text;         
                ObjAlumno.NumControl = new int[100];                
                ObjAlumno.NumControl[0] = int.Parse(txtNumControl.Text);             
                ObjAlumno.Carrera = new string[100];                
                ObjAlumno.Carrera[0] = txtCarrera.Text;              
                ObjAlumno.Materia = new string[100];                
                ObjAlumno.Materia[0] = txtMateria.Text;            
                ObjAlumno.Calificacion = new double[100];                
                ObjAlumno.Calificacion[0] = double.Parse(txtCalMateria.Text);
                LimpiarControles();
               
                
            }
        }
        //Método para limpiar los textbox
        public void LimpiarControles()
        {
            txtNombre.Clear();
            txtCurp.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNumControl.Clear();
            txtCarrera.Clear();
            txtMateria.Clear();
            txtCalMateria.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Limpiar las filas de datagridview
            dgvDatosAlumno.Rows.Clear();

            //ciclo para definir la extension del arreglo
            for (int i = 0; i < ObjAlumno.Nombre.Length; i++)
            {
               //condicion para asignrar espacio en el DataGridView a los datos
                if (ObjAlumno.Nombre[i] != "" && ObjAlumno.Telefono[i] != 0)
                {
                    //Agrega datos
                    dgvDatosAlumno.Rows.Add(ObjAlumno.Nombre[i], ObjAlumno.FechaNac[i], ObjAlumno.Curp[i], 
                                            ObjAlumno.Telefono[i], ObjAlumno.Email[i], ObjAlumno.NumControl[i],
                                            ObjAlumno.Carrera[i], ObjAlumno.Materia[i], ObjAlumno.Calificacion[i]);
                }
            }
        }

        private void DatosAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
