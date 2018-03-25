using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Domain
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }

        [Display(Name = "Departamento")]
        public string NombreDepartamento { get; set; }

        public List<Bautismo> Bautismo { get; set; }
        public List<Municipio> Municipio { get; set; }
    }
}
