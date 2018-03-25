using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Domain
{
    [Table("Sacerdote")]
    public class Sacerdote
    {
        [Key]
        public int SacerdoteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        [Display(Name ="Puesto")]
        public int PuestoSacerdoteId { get; set; }

        [Display(Name ="Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name ="Fecha de Llegada a la Parroquia")]
        public DateTime FechaLlegadaParroquia { get; set; }
        [Display(Name = "Fecha en que se retiró de la Parroquia")]
        public DateTime FechaRetiradaParroquia { get; set; }
        public bool Activo { get; set; }

        [NotMapped]
        public int Edad { get { return DateTime.Now.Year - FechaNacimiento.Year; } }

        public string NombreCompleto()
        {
            return $"{Nombres} {Apellidos}";
        }

        public List<Bautismo> Bautismo { get; set; }
        public PuestoSacerdote PuestoSacerdote { get; set; }
    }
}
