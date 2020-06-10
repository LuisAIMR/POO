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
    public partial class frmMateriasDelAlumno : Form
    {
        Alumno ObjAlumno= new Alumno();
        int contador=1;      
        int cantidadMaterias=0;
        public frmMateriasDelAlumno()
        {
            InitializeComponent();
            ObjAlumno.Materias = new string[1000];
            ObjAlumno.Calificacion = new double[1000];
            btnAgregarMaterias.Enabled = false;
        }

        private void btnAgregarMaterias_Click(object sender, EventArgs e)
        {
            
            if (txtMateria.Text == "")
            {
                errorProvider1.SetError(txtMateria, "Ingrese el nombre de la materia");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");
            decimal Calificacion;

            if (!Decimal.TryParse(txtCalificacion.Text, out Calificacion))
            {
                errorProvider1.SetError(txtCalificacion, "introduzca numeros");
                txtCalificacion.Focus();
                return;
            }
            errorProvider1.SetError(txtCalificacion, "");

            if (contador<cantidadMaterias)
            {
                //Condión que se cumplirá siempre y cuando, la longitud de los arreglos sea diferente de 12
                if (ObjAlumno.Materias.Length != 1000)
                {

                    //las propiedades tomaran la posición que vaya indicando el contador 
                    ObjAlumno.Materias[contador] = txtMateria.Text;
                    ObjAlumno.Calificacion[contador] = double.Parse(txtCalificacion.Text);
                    //ObjAlumno.Calificacion[contador] = double.Parse(txtCalificacion.Text);
                    contador++;
                    MessageBox.Show("Materia Agregada","Materias",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpiarControles();
                    //El contador incrementa de 1 en 1

                }
                //Sino se cumple la primera condición, entra a else
                else
                {
                    ObjAlumno.Materias = new string[100];
                    //Se indica la posición
                    ObjAlumno.Materias[0] = txtMateria.Text;
                    //se incializa de nuevo el arreglo, pero ahora con un tamaño de 10 y así, pueda entrar a la primera condición
                    ObjAlumno.Calificacion = new double[10];
                    //Se indica la posición del arreglo
                    ObjAlumno.Calificacion[0] = double.Parse(txtCalificacion.Text);
                    MessageBox.Show("Materia Agregada", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                }
                
            }
            if (contador == cantidadMaterias)
            {
                gbxMaterias.Enabled = false;
                MessageBox.Show("Lo sentimos excedio la cantidad de materias que selecciono","Materias",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }
        public void LimpiarControles()
        {
            txtMateria.Clear();
            txtCalificacion.Clear();
        }

        private void btnImprimr_Click(object sender, EventArgs e)
        {
            //limpiar las filas de datagridview
            dgvCalificaciones.Rows.Clear();

            //Ciclo for para definir la longitud y agregar datos al DataGridView
            for (int i = 0; i < cantidadMaterias; i++)
            {
                if (ObjAlumno.Materias[i] != "" && ObjAlumno.Calificacion[i] != 0)
                {
                    //Agrega la posicion del indce en el datagridview
                    dgvCalificaciones.Rows.Add(ObjAlumno.Materias[i], ObjAlumno.Calificacion[i]);
                }
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            Regex reNumMaterias = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumMaterias.IsMatch(txtCantidadMaterias.Text))
            {
                errorProvider1.SetError(txtCantidadMaterias, "Inrege datos validos, ingrese numeros");
                txtCantidadMaterias.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidadMaterias, "");
            //validar que los datos introducidos sean correctos dependiendo del tipo de dato
            int Cmaterias;
            Cmaterias = Convert.ToInt32(txtCantidadMaterias.Text);
            if (Cmaterias < 0)
            {
                errorProvider1.SetError(txtCantidadMaterias, "Ingrese numeros positivos");
                txtCantidadMaterias.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidadMaterias, "");
            //expresion regular para validar que se introduzcan numeros en el campo
            
           
            cantidadMaterias = Convert.ToInt32(txtCantidadMaterias.Text);
            MessageBox.Show("Se definio la cantidad de materias", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAgregarMaterias.Enabled = true;
            btnListo.Enabled = false;
        }

        private void frmMateriasDelAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
