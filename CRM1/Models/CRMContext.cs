using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CRM.Models
{
    public partial class CRMContext : DbContext
    {
        public CRMContext()
        {
        }

        public CRMContext(DbContextOptions<CRMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseEnquiry> CourseEnquiries { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<ResourceEnquiry> ResourceEnquiries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TOPXD1116P;Database=CRM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId)
                    .ValueGeneratedNever()
                    .HasColumnName("courseId");

                entity.Property(e => e.CourseAvailability).HasColumnName("courseAvailability");

                entity.Property(e => e.CourseDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("courseDesc");

                entity.Property(e => e.CourseDuration).HasColumnName("courseDuration");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("courseName");

                entity.Property(e => e.CoursePrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("coursePrice");
            });

            modelBuilder.Entity<CourseEnquiry>(entity =>
            {
                entity.ToTable("courseEnquiry");

                entity.Property(e => e.CourseEnquiryId)
                    .ValueGeneratedNever()
                    .HasColumnName("courseEnquiryId");

                entity.Property(e => e.CEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cEmail");

                entity.Property(e => e.CFullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cFullName");

                entity.Property(e => e.CPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cPhoneNumber");

                entity.Property(e => e.CStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cStatus");

                entity.Property(e => e.CourseId).HasColumnName("course_Id");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qualification");

                entity.Property(e => e.TestScore).HasColumnName("testScore");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseEnquiries)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__courseEnq__cours__145C0A3F");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.ToTable("resources");

                entity.Property(e => e.ResourceId)
                    .ValueGeneratedNever()
                    .HasColumnName("resourceId");

                entity.Property(e => e.ResourceDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("resourceDesc");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resourceName");

                entity.Property(e => e.ResourcePrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("resourcePrice");
            });

            modelBuilder.Entity<ResourceEnquiry>(entity =>
            {
                entity.ToTable("resourceEnquiry");

                entity.Property(e => e.ResourceEnquiryId)
                    .ValueGeneratedNever()
                    .HasColumnName("resourceEnquiryId");

                entity.Property(e => e.REmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rEmail");

                entity.Property(e => e.RFullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rFullName");

                entity.Property(e => e.RPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("rPhoneNumber");

                entity.Property(e => e.RStatus).HasColumnName("rStatus");

                entity.Property(e => e.ResourceId).HasColumnName("resource_Id");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceEnquiries)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__resourceE__resou__1A14E395");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
