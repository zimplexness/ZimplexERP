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
    
    public partial class ProductoresSeguro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductoresSeguro()
        {
            this.DetalleProveedor_ProductorSeguro = new HashSet<DetalleProveedor_ProductorSeguro>();
        }
    
        public int IdProductorSeguro { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleProveedor_ProductorSeguro> DetalleProveedor_ProductorSeguro { get; set; }
    }
}
