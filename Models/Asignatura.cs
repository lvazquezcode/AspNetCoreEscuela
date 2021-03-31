using System;
using System.Collections.Generic;

namespace MvcWebTest.Models
{
    public class Asignatura : ObjetoEscuelaBase
    {
        public String CursoId { get; set; }
        public Curso Curso { get; set; }

        public List<Evaluación> Evaluaciones { get; set; }
    }
}