using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaMGRT.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Equipos = new HashSet<Equipo>();
            Jugadores = new HashSet<Jugadore>();
        }

        public string Id { get; set; } = null!;
        [Required(ErrorMessage = "This field is required.")]
        public string? NombreEstado { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<Jugadore> Jugadores { get; set; }
    }
}
