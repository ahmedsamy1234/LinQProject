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
    
    public partial class Person
    {
        public int SSN { get; set; }
        public string Name_person { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string fax { get; set; }
        public string phone { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
