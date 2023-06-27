using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClientesApp.Models
{
    public class Cliente
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string direccion { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string telefono { get; set; }

        [Required]
        public DateTime fechaNacimiento { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string estado { get; set; }
    }


}
