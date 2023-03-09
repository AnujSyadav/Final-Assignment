namespace Final_Claim_Ass.Db.Store_Proc
{
    public class Insert_Manager_Self_Claims_proc
    {
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
    }
}
