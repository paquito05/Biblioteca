using biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace biblioteca.Controllers
{
    public class ReporteController : Controller
    {
        private readonly BibliotecaContext _context;

        public ReporteController(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var prestamos = await _context.Prestamos
           .Include(p => p.Libro)
           .Include(p => p.Usuario)
           .OrderByDescending(p => p.FechaPrestamo)
           .ToListAsync();

            return View(prestamos);
        }
    }
}
