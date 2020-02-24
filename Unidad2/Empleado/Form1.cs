using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado
{
    public partial class frmEmpleado : Form
    {
        ClassEmpleado objEmpleado = new ClassEmpleado();
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if (txtAniosTrabajados.Text == "") 
            {
                error1.SetError(txtAniosTrabajados, "Debe introducir la cantidad de años trabajados");
                txtAniosTrabajados.Focus();
                return;
            }
            error1.SetError(txtAniosTrabajados, "");

            objEmpleado.aniosTrabajados =int.Parse (txtAniosTrabajados.Text);
            objEmpleado.DiasVacasiones();
            lblResVacasiones.Text = objEmpleado.diasVacasiones.ToString();
            txtAniosTrabajados.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblResVacasiones.Text = "";
        }
    }
}
