//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appdll.context
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Users
    {
        public int UserId { get; set; }
        public Nullable<int> RoleId_Fk { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string LastLogin { get; set; }
    
        public virtual TB_Roles TB_Roles { get; set; }
    }
}
