using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FaceRecognition.Models;

public partial class ClassAttendanceContext : DbContext
{
    public ClassAttendanceContext()
    {
    }

    public ClassAttendanceContext(DbContextOptions<ClassAttendanceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<AttendanceItem> AttendanceItems { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-IGPIN4U\\MSSQLSERVER01;Database=ClassAttendance;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.ToTable("Attendance");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Note).HasMaxLength(500);
        });

        modelBuilder.Entity<AttendanceItem>(entity =>
        {
            entity.ToTable("AttendanceItem");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
