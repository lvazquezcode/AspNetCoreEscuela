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

        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fecha = DateTime.Now;
                var escuela = _context.Escuelas.FirstOrDefault();

                curso.EscuelaId = escuela.Id;

                _context.Cursos.Add(curso);
                _context.SaveChanges();

                ViewBag.Message = "Curso Creado!";

                return View("Index", curso);
            }
            else
            {
                return View(curso);
            }
            
        }

        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}