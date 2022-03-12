using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mvc_core.Data;

namespace mvc_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*public IActionResult EditarCliente(int id)
        {
           Index modelo = _context.Index.Where(c => c.Id == id).FirstOrDefault();
           return View("EditarCliente", modelo);
        }*/

        //accion para guardar los datos en SqlServer
        public IActionResult CrearCliente (Index cliente)
        {
            //cliente.FechaActual = DateTime.Now;

            //_context.Index.Add(cliente);
            _context.SaveChanges();
           return RedirectToAction("");

            
        }

        //boton para eliminar datos de la tabla
        /*public IActionResult EliminarCliente (int id)
        {
            List<Infopre> infopre = _context.infopre.where(a => a.prestamoid == id).ToList();

            if (infopre != null)
                _context.RemoveRange(infopre);

            Prestamos prestamos = _context.Prestamos.where(b => b.Id == id).FirtsOrDefault();

            if (prestamos != null)
                _context.Remove(prestamos);

            _context.SaveChange();

            List<Prestamos> prestamo = _context.prestamos.ToList();


        }*/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
