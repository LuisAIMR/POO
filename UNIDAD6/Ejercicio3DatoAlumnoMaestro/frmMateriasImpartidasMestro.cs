using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3DatoAlumnoMaestro
{
    public partial class frmMateriasImpartidasMestro : Form
    {
        Maestro ObjMaestro = new Maestro();
        int cantidadMaterias =0;
        int contador = 1;
        public string almacenador;
        StreamWriter DatoMaestro;
        public frmMateriasImpartidasMestro()
        {
            InitializeComponent();
            ObjMaestro.MateriasImp = new string[1000];
            gbxMaterias.Enabled = false;
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

            //Define la cantidad de datos que el usuario desea introducir
            cantidadMaterias = Convert.ToInt32(txtCantidadMaterias.Text);
            MessageBox.Show("Se definio la cantidad de materias", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbxMaterias.Enabled = true;
            btnListo.Enabled = false;
            almacenador += "\n";
        }

        private void btnAgregarMaterias_Click(object sender, EventArgs e)
        {
            //validar que los datos introducidos sean correctos dependiendo del tipo de dato
            int Cmaterias;
            Cmaterias =Convert.ToInt32(txtCantidadMaterias.Text);
            if (Cmaterias < 0)
            {
                errorProvider1.SetError(txtCantidadMaterias, "Ingrese numeros positivos");
                txtCantidadMaterias.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidadMaterias, "");
            //expresion regular para validar que se introduzcan numeros en el campo
            Regex reNumDocente = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumDocente.IsMatch(txtCantidadMaterias.Text))
            {
                errorProvider1.SetError(txtCantidadMaterias, "Inrege datos validos, ingrese numeros");
                txtCantidadMaterias.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidadMaterias, "");
            if (txtMateria.Text=="")
            {
                errorProvider1.SetError(txtMateria, "Ingrese el nombre de la materia que imparte");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            //condicion paa habilitar el boton hasta que el usuario desee.
            if (contador < cantidadMaterias)
            {
                //condicion if para definir una cantidad limite determinada.
                if (ObjMaestro.MateriasImp.Length != 1000)
                {

                    //asinga un valor al indice del arreglo
                    
                    almacenador += "Materia numero [" + (contador + 1) + "]"+"\n";
                    almacenador += "Nombre de la materia: ";
                    ObjMaestro.MateriasImp[contador] = txtMateria.Text;
                    almacenador += ObjMaestro.MateriasImp[contador]+"\n";
                    //Método para limpiar el textbox 
                    txtMateria.Clear();
                    //contador
                    contador++;
                    MessageBox.Show("Materia Agregada", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }                
                else
                {

                    //Intancio una cantidad grande para que el usuario tenga una gran extension para introducir las materias que desee
                    //Aunque esta limitado a 100
                    ObjMaestro.MateriasImp = new string[100];
                    //Se indica la posición del arreglo
                    almacenador += "Materia numero [" + (contador) + "]" + "\n";
                    almacenador += "Nombre de la materia: ";
                    ObjMaestro.MateriasImp[0] = txtMateria.Text;
                    almacenador += ObjMaestro.MateriasImp[0]+"\n";
                    MessageBox.Show("Materia Agregada", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    //Método para limpiar el textbox
                    txtMateria.Clear();
                }
                
            }
            //condicion para inhabilitar controles hasta donde el usuario deseee
            if (contador == cantidadMaterias)
            {
                gbxMaterias.Enabled = false;
                MessageBox.Show("Lo sentimos excedio la cantidad de materias que selecciono", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnImprimr_Click(object sender, EventArgs e)
        {
            DatoMaestro = new StreamWriter("DatosMaestro.txt");
            //Limpiar filas del DataGridView
            dgvMateriasImp.Rows.Clear();

            //Ciclo for para crear celdas e introducirles el valor definido hasta que se cumpla la condicion
            for (int i = 0; i <cantidadMaterias; i++)
            {
                //Agrega datos a las celdas del DataGridView
                if (ObjMaestro.MateriasImp[i] != "")
                {
                    //Le asigna una pocicion al indice del arreglo en el DataGridView
                    dgvMateriasImp.Rows.Add(ObjMaestro.MateriasImp[i]);
                }
            }
            DatoMaestro.Write(almacenador);
            DatoMaestro.Close();
        }

        private void frmMateriasImpartidasMestro_Load(object sender, EventArgs e)
        {

        }
    }
}
