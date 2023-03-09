using System;
using System.Collections.Generic;

namespace Final_Claim_Ass.Db
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeClaimStatusHistories = new HashSet<EmployeeClaimStatusHistory>();
            EmployeeClaimsTables = new HashSet<EmployeeClaimsTable>();
        }

        public int E_Identity { get; set; }
        public string Employee_Id { get; set; } = null!;
        public string? Role_Id { get; set; }
        public string? Employee_Fname { get; set; }
        public string? Employee_Lname { get; set; }
        public decimal? Employee_Sal { get; set; }
        public string? Employee_Qualification { get; set; }
        public string? Employee_Address { get; set; }
        public string? Employee_State { get; set; }
        public string? Employee_Country { get; set; }
        public string? Employee_Zipcode { get; set; }
        public decimal? Employee_Contact { get; set; }
        public DateTime? Employee_Dob { get; set; }
        public string? Employee_Gender { get; set; }
        public string? Employee_Bank { get; set; }
        public string? Employee_AccountNo { get; set; }
        public string? Employee_Department { get; set; }
        public string? Employee_Email { get; set; }
        public string? Employee_Password { get; set; }
        public byte[]? Employee_Image { get; set; }

        public virtual RoleTable? Role { get; set; }
        public virtual ICollection<EmployeeClaimStatusHistory> EmployeeClaimStatusHistories { get; set; }
        public virtual ICollection<EmployeeClaimsTable> EmployeeClaimsTables { get; set; }
    }
}
