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
    
    public partial class USER
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> IDRole { get; set; }
    
        public virtual ROLE ROLE { get; set; }
    }
}
