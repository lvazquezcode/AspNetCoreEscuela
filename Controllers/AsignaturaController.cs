using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcWebTest.Context;
using MvcWebTest.Models;

namespace MvcWebTest.Controllers
{
    public class AsignaturaController : Controller
    {

        /*
        public IActionResult Index()
        {
            ViewBag.SendDataForm = "Test";
            ViewBag.Fecha = DateTime.Now;

            return View(_context.Asignaturas.FirstOrDefault());
        }
        */

        ///Sin Route
        //public IActionResult Index(String id)

        ///Con Route
        [Route("Asignatura/Index/")]
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(String asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura = from a in _context.Asignaturas
                                 where a.Id == asignaturaId
                                 select a;

                return View(asignatura.FirstOrDefault());
            }
            else
            {
                return View("ListaAsignaturas", _context.Asignaturas);
            }
        }

        public IActionResult ListaAsignaturas()
        {
            //ViewBag.SendDataForm = "Test";
            ViewBag.Fecha = DateTime.Now;

            return View("ListaAsignaturas", _context.Asignaturas);
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}