//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyTable
    {
        public int CompanyID { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }
        public string ContactNo { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
    
        public virtual UserTable UserTable { get; set; }
    }
}
