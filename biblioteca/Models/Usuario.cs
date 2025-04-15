using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblioteca.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(8)")]
        public string DNI { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Nombres { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Apellidos { get; set; }
        
        [Required, EmailAddress]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Telefono { get; set; }

        [Required]
        public string TipoUsuario { get; set; } // "Docente" | "Alumno"
        public bool Estado { get; set; } = true; // true = Habilitado | false = Sancionado
    }
}
