﻿using System;
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

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(50,ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Libro { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Folio { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Partida { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string NombreBautizado { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string PadresBautizado { get; set; }
        
        //public string RealizadoPor { get; set; }
        [Display(Name = "Realizado Por")]
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public int SacerdoteId { get; set; }

        [Display(Name = "Departamento")]
        public int DepartamentoId { get; set; }

        [Display(Name = "Municipio")]          
        public int? MunicipioId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Date)]
        public DateTime FechaBautismo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Padrino { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Madrina { get; set; }

        [DataType(DataType.MultilineText)]
        public string Observaciones { get; set; }

        public Sacerdote Sacerdote { get; set; }
        public Departamento Departamento { get; set; }
        public Municipio Municipio { get; set; }
    }
}
