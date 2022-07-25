using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Core.Models;

#nullable disable

namespace Core.Context
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblJob> TblJobs { get; set; }
        public virtual DbSet<TblRegion> TblRegions { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=DB_Employee;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__tbl_Depa__B2079BCDFEEE2B74");

                entity.ToTable("tbl_Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__tbl_Empl__7AD04FF113100A8F");

                entity.ToTable("tbl_Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FirstName).HasMaxLength(40);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LastName).HasMaxLength(40);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_tbl_Employee_tbl_Department");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK__tbl_Emplo__Regio__2C3393D0");
            });

            modelBuilder.Entity<TblJob>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK__tbl_Job__056690E219D6DC45");

                entity.ToTable("tbl_Job");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.JobDescription).HasMaxLength(70);

                entity.Property(e => e.JobTitle).HasMaxLength(60);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblJobs)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_tbl_Job_tbl_Department");
            });

            modelBuilder.Entity<TblRegion>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PK__tbl_Regi__ACD844430E1B47DE");

                entity.ToTable("tbl_Region");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(100);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_User__1788CCAC0A6462B9");

                entity.ToTable("tbl_User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
