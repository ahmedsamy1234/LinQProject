//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinQFinalProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permit()
        {
            this.permission_item = new HashSet<permission_item>();
        }
    
        public int id { get; set; }
        public string TypeOfPermision { get; set; }
        public string warehouse_fk { get; set; }
        public string Quantity { get; set; }
        public Nullable<int> SSN_supplier { get; set; }
        public Nullable<int> SSN_Client { get; set; }
        public Nullable<System.DateTime> DateOFOperation { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permission_item> permission_item { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual warehouse warehouse { get; set; }
    }
}
