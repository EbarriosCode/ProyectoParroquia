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

        public string NombreCompleto()
        {
            return $"{Nombres} {Apellidos}";
        }
    }
}
