namespace Final_Claim_Ass.Db.Store_Proc
{
    public class Rejected_By_Accountant_Proc
    {
        public int Claims_No_Id { get; set; }
        public string? ManagerId { get; set; }

        public string? EmployeeId { get; set; }
        public string? Reason { get; set;}
    }
}
