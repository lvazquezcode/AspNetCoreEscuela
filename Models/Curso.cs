using System;
using System.Collections.Generic;
//using MvcWebTest.Util;

namespace MvcWebTest.Models
{
    public class Curso : ObjetoEscuelaBase//, ILugar
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public string Dirección { get; set; }

        public String EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
    }
}