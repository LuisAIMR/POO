using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class ClassPersonas
    {
        public int CantidadTotal=0;
        //Atributos para mayor de edad
        public int mayorEdad = 0;
        public int Edad = 0;
        public int anioNac = 0, mesNac = 0, diaNac, anioAc=0, mesAc=0,diaAc=0;
        //Atributos para Cantidad Nayarit
        public string Estado;
        public int caNayarit=0;
        
        //Atributos para cantidad dependiendo del tipo de persona
        public int Maestro=0 , Alumno=0 , Administrativo=0;
        public int Cantidad = 0;
        public string Tipo;
        //Metodos de la clase
        public void MayorEdad()
        {

            if (anioAc - anioNac > 18)
            {
                mayorEdad ++;
            }

            else if (anioAc - anioNac == 18)
            {
                if (mesAc > mesNac)
                {
                    mayorEdad ++;
                }

                else if (mesAc == mesNac)
                {
                    if (diaAc > diaNac)
                    {
                        mayorEdad++;
                    }

                    else if (diaAc == diaNac)
                    {
                        mayorEdad ++;
                    }
                }
            }

        }
        public void CantidadNayarit()
        {
            switch (Estado)
            {
                case "Nayarit":
                    {
                        caNayarit++;
                        break;
                    }

            }
        }
        public void CantidadTipo()
        {
            switch(Tipo)
            {
                case "Maestro":
                    {
                        Maestro++;
                        CantidadTotal++;
                    }
                    break;
            

            
                case "Alumno":
                    {
                        Alumno++;
                        CantidadTotal++;
                    }
                     break;
            
            
                case "Administrativo":
                    {
                        Administrativo++;
                        CantidadTotal++;
                    }
                    break;

            }
           
        }
    }
}
