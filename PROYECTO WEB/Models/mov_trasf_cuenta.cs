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
    
    public partial class mov_trasf_cuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mov_trasf_cuenta()
        {
            this.saldos = new HashSet<saldos>();
        }
    
        public int correlativo { get; set; }
        public string cuenta_debito { get; set; }
        public string cuenta_destino { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> id_user { get; set; }
    
        public virtual gest_cuenta gest_cuenta { get; set; }
        public virtual gest_cuenta gest_cuenta1 { get; set; }
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<saldos> saldos { get; set; }
    }
}
