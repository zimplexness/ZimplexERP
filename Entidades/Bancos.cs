//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bancos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bancos()
        {
            this.DetalleMediosPagos = new HashSet<DetalleMediosPagos>();
        }
    
        public int IdBanco { get; set; }
        public string Nombre { get; set; }
        public string Sucursal { get; set; }
        public string TipoCuenta { get; set; }
        public string Numero { get; set; }
        public string CBU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleMediosPagos> DetalleMediosPagos { get; set; }
    }
}
