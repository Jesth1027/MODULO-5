//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROYECTO_WEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.asign_cheque_cp = new HashSet<asign_cheque_cp>();
            this.desposito = new HashSet<desposito>();
            this.mov_factura_credito = new HashSet<mov_factura_credito>();
            this.mov_factura_pagos = new HashSet<mov_factura_pagos>();
            this.mov_trasf_cuenta = new HashSet<mov_trasf_cuenta>();
            this.nota_debito_cc = new HashSet<nota_debito_cc>();
            this.nota_debito_cp = new HashSet<nota_debito_cp>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string usuario1 { get; set; }
        public string password { get; set; }
        public string puesto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asign_cheque_cp> asign_cheque_cp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<desposito> desposito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mov_factura_credito> mov_factura_credito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mov_factura_pagos> mov_factura_pagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mov_trasf_cuenta> mov_trasf_cuenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nota_debito_cc> nota_debito_cc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nota_debito_cp> nota_debito_cp { get; set; }
    }
}
