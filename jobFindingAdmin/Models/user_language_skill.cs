//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jobFindingAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_language_skill
    {
        public int userAccountID { get; set; }
        public int languageID { get; set; }
        public string level { get; set; }
    
        public virtual languages languages { get; set; }
        public virtual user_account user_account { get; set; }
    }
}