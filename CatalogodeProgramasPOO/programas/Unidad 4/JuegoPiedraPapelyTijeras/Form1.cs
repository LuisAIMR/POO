using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPiedraPapelyTijeras
{
    public partial class frmMenu : Form
    {
        JuegoPPT juego;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se utiliza el error provider para obligar al usuario a que introduzca su nombre de jugador
            if(txtNombre.Text=="")
            {
                error1.SetError(txtNombre, "Usted no ha introducido su nombre de jugador");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            JuegoPPT ObjJuegPPT = new JuegoPPT();
            ObjJuegPPT.NombreJugador = txtNombre.Text;
            //Se llama a frmJuego para enviar el dato a dicho windowsForms
            frmJuego juego = new frmJuego();
            juego.lblNombre.Text ="Nombre del jugador : " + ObjJuegPPT.NombreJugador;
            juego.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
