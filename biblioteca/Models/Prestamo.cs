using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblioteca.Models
{
    public class Prestamo
    {
        public int PrestamoID { get; set; }
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public int LibroID { get; set; }
        public Libro Libro { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime? FechaDevolucion { get; set; }
        
        [Required]
        public string TipoPrestamo { get; set; } // "Biblioteca" | "Domicilio"
        public string Estado { get; set; } = "Activo"; // "Activo" | "Devuelto" | "Atrasado"
    }
}
