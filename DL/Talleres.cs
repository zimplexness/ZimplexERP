//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Talleres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Talleres()
        {
            this.Mantenimiento = new HashSet<Mantenimiento>();
        }
    
        public int IDTalleres { get; set; }
        public string NombreTaller { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> IDLocalidad { get; set; }
        public string TelefonoCotacto { get; set; }
        public string NombreEncargado { get; set; }
        public Nullable<int> IdTipoTaller { get; set; }
    
        public virtual Localidades Localidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mantenimiento> Mantenimiento { get; set; }
        public virtual TipoTaller TipoTaller { get; set; }
    }
}
