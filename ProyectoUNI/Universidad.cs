using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProyectoUNI
{
    public class Universidad
    {

        public class Estudiante
        {
            public string nombre { get; set; }
            public int numero_de_secciones { get; set; }
            public int numero_de_secciones_asistidas { get; set; }

            public class Asistencia
            {
                public static double CalcularPorcentaje(int numero_de_secciones_asistidas, int numero_de_secciones)
                {
                    return (double)numero_de_secciones_asistidas / numero_de_secciones * 100;
                }

                public static bool cumple_secciones_min(int numero_de_secciones_asistidas, int numero_de_secciones)
                {
                    double porcentaje_Asistencia = CalcularPorcentaje(numero_de_secciones_asistidas, numero_de_secciones);
                    return porcentaje_Asistencia >= 75;
                }

            }

        }
    }
}
