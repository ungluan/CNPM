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
    
    public partial class PARTICULARSERVICE
    {
        public int IDBill { get; set; }
        public int IDService { get; set; }
        public Nullable<int> OldIndex { get; set; }
        public Nullable<int> NewIndex { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual BILL BILL { get; set; }
        public virtual SERVICE SERVICE { get; set; }
    }
}
