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

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<LabelStudent> LabelStudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=DESKTOP-IGPIN4U\\MSSQLSERVER01;Database=ClassAttendance;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
