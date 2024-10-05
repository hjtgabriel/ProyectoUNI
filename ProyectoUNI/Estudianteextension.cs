using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUNI
{
    public static class Estudianteextension
    {
        public static void MostrarInfo(this Universidad.Estudiante estudiante)
        {
            double porcentajeAsistencia = Universidad.Estudiante.Asistencia.CalcularPorcentaje(estudiante.numero_de_secciones_asistidas, estudiante.numero_de_secciones);
            bool aprobado = Universidad.Estudiante.Asistencia.cumple_secciones_min(estudiante.numero_de_secciones_asistidas,estudiante.numero_de_secciones);
            {

                Console.WriteLine($"Estudiante: {estudiante.nombre},Porcentaje de Asistencia:{porcentajeAsistencia}%");
                if (aprobado)
                {
                    Console.WriteLine($"Estado Aprobado");
                } else
                {
                    Console.WriteLine($"No aprobado");
                }

            }
        }
    }
}
