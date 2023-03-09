using System;
using System.Collections.Generic;

namespace Final_Claim_Ass.Db
{
    public partial class RoleTable
    {
        public RoleTable()
        {
            Accountants = new HashSet<Accountant>();
            Administrators = new HashSet<Administrator>();
            Employees = new HashSet<Employee>();
            Managers = new HashSet<Manager>();
        }

        public string RoleId { get; set; } = null!;
        public string? RoleName { get; set; }

        public virtual ICollection<Accountant> Accountants { get; set; }
        public virtual ICollection<Administrator> Administrators { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
    }
}
