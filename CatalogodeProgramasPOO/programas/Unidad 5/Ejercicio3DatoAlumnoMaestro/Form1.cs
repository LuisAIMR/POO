using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3DatoAlumnoMaestro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipo.Items.Add("Alumno");
            cmbTipo.Items.Add("Maestro");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(cmbTipo.Text=="Alumno")
            {
                frmDatoAlumno fAlumno = new frmDatoAlumno();
                fAlumno.Show();
            }
            else if (cmbTipo.Text == "Maestro")
            {
                frmDatoMaestro fMaestro = new frmDatoMaestro();
                fMaestro.Show();
            }
        }
    }
}
