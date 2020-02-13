using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionGrupal
{
    class ClassCalificaciones
    {
        //Atributos de la clase 
        public int calificacionIntroducida = 0;
        public int aprobados = 0;
        public int reprobados = 0;
        int cantidadCalificaciones = 0;
        public double promedio = 0;
        int sumaCalificaciones = 0;

        //Métodos de la clase 
        public void capturarCalificación()
        {
            if (calificacionIntroducida >= 70)
            {
                aprobados = aprobados + 1;
                sumaCalificaciones = sumaCalificaciones + calificacionIntroducida;
            }
            else
            {
                reprobados = reprobados + 1;
                sumaCalificaciones = sumaCalificaciones + calificacionIntroducida;
            }
            cantidadCalificaciones++;
            promedio = sumaCalificaciones / cantidadCalificaciones;
        }
    }
}
