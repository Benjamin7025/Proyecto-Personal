using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaMGRT.Models
{
    public partial class Jugadore
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field Is Required.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "This Field Is Required.")]
        public string? Apellido { get; set; }
        [Required(ErrorMessage = "This Field Is Required.")]
        public DateTime? FechaNacimiento { get; set; }
        [Required(ErrorMessage = "This Field Is Required.")]
        public string? Pasaporte { get; set; }
        [Required(ErrorMessage = "This Field Is Required.")]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = "This Field Is Required.")]
        public string? Sexo { get; set; }
        [Required(ErrorMessage = "This Field Is Required.")]
        public int? IdEquipo { get; set; }
        [Required(ErrorMessage = "This Field Is Required.")]
        public string? EstadoId { get; set; }

        public virtual Estado? Estado { get; set; }
        public virtual Equipo? IdEquipoNavigation { get; set; }
    }
}
