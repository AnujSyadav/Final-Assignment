namespace Final_Claim_Ass.Db.Store_Proc
{
    public class Add_New_Manager_Proc
    {
        public string? RoleId { get; set; }
        public string? ManagerFname { get; set; }
        public string? ManagerLname { get; set; }
        public decimal? ManagerSal { get; set; }
        public int? ManagerDepartment_Id { get; set; }
        public decimal? ManagerContact { get; set; }
        public DateTime? ManagerDob { get; set; }
        public string? ManagerGender { get; set; }
        public string? ManagerBank { get; set; }
        public string? ManagerAccountNo { get; set; }
        public string? ManagerEmail { get; set; }
        public string? ManagerPassword { get; set; }
        public byte[]? ManagerImage { get; set; }
    }
}
