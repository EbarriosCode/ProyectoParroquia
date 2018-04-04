using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Models.Domain;

namespace ViewModels.Domain
{
    public class BautismoViewModel
    {
        #region Listas para los combos de la vista Create Bautismo
        public List<Sacerdote> Sacerdotes { get; set; }
        public List<Departamento> Departamentos { get; set; }
        public List<Municipio> Municipios { get; set; }
        #endregion

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Libro { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Folio { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string Partida { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string NombresBautizado { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string ApellidosBautizado { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "La longitud válida para este campo es de {0} caracteres")]
        public string PadresBautizado { get; set; }

        //public string RealizadoPor { get; set; }
        [Display(Name = "Realizado Por")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
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
    }
}
