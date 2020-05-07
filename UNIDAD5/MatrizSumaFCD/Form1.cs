﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizSumaFCD
{
    public partial class frmMatrizSumaFCD : Form
    {
        MatrizFCD ObjMatrizFCD = new MatrizFCD();
        //Acumuladores para visualizar posteriormente en los ritchtTextBox
        string Acum;
        string AcumC;
        string AcumF;
        string AcumD;
        public frmMatrizSumaFCD()
        {
            InitializeComponent();
            btnAgregarElementos.Enabled = true;
            btnSumaColumnas.Enabled = false;
            btnSumaDiagonales.Enabled = false;
            btnSumaFilas.Enabled = false;
            btnElementosDiagonal.Enabled = false;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void frmMatrizSumaFCD_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarElementos_Click(object sender, EventArgs e)
        {
            //Definir el tamaño del arreglo
            ObjMatrizFCD.MatrizNM = new int[(int)nudTamanoMatriz.Value, (int)nudTamanoMatriz.Value];
            //Ingresar los datos
            for(int f=0;f<ObjMatrizFCD.MatrizNM.GetLength(0);f++)
            {
                Acum += "\r\n";
                for (int c = 0; c < ObjMatrizFCD.MatrizNM.GetLength(1); c++)
                {
                    ObjMatrizFCD.MatrizNM[f, c] =Convert.ToInt16(Interaction.InputBox("Introduce el elemento ["+f+"] ["+c+"]"));
                    Acum += ObjMatrizFCD.MatrizNM[f, c];
                    rtbMatrizNM.Text = Acum;
                }
            }

            btnAgregarElementos.Enabled = false;
            btnSumaColumnas.Enabled = true;
            btnSumaDiagonales.Enabled = true;
            btnSumaFilas.Enabled = true;
            btnElementosDiagonal.Enabled = true;  
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            ObjMatrizFCD.Diagonal = new int[(int)nudTamanoMatriz.Value];
            Acum = "";
            for (int f = 0; f < ObjMatrizFCD.MatrizNM.GetLength(0); f++)
            {                
                for (int c = 0; c < ObjMatrizFCD.MatrizNM.GetLength(1); c++)
                {   
                    //Agregar los datos del arreglo de los elementos diagonales usando una condificion if
                    if(f==c)
                    {
                        ObjMatrizFCD.Diagonal[c] = ObjMatrizFCD.MatrizNM[f, c];
                        Acum += ObjMatrizFCD.Diagonal[c]+" ";
                        rtbElementosDiagonal.Text = Acum;
                    }           
                   
                }
            }
            btnElementosDiagonal.Enabled = false;
            btnSumaDiagonales.Enabled = true;
        }

        private void btnSumaFilas_Click(object sender, EventArgs e)
        {
            ObjMatrizFCD.SumaFilas = new int[(int)nudTamanoMatriz.Value];
            ObjMatrizFCD.MSumaFilas();
            for (int f = 0; f < ObjMatrizFCD.SumaFilas.Length; f++)
            {
                AcumF += ObjMatrizFCD.SumaFilas[f] + " ";
                rtbSumaFilas.Text = AcumF;
            }
            btnSumaFilas.Enabled = false;
        }

        private void btnSumaColumnas_Click(object sender, EventArgs e)
        {
            ObjMatrizFCD.SumaColumnas = new int[(int)nudTamanoMatriz.Value];
            ObjMatrizFCD.MSumaColumnas();
            for (int f = 0; f < ObjMatrizFCD.SumaColumnas.Length; f++)
            {
                AcumC += ObjMatrizFCD.SumaColumnas[f] + "\n";
                rtbSumaColumnas.Text = AcumC;
            }
            btnSumaColumnas.Enabled = false;
        }

        private void btnSumaDiagonales_Click(object sender, EventArgs e)
        {
            rtbSumaDiagonal.Text = ObjMatrizFCD.MSumaDiagonales();
            btnSumaDiagonales.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
