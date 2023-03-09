using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Claim_Ass.Db
{
    public partial class Accountant
    {
        public int A_Identity { get; set; }
        public string Accountant_Id { get; set; } = null!;
        public string? Role_Id { get; set; }
        public string? Accountant_Name { get; set; }
        public string? Accountant_Email { get; set; }
        public string? Accountant_Password { get; set; }
        public byte[]? Accountant_Image { get; set; }
       
        public virtual RoleTable? Role { get; set; }
    }
}
