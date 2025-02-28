using System.ComponentModel.DataAnnotations;

namespace ParqueoAPI.Models
{
    public class EspacioParqueo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        [Required]
        public decimal CostoPorHora { get; set; }

        [Required]
        public string Estado { get; set; } // Disponible u Ocupado

        public int SucursalId { get; set; }
    }
}
