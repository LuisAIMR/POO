using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoProgramas
{
    public partial class frmCatalogoInicio : Form
    {
        public frmCatalogoInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            Unidad4 unidad4 = new Unidad4();
            
            unidad4.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUnidad3_Click(object sender, EventArgs e)
        {
            
            Unidad3 unidad3 = new Unidad3();
            
            unidad3.Show();
            this.Hide();
        }

        private void btnUnidad5_Click(object sender, EventArgs e)
        {
            
            Unidad5 unidad5 = new Unidad5();
            
            unidad5.Show();
            this.Hide();
        }

        private void btnUnidad6_Click(object sender, EventArgs e)
        {
            
            Unidad6 unidad6 = new Unidad6();
            
            unidad6.Show();
            this.Hide();
        }

        private void btnUnidad1_Click(object sender, EventArgs e)
        {
            
            Unidad1 unidad1 = new Unidad1();
            
            unidad1.Show();
            this.Hide();
        }

        private void btnUnidad2_Click(object sender, EventArgs e)
        {
           
            Unidad2 unidad2 = new Unidad2();
            
            unidad2.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
