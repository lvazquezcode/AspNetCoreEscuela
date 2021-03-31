using System;
using MvcWebTest.Models;
using Microsoft.AspNetCore.Mvc;
using MvcWebTest.Context;
using System.Linq;

namespace MvcWebTest.Controllers
{
    public class EscuelaController : Controller
    {

        public IActionResult Index()
        {
            var escuela = _context.Escuelas.FirstOrDefault();

            ViewBag.SendDataForm = "Escuela Test";

            return View(escuela);

        }

        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}