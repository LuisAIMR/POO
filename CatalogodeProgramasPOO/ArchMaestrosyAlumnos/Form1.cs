using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchMaestrosyAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipo.Items.Add("Alumno");
            cmbTipo.Items.Add("Maestro");
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Alumno")
            {
                DatosAlumnos fAlumno = new DatosAlumnos();
                fAlumno.Show();
            }
            else if (cmbTipo.Text == "Maestro")
            {
                DatosMaestros fMaestro = new DatosMaestros();
                fMaestro.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
