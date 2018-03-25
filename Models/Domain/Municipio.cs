using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Domain
{
    [Table("Municipio")]
    public class Municipio
    {
        [Key]
        public int MunicipioId { get; set; }

        [Display(Name = "Municipio")]
        public string NombreMunicipio { get; set; }
        public int DepartamentoId { get; set; }

        public Departamento Departamento { get; set; }
        public List<Bautismo> Bautismo { get; set; }
    }
}
