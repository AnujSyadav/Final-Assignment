namespace Final_Claim_Ass.Db.Store_Proc
{
    public class Show_All_Employee
    {
        public int EIdentity { get; set; }
        public string EmployeeId { get; set; } = null!;
        public string? RoleId { get; set; }
        public string? EmployeeFname { get; set; }
        public string? EmployeeLname { get; set; }
        public decimal? EmployeeSal { get; set; }
        public string? EmployeeQualification { get; set; }
        public string? EmployeeAddress { get; set; }
        public string? EmployeeState { get; set; }
        public string? EmployeeCountry { get; set; }
        public string? EmployeeZipcode { get; set; }
        public decimal? EmployeeContact { get; set; }
        public DateTime? EmployeeDob { get; set; }
        public string? EmployeeGender { get; set; }
        public string? EmployeeBank { get; set; }
        public string? EmployeeAccountNo { get; set; }
        public string? EmployeeDepartment { get; set; }
        public string? EmployeeEmail { get; set; }
        public string? EmployeePassword { get; set; }
        public byte[]? EmployeeImage { get; set; }

    }
}
