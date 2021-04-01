using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using MvcWebTest.Util;

namespace MvcWebTest.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "* Nombre es requerid(a)")]
        [StringLength(5)]
        public override string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        
        [Required(ErrorMessage = "* Dirección es requerid(a)")]
        [MinLength(10, ErrorMessage = "* Dirección  debe ser mayor a 10 caracteres")]
        public string Dirección { get; set; }

        public String EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
    }
}