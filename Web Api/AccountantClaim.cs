using System;
using System.Collections.Generic;

namespace Final_Claim_Ass.Db
{
    public partial class AccountantClaim
    {
        public int ClaimsNoId { get; set; }
        public string? ManagerId { get; set; }
        public string? EmployeeId { get; set; }
        public string? SourceLocation { get; set; }
        public string? DestinationLocation { get; set; }
        public string? Purpose { get; set; }
        public int? DistanceKms { get; set; }
        public decimal? Rupees { get; set; }
        public string? TravelBy { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? StatusOfClaims { get; set; }
        public byte[]? EmployeeClaimsProof { get; set; }

        public virtual Manager? Manager { get; set; }
    }
}
