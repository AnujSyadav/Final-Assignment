using System;
using System.Collections.Generic;

namespace Final_Claim_Ass.Db
{
    public partial class EmployeeClaimStatusHistory
    {
        public int HistoryId { get; set; }
        public int? ClaimsNoId { get; set; }
        public string? ManagerId { get; set; }
        public string? EmployeeId { get; set; }
        public string? Accountant { get; set; }
        public string? Manager { get; set; }
        public string? Approved { get; set; }
        public string? Rejected { get; set; }
        public string? SendBack { get; set; }
        public string? Reason { get; set; }

        public virtual EmployeeClaimsTable? ClaimsNo { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual Manager? ManagerNavigation { get; set; }
    }
}
