using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OSSN.Models;

namespace OSSN.Data
{
    public partial class OpenSSNDBContext : DbContext
    {
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Applicationperson> Applicationperson { get; set; }
        public virtual DbSet<Applicationpersonhistory> Applicationpersonhistory { get; set; }
        public virtual DbSet<Applicationright> Applicationright { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Contactmedium> Contactmedium { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Personrole> Personrole { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Roleapplicationright> Roleapplicationright { get; set; }
        public virtual DbSet<Ship> Ship { get; set; }
        public virtual DbSet<Shipbreadthtype> Shipbreadthtype { get; set; }
        public virtual DbSet<Shipcertificatetype> Shipcertificatetype { get; set; }
        public virtual DbSet<Shipflagcode> Shipflagcode { get; set; }
        public virtual DbSet<Shiphulltype> Shiphulltype { get; set; }
        public virtual DbSet<Shiplengthtype> Shiplengthtype { get; set; }
        public virtual DbSet<Shipmmsimidicode> Shipmmsimidicode { get; set; }
        public virtual DbSet<Shippowertype> Shippowertype { get; set; }
        public virtual DbSet<Shipsource> Shipsource { get; set; }
        public virtual DbSet<Shipstatus> Shipstatus { get; set; }
        public virtual DbSet<Shiptype> Shiptype { get; set; }
        public virtual DbSet<Shiptypegroup> Shiptypegroup { get; set; }

        public OpenSSNDBContext(DbContextOptions<OpenSSNDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("application");

                entity.HasIndex(e => e.ApplicationrightApplicationrightid)
                    .HasName("ifk_rel_19");

                entity.Property(e => e.Applicationid).HasColumnName("applicationid");

                entity.Property(e => e.ApplicationrightApplicationrightid).HasColumnName("applicationright_applicationrightid");

                entity.HasOne(d => d.ApplicationrightApplicationright)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ApplicationrightApplicationrightid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_applicationright_applicationrightid_fkey");
            });

            modelBuilder.Entity<Applicationperson>(entity =>
            {
                entity.ToTable("applicationperson");

                entity.HasIndex(e => e.ApplicationApplicationid)
                    .HasName("ifk_rel_13");

                entity.HasIndex(e => e.PersonPersonid)
                    .HasName("ifk_rel_12");

                entity.Property(e => e.Applicationpersonid).HasColumnName("applicationpersonid");

                entity.Property(e => e.ApplicationApplicationid).HasColumnName("application_applicationid");

                entity.Property(e => e.PersonPersonid).HasColumnName("person_personid");

                entity.HasOne(d => d.ApplicationApplication)
                    .WithMany(p => p.Applicationperson)
                    .HasForeignKey(d => d.ApplicationApplicationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("applicationperson_application_applicationid_fkey");

                entity.HasOne(d => d.PersonPerson)
                    .WithMany(p => p.Applicationperson)
                    .HasForeignKey(d => d.PersonPersonid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("applicationperson_person_personid_fkey");
            });

            modelBuilder.Entity<Applicationpersonhistory>(entity =>
            {
                entity.ToTable("applicationpersonhistory");

                entity.HasIndex(e => e.ApplicationpersonApplicationpersonid)
                    .HasName("ifk_rel_18");

                entity.Property(e => e.Applicationpersonhistoryid).HasColumnName("applicationpersonhistoryid");

                entity.Property(e => e.ApplicationpersonApplicationpersonid).HasColumnName("applicationperson_applicationpersonid");

                entity.Property(e => e.Createddate).HasColumnName("createddate");

                entity.HasOne(d => d.ApplicationpersonApplicationperson)
                    .WithMany(p => p.Applicationpersonhistory)
                    .HasForeignKey(d => d.ApplicationpersonApplicationpersonid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("applicationpersonhistory_applicationperson_applicationpers_fkey");
            });

            modelBuilder.Entity<Applicationright>(entity =>
            {
                entity.ToTable("applicationright");

                entity.Property(e => e.Applicationrightid).HasColumnName("applicationrightid");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.Companyid).HasColumnName("companyid");
            });

            modelBuilder.Entity<Contactmedium>(entity =>
            {
                entity.ToTable("contactmedium");

                entity.Property(e => e.Contactmediumid).HasColumnName("contactmediumid");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Countryid).HasColumnName("countryid");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.HasIndex(e => e.CountryCountryid)
                    .HasName("ifk_rel_24");

                entity.HasIndex(e => e.LocationLocationid)
                    .HasName("ifk_rel_26");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.CountryCountryid).HasColumnName("country_countryid");

                entity.Property(e => e.LocationLocationid).HasColumnName("location_locationid");

                entity.HasOne(d => d.CountryCountry)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CountryCountryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("location_country_countryid_fkey");

                entity.HasOne(d => d.LocationLocation)
                    .WithMany(p => p.InverseLocationLocation)
                    .HasForeignKey(d => d.LocationLocationid)
                    .HasConstraintName("location_location_locationid_fkey");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Firstname).HasColumnName("firstname");

                entity.Property(e => e.Lastname).HasColumnName("lastname");
            });

            modelBuilder.Entity<Personrole>(entity =>
            {
                entity.ToTable("personrole");

                entity.HasIndex(e => e.PersonPersonid)
                    .HasName("ifk_rel_14");

                entity.HasIndex(e => e.RoleRoleid)
                    .HasName("ifk_rel_15");

                entity.Property(e => e.Personroleid).HasColumnName("personroleid");

                entity.Property(e => e.PersonPersonid).HasColumnName("person_personid");

                entity.Property(e => e.RoleRoleid).HasColumnName("role_roleid");

                entity.HasOne(d => d.PersonPerson)
                    .WithMany(p => p.Personrole)
                    .HasForeignKey(d => d.PersonPersonid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personrole_person_personid_fkey");

                entity.HasOne(d => d.RoleRole)
                    .WithMany(p => p.Personrole)
                    .HasForeignKey(d => d.RoleRoleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personrole_role_roleid_fkey");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Roleid).HasColumnName("roleid");
            });

            modelBuilder.Entity<Roleapplicationright>(entity =>
            {
                entity.ToTable("roleapplicationright");

                entity.HasIndex(e => e.ApplicationrightApplicationrightid)
                    .HasName("ifk_rel_17");

                entity.HasIndex(e => e.RoleRoleid)
                    .HasName("ifk_rel_16");

                entity.Property(e => e.Roleapplicationrightid).HasColumnName("roleapplicationrightid");

                entity.Property(e => e.ApplicationrightApplicationrightid).HasColumnName("applicationright_applicationrightid");

                entity.Property(e => e.RoleRoleid).HasColumnName("role_roleid");

                entity.HasOne(d => d.ApplicationrightApplicationright)
                    .WithMany(p => p.Roleapplicationright)
                    .HasForeignKey(d => d.ApplicationrightApplicationrightid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("roleapplicationright_applicationright_applicationrightid_fkey");

                entity.HasOne(d => d.RoleRole)
                    .WithMany(p => p.Roleapplicationright)
                    .HasForeignKey(d => d.RoleRoleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("roleapplicationright_role_roleid_fkey");
            });

            modelBuilder.Entity<Ship>(entity =>
            {
                entity.ToTable("ship");

                entity.Property(e => e.Shipid).HasColumnName("shipid");

                entity.Property(e => e.Breadth).HasColumnName("breadth");

                entity.Property(e => e.Callsign)
                    .IsRequired()
                    .HasColumnName("callsign");

                entity.Property(e => e.CompanyCompanyid).HasColumnName("company_companyid");

                entity.Property(e => e.CountryCountryid).HasColumnName("country_countryid");

                entity.Property(e => e.Draught).HasColumnName("draught");

                entity.Property(e => e.Dwt).HasColumnName("dwt");

                entity.Property(e => e.Grosstonnage).HasColumnName("grosstonnage");

                entity.Property(e => e.Hassidethrusters).HasColumnName("hassidethrusters");

                entity.Property(e => e.Hassidethrustersback).HasColumnName("hassidethrustersback");

                entity.Property(e => e.Hassidethrustersfront).HasColumnName("hassidethrustersfront");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Imono).HasColumnName("imono");

                entity.Property(e => e.Mmsino).HasColumnName("mmsino");

                entity.Property(e => e.Power).HasColumnName("power");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.ShipbreadthtypeShipbreadthtypeid).HasColumnName("shipbreadthtype_shipbreadthtypeid");

                entity.Property(e => e.ShipflagcodeShipflagcodeid).HasColumnName("shipflagcode_shipflagcodeid");

                entity.Property(e => e.ShiphulltypeShiphulltypeid).HasColumnName("shiphulltype_shiphulltypeid");

                entity.Property(e => e.Shiplength).HasColumnName("shiplength");

                entity.Property(e => e.ShiplengthtypeShiplengthtypeid).HasColumnName("shiplengthtype_shiplengthtypeid");

                entity.Property(e => e.Shipname)
                    .IsRequired()
                    .HasColumnName("shipname");

                entity.Property(e => e.ShippowertypeShippowertypeid).HasColumnName("shippowertype_shippowertypeid");

                entity.Property(e => e.ShipsourceShipsourceid).HasColumnName("shipsource_shipsourceid");

                entity.Property(e => e.ShipstatusShipstatusid).HasColumnName("shipstatus_shipstatusid");

                entity.Property(e => e.ShiptypeShiptypeid).HasColumnName("shiptype_shiptypeid");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Yearofbuild).HasColumnName("yearofbuild");

                entity.HasOne(d => d.CompanyCompany)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.CompanyCompanyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_company_companyid_fkey");

                entity.HasOne(d => d.CountryCountry)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.CountryCountryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_country_countryid_fkey");

                entity.HasOne(d => d.ShipbreadthtypeShipbreadthtype)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShipbreadthtypeShipbreadthtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_shipbreadthtype_shipbreadthtypeid_fkey");

                entity.HasOne(d => d.ShipflagcodeShipflagcode)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShipflagcodeShipflagcodeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_shipflagcode_shipflagcodeid_fkey");

                entity.HasOne(d => d.ShiphulltypeShiphulltype)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShiphulltypeShiphulltypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_shiphulltype_shiphulltypeid_fkey");

                entity.HasOne(d => d.ShiplengthtypeShiplengthtype)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShiplengthtypeShiplengthtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_shiplengthtype_shiplengthtypeid_fkey");

                entity.HasOne(d => d.ShippowertypeShippowertype)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShippowertypeShippowertypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_shippowertype_shippowertypeid_fkey");

                entity.HasOne(d => d.ShipsourceShipsource)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShipsourceShipsourceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_shipsource_shipsourceid_fkey");

                entity.HasOne(d => d.ShipstatusShipstatus)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShipstatusShipstatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_shipstatus_shipstatusid_fkey");

                entity.HasOne(d => d.ShiptypeShiptype)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShiptypeShiptypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ship_shiptype_shiptypeid_fkey");
            });

            modelBuilder.Entity<Shipbreadthtype>(entity =>
            {
                entity.ToTable("shipbreadthtype");

                entity.Property(e => e.Shipbreadthtypeid).HasColumnName("shipbreadthtypeid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shipbreadthtype1)
                    .IsRequired()
                    .HasColumnName("shipbreadthtype");

                entity.Property(e => e.Systemname)
                    .IsRequired()
                    .HasColumnName("systemname");
            });

            modelBuilder.Entity<Shipcertificatetype>(entity =>
            {
                entity.ToTable("shipcertificatetype");

                entity.Property(e => e.Shipcertificatetypeid).HasColumnName("shipcertificatetypeid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shipcertificate).HasColumnName("shipcertificate");
            });

            modelBuilder.Entity<Shipflagcode>(entity =>
            {
                entity.ToTable("shipflagcode");

                entity.HasIndex(e => e.CountryCountryid)
                    .HasName("ifk_rel_22");

                entity.Property(e => e.Shipflagcodeid).HasColumnName("shipflagcodeid");

                entity.Property(e => e.CountryCountryid).HasColumnName("country_countryid");

                entity.HasOne(d => d.CountryCountry)
                    .WithMany(p => p.Shipflagcode)
                    .HasForeignKey(d => d.CountryCountryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shipflagcode_country_countryid_fkey");
            });

            modelBuilder.Entity<Shiphulltype>(entity =>
            {
                entity.ToTable("shiphulltype");

                entity.Property(e => e.Shiphulltypeid).HasColumnName("shiphulltypeid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shiphulltype1)
                    .IsRequired()
                    .HasColumnName("shiphulltype");

                entity.Property(e => e.Systemname)
                    .IsRequired()
                    .HasColumnName("systemname");
            });

            modelBuilder.Entity<Shiplengthtype>(entity =>
            {
                entity.ToTable("shiplengthtype");

                entity.Property(e => e.Shiplengthtypeid).HasColumnName("shiplengthtypeid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shiplengthtype1)
                    .IsRequired()
                    .HasColumnName("shiplengthtype");

                entity.Property(e => e.Systemname)
                    .IsRequired()
                    .HasColumnName("systemname");
            });

            modelBuilder.Entity<Shipmmsimidicode>(entity =>
            {
                entity.ToTable("shipmmsimidicode");

                entity.HasIndex(e => e.CountryCountryid)
                    .HasName("ifk_rel_25");

                entity.Property(e => e.Shipmmsimidicodeid).HasColumnName("shipmmsimidicodeid");

                entity.Property(e => e.CountryCountryid).HasColumnName("country_countryid");

                entity.HasOne(d => d.CountryCountry)
                    .WithMany(p => p.Shipmmsimidicode)
                    .HasForeignKey(d => d.CountryCountryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shipmmsimidicode_country_countryid_fkey");
            });

            modelBuilder.Entity<Shippowertype>(entity =>
            {
                entity.ToTable("shippowertype");

                entity.Property(e => e.Shippowertypeid).HasColumnName("shippowertypeid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shippowertype1)
                    .IsRequired()
                    .HasColumnName("shippowertype");

                entity.Property(e => e.Systemname)
                    .IsRequired()
                    .HasColumnName("systemname");
            });

            modelBuilder.Entity<Shipsource>(entity =>
            {
                entity.ToTable("shipsource");

                entity.Property(e => e.Shipsourceid).HasColumnName("shipsourceid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shipsource1)
                    .IsRequired()
                    .HasColumnName("shipsource");

                entity.Property(e => e.Systemname)
                    .IsRequired()
                    .HasColumnName("systemname");
            });

            modelBuilder.Entity<Shipstatus>(entity =>
            {
                entity.ToTable("shipstatus");

                entity.Property(e => e.Shipstatusid).HasColumnName("shipstatusid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shipstatus1)
                    .IsRequired()
                    .HasColumnName("shipstatus");

                entity.Property(e => e.Systemname)
                    .IsRequired()
                    .HasColumnName("systemname");
            });

            modelBuilder.Entity<Shiptype>(entity =>
            {
                entity.ToTable("shiptype");

                entity.HasIndex(e => e.ShiptypegroupShiptypegroupid)
                    .HasName("ifk_rel_06");

                entity.Property(e => e.Shiptypeid).HasColumnName("shiptypeid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shiptype1).HasColumnName("shiptype");

                entity.Property(e => e.ShiptypegroupShiptypegroupid).HasColumnName("shiptypegroup_shiptypegroupid");

                entity.Property(e => e.Systemname)
                    .IsRequired()
                    .HasColumnName("systemname");

                entity.HasOne(d => d.ShiptypegroupShiptypegroup)
                    .WithMany(p => p.Shiptype)
                    .HasForeignKey(d => d.ShiptypegroupShiptypegroupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shiptype_shiptypegroup_shiptypegroupid_fkey");
            });

            modelBuilder.Entity<Shiptypegroup>(entity =>
            {
                entity.ToTable("shiptypegroup");

                entity.Property(e => e.Shiptypegroupid).HasColumnName("shiptypegroupid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Shiptypegroup1)
                    .IsRequired()
                    .HasColumnName("shiptypegroup");

                entity.Property(e => e.Shiptypegroupcode).HasColumnName("shiptypegroupcode");

                entity.Property(e => e.Systemname)
                    .IsRequired()
                    .HasColumnName("systemname");
            });
        }
    }
}
