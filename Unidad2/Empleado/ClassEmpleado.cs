using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    class ClassEmpleado
    {
        // Atributos de la clase
        public int aniosTrabajados = 0;
        public int diasVacasiones = 0;

        //Metodos de la clase
        public void DiasVacasiones()
        {
            if (aniosTrabajados>0 & aniosTrabajados<=5)
            {
                diasVacasiones = diasVacasiones + 5;
            }
            else if(aniosTrabajados>=6 & aniosTrabajados<=10)
            {
                diasVacasiones = diasVacasiones + 10;
            }
            else if (aniosTrabajados>=10 & aniosTrabajados<20)
            {
                diasVacasiones = 10+((aniosTrabajados-10)*1);

            }
            else if (aniosTrabajados>=20)
            {
                diasVacasiones = 10+((aniosTrabajados-20)*2);

                if (diasVacasiones>45)
                {
                    diasVacasiones = 45;
                }
            }
        }
    }
}
