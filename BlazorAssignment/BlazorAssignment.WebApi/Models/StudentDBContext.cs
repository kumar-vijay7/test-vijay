using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorAssignment.Library.Models.entityModels
{
    public partial class StudentDBContext : DbContext
    {
        public StudentDBContext()
        {
        }

        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblLogin> TblLogin { get; set; }
        public virtual DbSet<TblNavData> TblNavData { get; set; }
        public virtual DbSet<TblStudent> TblStudent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=StudentDB;user id=sa;password=Vijay@6342#_;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK__TblLogin__4DDA2838E35405EF");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNavData>(entity =>
            {
                entity.HasKey(e => e.NavId)
                    .HasName("PK__TblNavDa__67283A734AEB6098");

                entity.Property(e => e.NavId).HasColumnName("NavID");

                entity.Property(e => e.NavLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NavMenuName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__TblStude__32C52A79B51C1FB3");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentAddress).IsUnicode(false);

                entity.Property(e => e.StudentCourse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StudentEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StudentGender)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StudentPhone)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
