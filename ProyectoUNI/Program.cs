using System;
using System.Collections.Generic;

namespace ProyectoUNI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Universidad.Estudiante> estudiantes = new List<Universidad.Estudiante>
        {
            new Universidad.Estudiante {nombre = "Hernan Jiron", numero_de_secciones = 20, numero_de_secciones_asistidas = 20 },
            new Universidad.Estudiante {nombre = "Danilo medina", numero_de_secciones = 20, numero_de_secciones_asistidas = 10},
            new Universidad.Estudiante {nombre = "Silvio Rojas", numero_de_secciones = 20, numero_de_secciones_asistidas = 15,},
            new Universidad.Estudiante {nombre = "Edgard Lopez", numero_de_secciones = 20, numero_de_secciones_asistidas = 17,},
            new Universidad.Estudiante {nombre = "Josthin Vallecillo", numero_de_secciones = 20, numero_de_secciones_asistidas = 10},
            new Universidad.Estudiante {nombre = "Carmina Torres", numero_de_secciones = 20, numero_de_secciones_asistidas = 12,},
            new Universidad.Estudiante {nombre = "Carolina Torres", numero_de_secciones = 20, numero_de_secciones_asistidas = 16},
            new Universidad.Estudiante {nombre = "Juan Torres", numero_de_secciones = 20, numero_de_secciones_asistidas = 20}
        };


            
            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarInfo();
            }
        }

    }

}
