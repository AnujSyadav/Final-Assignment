namespace Final_Claim_Ass.Db.Store_Proc
{
    public class Show_Employee_Particular_Claim_Proc
    {
        public int Claims_No_Id { get; set; }
        public string? Manager_Id { get; set; }
        public string? Employee_Id { get; set; }
        public string? Source_Location { get; set; }
        public string? Destination_Location { get; set; }
        public string? Purpose { get; set; }
        public int? Distance_Kms { get; set; }
        public decimal? Rupees { get; set; }
        public string? Travel_By { get; set; }
        public DateTime? From_Date { get; set; }
        public DateTime? To_Date { get; set; }
        public string? Status_Of_Claims { get; set; }
        public byte[]? Employee_Claims_Proof { get; set; }
    }
}
