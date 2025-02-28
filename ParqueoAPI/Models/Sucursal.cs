using System.ComponentModel.DataAnnotations;

namespace ParqueoAPI.Models
{
    public class Sucursal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Administrador { get; set; }

        public int NumeroEspacios { get; set; }
    }
}
