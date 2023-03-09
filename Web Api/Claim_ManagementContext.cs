using System;
using System.Collections.Generic;
using Final_Claim_Ass.Db.Store_Proc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Final_Claim_Ass.Db
{
    public partial class Claim_ManagementContext : DbContext
    {
        public Claim_ManagementContext()
        {
        }

        public Claim_ManagementContext(DbContextOptions<Claim_ManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accountant> Accountants { get; set; } = null!;
        public virtual DbSet<AccountantClaim> AccountantClaims { get; set; } = null!;
        public virtual DbSet<Administrator> Administrators { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeClaimStatusHistory> EmployeeClaimStatusHistories { get; set; } = null!;
        public virtual DbSet<EmployeeClaimsTable> EmployeeClaimsTables { get; set; } = null!;
        public virtual DbSet<FinalBillingTable> FinalBillingTables { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<ManagerSelfClaimsTable> ManagerSelfClaimsTables { get; set; } = null!;

        public virtual DbSet<RoleTable> RoleTables { get; set; } = null!;

        public virtual DbSet<Add_New_Employee_Proc> Add_New_Employee_Procs { get; set; } = null!;
        public virtual DbSet<Add_New_Manager_Proc> Add_New_Manager_Procs { get; set; } = null!;
        public virtual DbSet<Del_Employee_Proc> Del_Employee_Procs { get; set; } = null!;
        public virtual DbSet<Show_Employee_Particular_Claim_Proc> Show_Employee_Particular_Claim_Procs { get; set; } = null!;
        public virtual DbSet<Insert_Employee_Claims_Proc> Insert_Employee_Claims_Procs { get; set; } = null!;

        public virtual DbSet<Del_Manager_Proc> Del_Manager_Procs { get; set; } = null!;
        public virtual DbSet<Insert_Manager_Self_Claims_proc> Insert_Manager_Self_Claims_Procs { get; set; } = null!;
        public virtual DbSet<Show_Employee_Claim_Manager> Show_Employee_Claim_Managers { get; set; } = null!;
        public virtual DbSet<Approve_Claim_Employee_Proc> Approve_Claim_Employee_Procs { get; set; } = null!;
        public virtual DbSet<Rejected_Claim_Employee_Proc> Rejected_Claim_Employee_Procs { get; set; } = null!;
        public virtual DbSet<Send_Back_Claim_Employee_Proc> Send_Back_Claim_Employee_Procs { get; set; } = null!;
        public virtual DbSet<Appoval_By_Accountant_Proc> Appoval_By_Accountant_Procs { get; set; } = null!;
        public virtual DbSet<Rejected_By_Accountant_Proc> Rejected_By_Accountant_Procs { get; set; } = null!;
        public virtual DbSet<Send_Back_By_Accountant_Proc> Send_Back_By_Accountant_Procs { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=Aryan\\SQLEXPRESS;Database=Claim_Management;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accountant>(entity =>
            {
                entity.ToTable("Accountant");

                entity.Property(e => e.Accountant_Id)
                    .HasMaxLength(9)
                    .ValueGeneratedOnAdd()
                    .IsUnicode(false)
                    .HasColumnName("Accountant_Id")
                    .HasComputedColumnSql("('VITO'+right('0$AC'+CONVERT([varchar](5),[A_identity]),(5)))", true);

                entity.Property(e => e.A_Identity)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("A_identity");

                entity.Property(e => e.Accountant_Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Accountant_Email");

                entity.Property(e => e.Accountant_Image)
                    .HasColumnType("image")
                    .HasColumnName("Accountant_Image");

                entity.Property(e => e.Accountant_Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Accountant_Name");

                entity.Property(e => e.Accountant_Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Accountant_Password");

                entity.Property(e => e.Role_Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Role_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accountants)
                    .HasForeignKey(d => d.Role_Id)
                    .HasConstraintName("FK__Accountan__Role___3E52440B");
            });

            modelBuilder.Entity<AccountantClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimsNoId)
                    .HasName("PK__Accounta__2A7A65638CD190BF");

                entity.ToTable("Accountant_Claims");

                entity.Property(e => e.ClaimsNoId).HasColumnName("Claims_No_Id");

                entity.Property(e => e.DestinationLocation)
                    .IsUnicode(false)
                    .HasColumnName("Destination_Location");

                entity.Property(e => e.DistanceKms).HasColumnName("Distance_Kms");

                entity.Property(e => e.EmployeeClaimsProof)
                    .HasColumnType("image")
                    .HasColumnName("Employee_Claims_Proof");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("From_Date");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Id");

                entity.Property(e => e.Purpose).IsUnicode(false);

                entity.Property(e => e.Rupees).HasColumnType("money");

                entity.Property(e => e.SourceLocation)
                    .IsUnicode(false)
                    .HasColumnName("Source_Location");

                entity.Property(e => e.StatusOfClaims)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Status_Of_Claims");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("To_date");

                entity.Property(e => e.TravelBy)
                    .IsUnicode(false)
                    .HasColumnName("Travel_By");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.AccountantClaims)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Accountan__Manag__59FA5E80");
            });

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.ToTable("Administrator");

                entity.Property(e => e.Administrator_Id)
                    .HasMaxLength(9)
                    .ValueGeneratedOnAdd()
                    .IsUnicode(false)
                    .HasColumnName("Administrator_Id")
                    .HasComputedColumnSql("('VITO'+right('0$AD'+CONVERT([varchar](5),[A_identity]),(5)))", true);

                entity.Property(e => e.A_Identity)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("A_identity");

                entity.Property(e => e.Administrator_Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Administrator_Email");

                entity.Property(e => e.Administrator_Image)
                    .HasColumnType("image")
                    .HasColumnName("Administrator_Image");

                entity.Property(e => e.Administrator_Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Administrator_Name");

                entity.Property(e => e.Administrator_Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Administrator_Password");

                entity.Property(e => e.Role_Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Role_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Administrators)
                    .HasForeignKey(d => d.Role_Id)
                    .HasConstraintName("FK__Administr__Role___440B1D61");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Department_Name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Employee_Id)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Id")
                    .ValueGeneratedOnAdd()
                    .HasComputedColumnSql("('VITO'+right('0$EM'+CONVERT([varchar](5),[E_identity]),(5)))", true);

                entity.Property(e => e.E_Identity)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("E_identity");

                entity.Property(e => e.Employee_AccountNo)
                    .HasMaxLength(50)
                    .HasColumnName("Employee_Account_No");

                entity.Property(e => e.Employee_Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Address");

                entity.Property(e => e.Employee_Bank)
                    .HasMaxLength(20)
                    .HasColumnName("Employee_Bank");

                entity.Property(e => e.Employee_Contact)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("Employee_Contact");

                entity.Property(e => e.Employee_Country)
                    .HasMaxLength(20)
                    .HasColumnName("Employee_Country");

                entity.Property(e => e.Employee_Department)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Department");

                entity.Property(e => e.Employee_Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("Employee_Dob");

                entity.Property(e => e.Employee_Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Email");

                entity.Property(e => e.Employee_Fname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Employee_FName");

                entity.Property(e => e.Employee_Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Gender");

                entity.Property(e => e.Employee_Image)
                    .HasColumnType("image")
                    .HasColumnName("Employee_Image");

                entity.Property(e => e.Employee_Lname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Employee_LName");

                entity.Property(e => e.Employee_Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Password");

                entity.Property(e => e.Employee_Qualification)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Qualification");

                entity.Property(e => e.Employee_Sal)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("Employee_Sal");

                entity.Property(e => e.Employee_State)
                    .HasMaxLength(20)
                    .HasColumnName("Employee_State");

                entity.Property(e => e.Employee_Zipcode)
                    .HasMaxLength(20)
                    .HasColumnName("Employee_Zipcode");

                entity.Property(e => e.Role_Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Role_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Role_Id)
                    .HasConstraintName("FK__Employee__Role_I__3A81B327");
            });

            modelBuilder.Entity<EmployeeClaimStatusHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK__Employee__A6BAB5D79110D570");

                entity.ToTable("Employee_Claim_Status_History");

                entity.Property(e => e.HistoryId).HasColumnName("History_Id");

                entity.Property(e => e.Accountant)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Approved)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimsNoId).HasColumnName("Claims_No_Id");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.Manager)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Id");

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.Rejected)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SendBack)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Send_Back");

                entity.HasOne(d => d.ClaimsNo)
                    .WithMany(p => p.EmployeeClaimStatusHistories)
                    .HasForeignKey(d => d.ClaimsNoId)
                    .HasConstraintName("FK__Employee___Claim__5535A963");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeClaimStatusHistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Employee___Emplo__571DF1D5");

                entity.HasOne(d => d.ManagerNavigation)
                    .WithMany(p => p.EmployeeClaimStatusHistories)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Employee___Manag__5629CD9C");
            });

            modelBuilder.Entity<EmployeeClaimsTable>(entity =>
            {
                entity.HasKey(e => e.ClaimsNoId)
                    .HasName("PK__Employee__2A7A656394B0BCFC");

                entity.ToTable("Employee_Claims_Table");

                entity.Property(e => e.ClaimsNoId).HasColumnName("Claims_No_Id");

                entity.Property(e => e.DestinationLocation)
                    .IsUnicode(false)
                    .HasColumnName("Destination_Location");

                entity.Property(e => e.DistanceKms).HasColumnName("Distance_Kms");

                entity.Property(e => e.EmployeeClaimsProof)
                    .HasColumnType("image")
                    .HasColumnName("Employee_Claims_Proof");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("From_Date");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Id");

                entity.Property(e => e.Purpose).IsUnicode(false);

                entity.Property(e => e.Rupees).HasColumnType("money");

                entity.Property(e => e.SourceLocation)
                    .IsUnicode(false)
                    .HasColumnName("Source_Location");

                entity.Property(e => e.StatusOfClaims)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Status_Of_Claims");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("To_date");

                entity.Property(e => e.TravelBy)
                    .IsUnicode(false)
                    .HasColumnName("Travel_By");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeClaimsTables)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Employee___Emplo__49C3F6B7");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.EmployeeClaimsTables)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Employee___Manag__48CFD27E");
            });

            modelBuilder.Entity<FinalBillingTable>(entity =>
            {
                entity.HasKey(e => e.BillingId)
                    .HasName("PK__Final_Bi__3767155F32A39552");

                entity.ToTable("Final_Billing_Table");

                entity.Property(e => e.BillingId).HasColumnName("Billing_Id");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(100)
                    .HasColumnName("Bank_Account_No");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .HasColumnName("Bank_Name");

                entity.Property(e => e.ClaimsNoId).HasColumnName("Claims_No_Id");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Id");

                entity.Property(e => e.Rupees).HasColumnType("money");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.Property(e => e.Manager_Id)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Manager_Id")
                    .HasComputedColumnSql("('VITO'+right('0$MG'+CONVERT([varchar](5),[M_identity]),(5)))", true);

                entity.Property(e => e.M_Identity)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("M_identity");

                entity.Property(e => e.Manager_AccountNo)
                    .HasMaxLength(50)
                    .HasColumnName("Manager_Account_No");

                entity.Property(e => e.Manager_Bank)
                    .HasMaxLength(20)
                    .HasColumnName("Manager_Bank");

                entity.Property(e => e.Manager_Contact)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("Manager_Contact");

                entity.Property(e => e.Manager_Department)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Department");

                entity.Property(e => e.Manager_Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("Manager_Dob");

                entity.Property(e => e.Manager_Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Email");

                entity.Property(e => e.Manager_Fname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Manager__FName");

                entity.Property(e => e.Manager_Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Gender");

                entity.Property(e => e.Manager_Image)
                    .HasColumnType("image")
                    .HasColumnName("Manager_Image");

                entity.Property(e => e.Manager_Lname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Manager__LName");

                entity.Property(e => e.Manager_Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Password");

                entity.Property(e => e.Manager_Sal)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("Manager__Sal");

                entity.Property(e => e.Role_Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Role_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.Role_Id)
                    .HasConstraintName("FK__Manager__Role_Id__412EB0B6");
            });

            modelBuilder.Entity<ManagerSelfClaimsTable>(entity =>
            {
                entity.HasKey(e => e.ClaimsNoId)
                    .HasName("PK__Manager___2A7A6563528D96E2");

                entity.ToTable("Manager_Self_Claims_Table");

                entity.Property(e => e.ClaimsNoId).HasColumnName("Claims_No_Id");

                entity.Property(e => e.DestinationLocation)
                    .IsUnicode(false)
                    .HasColumnName("Destination_Location");

                entity.Property(e => e.DistanceKms).HasColumnName("Distance_Kms");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("From_Date");

                entity.Property(e => e.ManagerClaimsProff)
                    .HasColumnType("image")
                    .HasColumnName("Manager_Claims_Proff");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Manager_Id");

                entity.Property(e => e.Purpose).IsUnicode(false);

                entity.Property(e => e.Rupees).HasColumnType("money");

                entity.Property(e => e.SourceLocation)
                    .IsUnicode(false)
                    .HasColumnName("Source_Location");

                entity.Property(e => e.StatusOfClaims)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Status_Of_Claims");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("To_date");

                entity.Property(e => e.TravelBy)
                    .IsUnicode(false)
                    .HasColumnName("Travel_By");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ManagerSelfClaimsTables)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Manager_S__Manag__4D94879B");
            });

            modelBuilder.Entity<RoleTable>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Role_Tab__D80AB4BBBA3FA844");

                entity.ToTable("Role_Table");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Role_Id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Role_Name");
            });

            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<Show_All_Employee>().HasNoKey();
            modelBuilder.Entity<Add_New_Employee_Proc>().HasNoKey();
            modelBuilder.Entity<Del_Employee_Proc>().HasNoKey();
            modelBuilder.Entity<Show_Employee_Particular_Claim_Proc>().HasNoKey();
            modelBuilder.Entity<Insert_Employee_Claims_Proc>().HasNoKey();
            modelBuilder.Entity<Add_New_Manager_Proc>().HasNoKey();
            modelBuilder.Entity<Del_Manager_Proc>().HasNoKey();
            modelBuilder.Entity<Insert_Manager_Self_Claims_proc>().HasNoKey();
            modelBuilder.Entity<Show_Employee_Claim_Manager>().HasNoKey();
            modelBuilder.Entity<Approve_Claim_Employee_Proc>().HasNoKey();
            modelBuilder.Entity<Rejected_Claim_Employee_Proc>().HasNoKey();
            modelBuilder.Entity<Send_Back_Claim_Employee_Proc>().HasNoKey();
            modelBuilder.Entity<Appoval_By_Accountant_Proc>().HasNoKey();
            modelBuilder.Entity<Rejected_By_Accountant_Proc>().HasNoKey();
            modelBuilder.Entity<Send_Back_By_Accountant_Proc>().HasNoKey();
            
            modelBuilder.Entity<Accountant>().HasNoKey();

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
