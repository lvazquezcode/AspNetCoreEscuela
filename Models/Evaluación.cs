using System;

namespace MvcWebTest.Models
{
    public class Evaluación : ObjetoEscuelaBase
    {
        public String AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        public String AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}