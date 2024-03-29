using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DalTour.DalModels;

public partial class TouristContext : DbContext
{
    public TouristContext()
    {
    }

    public TouristContext(DbContextOptions<TouristContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<SitesToTrip> SitesToTrips { get; set; }

    public virtual DbSet<TravelGuide> TravelGuides { get; set; }

    public virtual DbSet<TravelersGroup> TravelersGroups { get; set; }

    public virtual DbSet<Trip> Trips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\בלוי שאשא\\Desktop\\TouristCompany\\DalTour\\DB\\TourDB.mdf\";Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Countrie__3214EC076EF71C5B");

            entity.Property(e => e.CountryName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sites__3214EC07B8C8E01F");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<SitesToTrip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SitesToT__3214EC07EA10B8E2");

            entity.ToTable("SitesToTrip");

            entity.HasOne(d => d.Site).WithMany(p => p.SitesToTrips)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SitesToTrip_Sites");

            entity.HasOne(d => d.Trip).WithMany(p => p.SitesToTrips)
                .HasForeignKey(d => d.TripId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SitesToTrip_Trip");
        });

        modelBuilder.Entity<TravelGuide>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC078E5FB0FC");

            entity.ToTable("TravelGuides ");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNum)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<TravelersGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07DB7B8A17");

            entity.ToTable("TravelersGroup");

            entity.Property(e => e.Destination)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.Guider).WithMany(p => p.TravelersGroups)
                .HasForeignKey(d => d.GuiderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Travelers_Guider");
        });

        modelBuilder.Entity<Trip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Trips__3214EC0783908551");

            entity.Property(e => e.BeginningTime).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.HasOne(d => d.Country).WithMany(p => p.Trips)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Country_Trip");

            entity.HasOne(d => d.Group).WithMany(p => p.Trips)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_Trip");

            entity.HasOne(d => d.Guider).WithMany(p => p.Trips)
                .HasForeignKey(d => d.GuiderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Guider_Trip");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
