//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Corredor
    {
        public int Folio { get; set; }
        public string Nombres { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public string Talla { get; set; }
        public int IdCarrera { get; set; }
    
        public virtual Carrera Carrera { get; set; }
    }
}
