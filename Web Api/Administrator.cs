using System;
using System.Collections.Generic;

namespace Final_Claim_Ass.Db
{
    public partial class Administrator
    {
        public int A_Identity { get; set; }
        public string Administrator_Id { get; set; } = null!;
        public string? Role_Id { get; set; }
        public string? Administrator_Name { get; set; }
        public string? Administrator_Email { get; set; }
        public string? Administrator_Password { get; set; }
        public byte[]? Administrator_Image { get; set; }

        public virtual RoleTable? Role { get; set; }
    }
}
