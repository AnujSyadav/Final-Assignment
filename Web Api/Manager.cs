using System;
using System.Collections.Generic;

namespace Final_Claim_Ass.Db
{
    public partial class Manager
    {
        public Manager()
        {
            AccountantClaims = new HashSet<AccountantClaim>();
            EmployeeClaimStatusHistories = new HashSet<EmployeeClaimStatusHistory>();
            EmployeeClaimsTables = new HashSet<EmployeeClaimsTable>();
            ManagerSelfClaimsTables = new HashSet<ManagerSelfClaimsTable>();
        }

        public int M_Identity { get; set; }
        public string Manager_Id { get; set; } = null!;
        public string? Role_Id { get; set; }
        public string? Manager_Fname { get; set; }
        public string? Manager_Lname { get; set; }
        public decimal? Manager_Sal { get; set; }
        public string? Manager_Department { get; set; }
        public decimal? Manager_Contact { get; set; }
        public DateTime? Manager_Dob { get; set; }
        public string? Manager_Gender { get; set; }
        public string? Manager_Bank { get; set; }
        public string? Manager_AccountNo { get; set; }
        public string? Manager_Email { get; set; }
        public string? Manager_Password { get; set; }
        public byte[]? Manager_Image { get; set; }

        public virtual RoleTable? Role { get; set; }
        public virtual ICollection<AccountantClaim> AccountantClaims { get; set; }
        public virtual ICollection<EmployeeClaimStatusHistory> EmployeeClaimStatusHistories { get; set; }
        public virtual ICollection<EmployeeClaimsTable> EmployeeClaimsTables { get; set; }
        public virtual ICollection<ManagerSelfClaimsTable> ManagerSelfClaimsTables { get; set; }
    }
}
