namespace CompoanyLinqRest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<Pracownik> Pracownicy { get; set; }
        public virtual DbSet<Zespol> Zespoly { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etat>()
                .Property(e => e.Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<Etat>()
                .Property(e => e.PlacaMin)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Etat>()
                .Property(e => e.PlacaMax)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.Nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.Etat)
                .IsUnicode(false);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.PlacaPod)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.PlacaDod)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Zespol>()
                .Property(e => e.Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<Zespol>()
                .Property(e => e.Adres)
                .IsUnicode(false);
        }
    }
}
