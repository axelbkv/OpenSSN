using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace OSSN.Models
{
    public partial class OpenSSNDBContext : DbContext
    {
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Applicationperson> Applicationperson { get; set; }
        public virtual DbSet<Applicationpersonhistory> Applicationpersonhistory { get; set; }
        public virtual DbSet<Applicationright> Applicationright { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Personrole> Personrole { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Roleapplicationright> Roleapplicationright { get; set; }

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
        }
    }
}
