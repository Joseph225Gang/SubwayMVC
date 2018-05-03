using SubWayTest.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SubWayTest.Wcf
{
    public class DataContext : DbContext
    {
        public DataContext() : base("SubwayContext")
        {
            Database.SetInitializer<DataContext>(null);
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
            Configuration.ValidateOnSaveEnabled = true;
        }

        protected override void Dispose(bool disposing)
        {
            Configuration.LazyLoadingEnabled = false;
            base.Dispose(disposing);
        }

        public DbSet<SubwayMember> SubwayMember { get; set; }
        public DbSet<SubWayTicket> SubWayTicket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<SubWayTicket>()
            .HasRequired<SubwayMember>(s => s.SubwayMember)
            .WithMany(g => g.SubwayTicket)
            .HasForeignKey<Guid>(s => s.SubwayMemberId);
        }
    }
}