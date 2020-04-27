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
    public partial class DatosMaestros : Form
    {
        Maestro ObjMaestro = new Maestro();
        int contador = 1;
        public DatosMaestros()
        {
            InitializeComponent();
            ObjMaestro.Nombre = new string[102];
            ObjMaestro.FechaNac = new DateTime[102];
            ObjMaestro.Curp = new string[102];
            ObjMaestro.Telefono = new decimal[102];
            ObjMaestro.Email = new string[102];
        }

        private void btmGuardar_Click(object sender, EventArgs e)
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
                ObjMaestro.FechaNac[contador] = dtpFechaNac.Value;
                ObjMaestro.Curp[contador] = txtCurp.Text;
                ObjMaestro.Telefono[contador] = telefono;
                ObjMaestro.Email[contador] = txtEmail.Text;
                ObjMaestro.NumeroMaes[contador] = int.Parse(txtNumDoc.Text);
                ObjMaestro.Salario[contador] = sueldo;
                ObjMaestro.MateriasImparte[contador] = txtMateriasImp.Text;

                LimpiarControles();
            }
            else
            {
                //se incializa nuevamente los arreglos
                //Se indica la pocision de cada arreglo
                ObjMaestro.Nombre = new string[100];               
                ObjMaestro.Nombre[0] = txtNombre.Text;              
                ObjMaestro.FechaNac = new DateTime[100];               
                ObjMaestro.FechaNac[0] = dtpFechaNac.Value;              
                ObjMaestro.Curp = new string[100];               
                ObjMaestro.Curp[0] = txtCurp.Text;                
                ObjMaestro.Telefono = new decimal[100];             
                ObjMaestro.Telefono[0] = telefono;                
                ObjMaestro.Email = new string[100];               
                ObjMaestro.Email[0] = txtEmail.Text;                
                ObjMaestro.NumeroMaes = new int[100];                
                ObjMaestro.NumeroMaes[0] = int.Parse(txtNumDoc.Text);                
                ObjMaestro.Salario = new decimal[100];               
                ObjMaestro.Salario[0] = sueldo;                
                ObjMaestro.MateriasImparte = new string[100];           
                ObjMaestro.MateriasImparte[0] = txtMateriasImp.Text;


            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Método para que se limpien las filas de datagridview
            dgvDatosMaestros.Rows.Clear();

            //Ciclo for que se cumplira siempre y cuando la variable i, sea menor a la 
            //Longitud del arreglo 
            for (int i = 0; i < ObjMaestro.Nombre.Length; i++)
            {
                //En caso de que el ciclo for se cumpla, entra a una condición que se cumplirá
                //siempre y cuando la posicion del arreglo Nombre se quede vacia, el arreglo telefono sea diferente a 0 
                if (ObjMaestro.Nombre[i] != "" && ObjMaestro.Telefono[i] != 0)
                {
                    //Agrega la posicion del arreglo al datagridview
                    dgvDatosMaestros.Rows.Add(ObjMaestro.Nombre[i], ObjMaestro.FechaNac[i], 
                                              ObjMaestro.Curp[i], ObjMaestro.Telefono[i], 
                                              ObjMaestro.Email[i], ObjMaestro.NumeroMaes[i],
                                              ObjMaestro.Salario[i], ObjMaestro.MateriasImparte[i]);
                }
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
    }
}
