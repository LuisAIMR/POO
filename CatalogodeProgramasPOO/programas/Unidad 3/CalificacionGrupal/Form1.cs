using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionGrupal
{
    public partial class frmCalificaciones : Form
    {
        ClassCalificaciones objCalificaciones = new ClassCalificaciones();
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCalificacion.Text == "")
            {
                error1.SetError(txtCalificacion, "Debe introducir una calificacion");
                txtCalificacion.Focus();
                return;

            }
            error1.SetError(txtCalificacion, "");



            objCalificaciones.calificacionIntroducida = int.Parse(txtCalificacion.Text.ToString());
            objCalificaciones.capturarCalificación();
            txtCalificacion.Text = "";
            MessageBox.Show("Calificacion capturada con exito");
            txtCalificacion.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblTotalAprobados.Text = objCalificaciones.aprobados.ToString();
            lblTotalReprobados.Text = objCalificaciones.reprobados.ToString();
            lblResultadoPromedioGrupal.Text = objCalificaciones.promedio.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
