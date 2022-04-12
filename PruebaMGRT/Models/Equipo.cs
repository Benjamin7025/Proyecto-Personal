using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaMGRT.Models
{
    public partial class Equipo
    {
        public Equipo()
        {
            Jugadores = new HashSet<Jugadore>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage= "This field is required.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string? Pais { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string? EstadoId { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string? NombreJugador { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public DateTime? FechaCreacion { get; set; }

        public virtual Estado? Estado { get; set; }
        public virtual ICollection<Jugadore> Jugadores { get; set; }
    }
}
