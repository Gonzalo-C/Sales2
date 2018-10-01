namespace ClassLibrary1
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

        public virtual DbSet<CLIEN_DB> CLIEN_DB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.RAZSOC)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.RUT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.IMPUTABLE)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.TRANSPORTE)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.RAZSOC2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.DIR)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.COMUNA)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CIUDAD)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.FONO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CLASE1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CLASE2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CLASE3)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CLASE4)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.YY)
                .HasPrecision(16, 11);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.FORMAP)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.DESCTO)
                .HasPrecision(14, 2);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.BLOQUEA)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.COMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.GIRO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.ELIMINADO)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CATEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CRED_APR)
                .HasPrecision(14, 2);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CRED_UTI)
                .HasPrecision(14, 2);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CONTRTOT)
                .HasPrecision(14, 2);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CONTRMNY)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CONTRTX)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.FIJO)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.YYBAK)
                .HasPrecision(16, 11);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.USERMODI)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.RELACIONAD)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.BASEDATOS)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.NUNCA_BLOQ)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.PARENT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.RUTADUANA)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CLILP)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CASELEC)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.dimaxpag)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CTACTECLIEPROV)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CLASE5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.DIR2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.PROD_MANT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.dir_foto)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.FAMILIA1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.FAMILIA2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.ref_minera)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.VERSION)
                .IsFixedLength();

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CODGLN)
                .IsUnicode(false);

            modelBuilder.Entity<CLIEN_DB>()
                .Property(e => e.CIUDAD_POSTAL)
                .IsUnicode(false);
        }
    }
}
