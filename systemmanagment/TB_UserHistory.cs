//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace systemmanagment
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_UserHistory
    {
        public int ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public string Status { get; set; }
        public string date { get; set; }
    
        public virtual TB_Users TB_Users { get; set; }
    }
}