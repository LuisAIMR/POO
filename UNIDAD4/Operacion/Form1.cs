using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operacion
{
    
    public partial class Form1 : Form
    {
        Resta objResta;
        Suma objSuma;
        Multiplicacion objMultiplicacion;
        Division objDivision;


        public Form1()
        {
            InitializeComponent();
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtValor1.Text=="")
            {
                errorColocarValor1.SetError(txtValor1, "Colocar el valor 1");
                txtValor1.Focus();
                return;
            }
            errorColocarValor1.SetError(txtValor1, "");

            if(txtValor2.Text=="")
            {
                errorColocarValor2.SetError(txtValor2,"Colocar el valor 2");
                txtValor2.Focus();
                return;
            }
            errorColocarValor2.SetError(txtValor2, "");

            if(cmbOperacion.Text=="")
            {
                errorColocarOperacion.SetError(cmbOperacion,"Colocar el tipo de operacion que deseas realizar");
                cmbOperacion.Focus();
                return;
            }
            errorColocarOperacion.SetError(cmbOperacion, "");

            if (cmbOperacion.Text=="+")
            {
                Suma objSuma = new Suma();
                objSuma.Valor1 = Convert.ToDouble(txtValor1.Text.ToString());
                objSuma.Valor2 = Convert.ToDouble(txtValor2.Text.ToString());
                objSuma.sumar();
                lblResultado.Text = "La suma es: " + objSuma.Resultado.ToString();
            }
            else if (cmbOperacion.Text=="-")
            {
                Resta objResta=new Resta();
                objResta.Valor1 = Convert.ToDouble(txtValor1.Text.ToString());
                objResta.Valor2 = Convert.ToDouble(txtValor2.Text.ToString());
                objResta.restar();
                lblResultado.Text = "La resta es: " + objResta.Resultado.ToString();
            }
            else if(cmbOperacion.Text=="*")
            {
                Multiplicacion objMultiplicacion = new Multiplicacion();
                objMultiplicacion.Valor1 = Convert.ToDouble(txtValor1.Text.ToString());
                objMultiplicacion.Valor2 = Convert.ToDouble(txtValor2.Text.ToString());
                objMultiplicacion.multiplicar();
                lblResultado.Text = "La multiplicacion es: " + objMultiplicacion.Resultado.ToString();
            }
            else if (cmbOperacion.Text=="/")
            {
                Division objDivision = new Division();
                objDivision.Valor1 = Convert.ToDouble(txtValor1.Text.ToString());
                objDivision.Valor2 = Convert.ToDouble(txtValor2.Text.ToString());
                objDivision.dividir();
                lblResultado.Text = "La division es: " + objDivision.Resultado.ToString();
            }
            

            
        }
    }
}
