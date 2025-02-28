﻿using System.ComponentModel.DataAnnotations;

namespace ParqueoAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Contraseña { get; set; }

        [Required]
        public string Rol { get; set; }  // Cliente o Empleado
    }
}
