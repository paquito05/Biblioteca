using biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace biblioteca.Controllers
{
    public class PrestamosController : Controller
    {

        private readonly BibliotecaContext _context;

        public PrestamosController(BibliotecaContext context)
        {

            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            ViewBag.Usuarios = await _context.Usuarios.Where(u => u.Estado).ToListAsync();
            ViewBag.Libros = await _context.Libros.ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int usuarioId, int libroId, string tipoPrestamo)
        {
            // Validar si ya realizo 3 prestamos 
            var prestamosHoy = await _context.Prestamos
                .CountAsync(p => p.UsuarioID == usuarioId &&
                                p.FechaPrestamo.Date == DateTime.Today);

            if (prestamosHoy >= 3)
            {
                TempData["Error"] = "El usuario ya tiene 3 prestamos hoy.";
                return RedirectToAction("Index");
            }

            var prestamo = new Prestamo
            {
                UsuarioID = usuarioId,
                LibroID = libroId,
                TipoPrestamo = tipoPrestamo
            };

            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Prestamo registrado correctamente.";
            return RedirectToAction("Index");
        }

    

        
    }
}
