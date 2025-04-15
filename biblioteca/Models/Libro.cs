using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblioteca.Models
{
    public class Libro
    {
        public int LibroID { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Categoria { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Autor { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Pais { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? FechaPublicacion { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Editorial { get; set; }
    }
}
