using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto
{
    class ClassAsistente
    {
        //Atributos
        public int cantidad = 0;
        public string asistente;

        //Atributos de la clase usadas en metodos
        public int bebesN = 0, niñosN = 0, adultosN = 0, adultosMayoresN = 0;

        //Metodos de la clase 
        public void ContabilizarAsistentes()
        {
            switch(asistente)
            {
                case "Bebes":
                    bebesN = bebesN + cantidad;
                    break;
                case "Niños":
                    niñosN = niñosN + cantidad;
                    break;
                case "Adultos":
                    adultosN = adultosN + cantidad;
                    break;
                case "Adultos mayores":
                   adultosMayoresN = adultosMayoresN + cantidad;
                    break;


            } 
         
             
        }
        
       
    }
}
