using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Constancias
{
    public class BautismoConstanciaViewModel
    {        
        public string Libro { get; set; }     
        public string Folio { get; set; }        
        public string Partida { get; set; }        
        public string NombreBautizado { get; set; }        
        public string PadresBautizado { get; set; }        
        public string RealizadoPorSacerdote { get; set; }
        public string RealizadoPorPuestoSacerdote { get; set; }
        public string FechaNacimiento { get; set; }        
        public string FechaBautismo { get; set; }
        public string FechaConstancia { get; set; }        
        public string PadrinosBautizado { get; set; }                
        public string Observaciones { get; set; }
    }
}
