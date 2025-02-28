using System.ComponentModel.DataAnnotations;

namespace ParqueoAPI.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int EspacioParqueoId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int CantidadHoras { get; set; }
    }
}
