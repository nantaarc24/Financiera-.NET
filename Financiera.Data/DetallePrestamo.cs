//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Financiera.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetallePrestamo
    {
        public int Id { get; set; }
        public Nullable<int> IdPrestamo { get; set; }
        public Nullable<int> Cuota { get; set; }
        public Nullable<decimal> Monto { get; set; }
    
        public virtual Prestamo Prestamo { get; set; }
    }
}
