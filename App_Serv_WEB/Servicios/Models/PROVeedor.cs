//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROVeedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVeedor()
        {
            this.COntactoPRoveedors = new HashSet<COntactoPRoveedor>();
            this.FActuraCOmpras = new HashSet<FActuraCOmpra>();
            this.PRoductoPRoveedors = new HashSet<PRoductoPRoveedor>();
        }
    
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string SitioWeb { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COntactoPRoveedor> COntactoPRoveedors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FActuraCOmpra> FActuraCOmpras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRoductoPRoveedor> PRoductoPRoveedors { get; set; }
    }
}
