using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Domain
{
    [Table("PuestoSacerdote")]
    public class PuestoSacerdote
    {
        [Key]
        public int PuestoSacerdoteId { get; set; }
        public string NombrePuesto { get; set; }

        public List<Sacerdote> Sacerdote { get; set; }
    }
}
