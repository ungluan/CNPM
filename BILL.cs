//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestPT
{
    using System;
    using System.Collections.Generic;
    
    public partial class BILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL()
        {
            this.PARTICULARSERVICEs = new HashSet<PARTICULARSERVICE>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IDRoom { get; set; }
        public string IDStaff { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> Paid { get; set; }
    
        public virtual MOTELROOM MOTELROOM { get; set; }
        public virtual STAFF STAFF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTICULARSERVICE> PARTICULARSERVICEs { get; set; }
    }
}
