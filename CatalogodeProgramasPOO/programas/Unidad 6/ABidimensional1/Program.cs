﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABidimensional1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] notas;         // Los array de dos dimensiones no solo se pueden declarar [,] sino tambien asi [][]
            notas = new int[3][];  // se le asgina al arreglo que contendra 3 filas
            notas[0] = new int[10];  // la primera fila contendra 10 columnas
            notas[1] = new int[15];  // la segunda fila contendra 15 columnas
            notas[2] = new int[12];  // la tercera fila contendra 12 columnas
            StreamWriter archivo;
            string datos="";
            // se le asigna un valor a los indices del arreglo
            
            for (int i = 0; i < notas.Length; i++)
            {

                for (int j = 0; j < notas[i].Length; j++)
                {
                    notas[i][j] = i + j;
                    
                    
                }
                
            }

            archivo = new StreamWriter("archivo.txt");
            // Y mostramos esos valores
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < notas[i].Length; j++)
                {
                    Console.Write(" {0}", notas[i][j]);
                    datos += notas[i][j]+" ";                
                }
                datos += Environment.NewLine;
                Console.WriteLine();
            }
            
            archivo.Write(datos);
            archivo.Close();
            Console.ReadKey();
        } // Fin de "Main"
    }    
}
