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

namespace ArchMaestrosyAlumnos
{
    public partial class DatosMaestros : Form
    {
        Maestro ObjMaestro = new Maestro();
        int contador = 1;
        StreamWriter DocMaestros;
        string almacenador;
        public DatosMaestros()
        {
            InitializeComponent();
            ObjMaestro.Nombre = new string[102];
            ObjMaestro.FechaNac = new DateTime[102];
            ObjMaestro.Curp = new string[102];
            ObjMaestro.Telefono = new decimal[102];
            ObjMaestro.Email = new string[102];
        }

        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            //Validación de caja de texto nombre
            Regex reNombre = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre válido");
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
                errorProvider1.SetError(txtTelefono, "Debe ingresar números en el campo Teléfono");
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

            //Validación de la caja de texto número del docente
            Regex reNumDocente = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumDocente.IsMatch(txtNumDoc.Text))
            {
                errorProvider1.SetError(txtNumDoc, "Ingrese números en el campo número de docente");
                txtNumDoc.Focus();
                return;
            }
            errorProvider1.SetError(txtNumDoc, "");

            //Validación de la cada de texto Sueldo
            decimal sueldo;

            if (!Decimal.TryParse(txtSueldo.Text, out sueldo))
            {
                errorProvider1.SetError(txtSueldo, "Ingrese números en el campo sueldo");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            if (sueldo < 0)
            {
                errorProvider1.SetError(txtSueldo, "Ingrese números positivos");
                txtSueldo.Focus();
                return;
            }

            //Validación de la caja de texto materias que imparte
            Regex reMImparte = new Regex("[a-zA-ZñÑ/s]", RegexOptions.Compiled);

            if (!reMImparte.IsMatch(txtMateriasImp.Text))
            {
                errorProvider1.SetError(txtMateriasImp, "Ingrese materia que imparte válida");
                txtMateriasImp.Focus();
                return;
            }
            errorProvider1.SetError(txtMateriasImp, "");

            //Condión que se cumplirá siempre y cuando, la longitud de los arreglos sea diferente de 102
            if (ObjMaestro.Nombre.Length != 102)
            {
                //las propiedades tomaran la posición que vaya indicando el contador 
                ObjMaestro.Nombre[contador] = txtNombre.Text;
                almacenador += "\n" + "Nombre del maestro: " + ObjMaestro.Nombre[contador] + "\n";
                ObjMaestro.FechaNac[contador] = dtpFechaNac.Value;
                almacenador += "Fecha de nacimiento: " + ObjMaestro.FechaNac[contador] + "\n";
                ObjMaestro.Curp[contador] = txtCurp.Text;
                almacenador += "Curp: " + ObjMaestro.Curp[contador] + "\n";
                ObjMaestro.Telefono[contador] = telefono;
                almacenador += "Telefono: " + ObjMaestro.Telefono[contador] + "\n";
                ObjMaestro.Email[contador] = txtEmail.Text;
                almacenador += "E-mail: " + ObjMaestro.Email[contador] + "\n";
                ObjMaestro.NumeroMaes[contador] = int.Parse(txtNumDoc.Text);
                almacenador += "Numero de maestro: " + ObjMaestro.NumeroMaes[contador] + "\n";
                ObjMaestro.Salario[contador] = sueldo;
                almacenador += "Sueldo: " + ObjMaestro.Salario[contador] + "\n";
                ObjMaestro.MateriasImparte[contador] = txtMateriasImp.Text;
                almacenador += "Materia que imparte: " + ObjMaestro.MateriasImparte[contador] + "\n";
                LimpiarControles();
            }
            else
            {
                //se incializa nuevamente los arreglos
                //Se indica la pocision de cada arreglo
                ObjMaestro.Nombre = new string[100];
                ObjMaestro.Nombre[0] = txtNombre.Text;
                almacenador += "\n" + "Nombre del maestro: " + ObjMaestro.Nombre[contador] + "\n";
                ObjMaestro.FechaNac = new DateTime[100];
                ObjMaestro.FechaNac[0] = dtpFechaNac.Value;
                almacenador += "Fecha de nacimiento: " + ObjMaestro.FechaNac[0] + "\n";
                ObjMaestro.Curp = new string[100];
                ObjMaestro.Curp[0] = txtCurp.Text;
                almacenador += "Curp: " + ObjMaestro.Curp[0] + "\n";
                ObjMaestro.Telefono = new decimal[100];
                ObjMaestro.Telefono[0] = telefono;
                almacenador += "Telefono: " + ObjMaestro.Telefono[0] + "\n";
                ObjMaestro.Email = new string[100];
                ObjMaestro.Email[0] = txtEmail.Text;
                almacenador += "E-mail: " + ObjMaestro.Email[0] + "\n";
                ObjMaestro.NumeroMaes = new int[100];
                ObjMaestro.NumeroMaes[0] = int.Parse(txtNumDoc.Text);
                almacenador += "Numero de maestro: " + ObjMaestro.NumeroMaes[0] + "\n";
                ObjMaestro.Salario = new decimal[100];
                ObjMaestro.Salario[0] = sueldo;
                almacenador += "Sueldo: " + ObjMaestro.Salario[0] + "\n";
                ObjMaestro.MateriasImparte = new string[100];
                ObjMaestro.MateriasImparte[0] = txtMateriasImp.Text;
                almacenador += "Materia que imparte: " + ObjMaestro.MateriasImparte[0] + "\n";


            }
        }
        public void LimpiarControles()
        {
            //Método para limpiar los textbox
            txtNombre.Clear();
            txtCurp.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNumDoc.Clear();
            txtSueldo.Clear();
            txtMateriasImp.Clear();
        }
        private void DatosMaestros_Load(object sender, EventArgs e)
        {

        }
    }
}
