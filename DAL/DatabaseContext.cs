using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Enquiry> Enquiries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enquiry>()
                .Property(e => e.FristName)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
