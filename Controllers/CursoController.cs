using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcWebTest.Context;
using MvcWebTest.Models;

namespace MvcWebTest.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index(String id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var curso = from c in _context.Cursos
                             where c.Id == id
                             select c;

                return View(curso.FirstOrDefault());                
            }
            else
            {
                return View("ListaCursos", _context.Cursos);
            }
        }
        public IActionResult ListaCursos()
        {
            ViewBag.SendDataForm = "Test";
            ViewBag.Fecha = DateTime.Now;

            return View(_context.Cursos);
        }

        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}