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
    
    public partial class user_account
    {
        public int userAccountId { get; set; }
        public int userTypeID { get; set; }
        public string userEmail { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userPassword { get; set; }
        public string userIsActive { get; set; }
        public string userIsConfirmed { get; set; }
        public byte[] userImage { get; set; }
        public System.DateTime userRegistrationDate { get; set; }
        public Nullable<System.DateTime> userBday { get; set; }
        public string userPhone { get; set; }
        public string userAddress { get; set; }
        public string resetPasswordCode { get; set; }
        public string mailActivationCode { get; set; }
    
        public virtual job_post_activity job_post_activity { get; set; }
        public virtual user_type user_type { get; set; }
        public virtual user_education user_education { get; set; }
        public virtual user_experinence_detail user_experinence_detail { get; set; }
        public virtual user_language_skill user_language_skill { get; set; }
        public virtual user_log user_log { get; set; }
        public virtual user_student user_student { get; set; }
        public virtual user_teacher user_teacher { get; set; }
    }
}
