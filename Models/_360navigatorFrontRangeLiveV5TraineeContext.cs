using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentCRUDOpretions_API.Models;

public partial class _360navigatorFrontRangeLiveV5TraineeContext : DbContext
{
    public _360navigatorFrontRangeLiveV5TraineeContext()
    {
    }

    public _360navigatorFrontRangeLiveV5TraineeContext(DbContextOptions<_360navigatorFrontRangeLiveV5TraineeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblstudentsDatum> TblstudentsData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.2.47;Database=360Navigator_FrontRange_Live_V5_Trainee;User Id=NehaGonde;Password=123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblstudentsDatum>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__tblstude__32C52B99081EBE34");

            entity.ToTable("tblstudents_data", tb =>
                {
                    tb.HasTrigger("trg_afterinsert");
                    tb.HasTrigger("trg_afterupdate");
                    tb.HasTrigger("trgafterdelete");
                });

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grade)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
