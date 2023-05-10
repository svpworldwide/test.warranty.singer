namespace WebManuals.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    //using MySql.Data;
    //using MySql.Data.Entity;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<languages> languages { get; set; }
        public virtual DbSet<manuals> manuals { get; set; }
        public virtual DbSet<modeltypes> modeltypes { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<languages>()
                .Property(e => e.language_name)
                .IsUnicode(false);

            modelBuilder.Entity<languages>()
                .HasMany(e => e.manuals)
                .WithOptional(e => e.languages)
                .HasForeignKey(e => e.manual_languageid);

            modelBuilder.Entity<manuals>()
                .Property(e => e.manual_name)
                .IsUnicode(false);

            modelBuilder.Entity<manuals>()
                .Property(e => e.manual_url)
                .IsUnicode(false);

            modelBuilder.Entity<modeltypes>()
                .Property(e => e.modeltype_name)
                .IsUnicode(false);

            modelBuilder.Entity<modeltypes>()
                .HasMany(e => e.manuals)
                .WithOptional(e => e.modeltypes)
                .HasForeignKey(e => e.manual_modeltypeid);
        }
    }
}
