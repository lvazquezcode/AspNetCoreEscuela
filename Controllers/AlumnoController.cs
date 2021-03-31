using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcWebTest.Context;
using MvcWebTest.Models;

namespace MvcWebTest.Controllers
{
    public class AlumnoController : Controller
    {
        [Route("Alumno/Index/")]
        [Route("Alumno/Index/{alumnoId}")]
        public IActionResult Index(String alumnoId)
        {
            if (!string.IsNullOrWhiteSpace(alumnoId))
            {
                var alumno = from a in _context.Alumnos
                             where a.Id == alumnoId
                             select a;

                return View(alumno.FirstOrDefault());
            }
            else
            {
                return View("ListaAlumnos", _context.Alumnos);
            }
        }
        public IActionResult ListaAlumnos()
        {
            ViewBag.SendDataForm = "Test";
            ViewBag.Fecha = DateTime.Now;

            return View(_context.Alumnos);
        }

        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}