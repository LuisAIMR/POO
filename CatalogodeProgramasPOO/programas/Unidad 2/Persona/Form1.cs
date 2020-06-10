using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class frmPersona : Form
    {
        ClassPersona objPersona = new ClassPersona();
        public frmPersona()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEvaluarEdad_Click(object sender, EventArgs e)
        {
            
            objPersona.anioAc =int.Parse(DateTime.Today.Year.ToString());
            objPersona.mesAc = int.Parse(DateTime.Today.Month.ToString());
            objPersona.diaAc = int.Parse(DateTime.Today.Day.ToString());
            objPersona.anioNac = int.Parse(dtpFechaNac.Value.Year.ToString());
            objPersona.mesNac= int.Parse(dtpFechaNac.Value.Month.ToString());
            objPersona.diaNac = int.Parse(dtpFechaNac.Value.Day.ToString());
            objPersona.MayorEdad();
            lblMayorEdad.Text = objPersona.mayorEdad;
            objPersona.mayorEdad = "";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
