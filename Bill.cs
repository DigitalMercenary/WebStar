//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebStar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int BillID { get; set; }
        public Nullable<int> DocumentTypeID { get; set; }
        public string BillName { get; set; }
        public byte[] Bill1 { get; set; }
    
        public virtual DocumentType DocumentType { get; set; }
    }
}
