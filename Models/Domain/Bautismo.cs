using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Domain
{
    [Table("Bautismo")]
    public class Bautismo
    {
        [Key]
        public int BautismoId { get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public string Partida { get; set; }
        public string NombreBautizado { get; set; }
        public string PadresBautizado { get; set; }
        
        //public string RealizadoPor { get; set; }
        [Display(Name = "Realizado Por")]
        public int SacerdoteId { get; set; }

        [Display(Name = "Departamento")]
        public int DepartamentoId { get; set; }

        [Display(Name = "Municipio")]
        public int MunicipioId { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaBautismo { get; set; }
        public string Padrino { get; set; }
        public string Madrina { get; set; }

        public string Observaciones { get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
