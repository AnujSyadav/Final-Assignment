using System;
using System.Collections.Generic;

namespace Final_Claim_Ass.Db
{
    public partial class FinalBillingTable
    {
        public int BillingId { get; set; }
        public int? ClaimsNoId { get; set; }
        public string? ManagerId { get; set; }
        public string? EmployeeId { get; set; }
        public decimal? Rupees { get; set; }
        public string? BankName { get; set; }
        public string? BankAccountNo { get; set; }
    }
}
