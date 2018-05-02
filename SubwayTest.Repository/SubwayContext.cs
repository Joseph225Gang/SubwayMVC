using SubWayTest.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Repository
{
    public class SubwayContext : DbContext
    {
        public SubwayContext() : base("SubwayContext")
        {
        }
        public DbSet<SubwayMember> SubwayMember { get; set; }
        public DbSet<SubWayMemberTicketInfo> SubWayMemberTicketInfo { get; set; }
        public DbSet<SubWayTicket> SubWayTicket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<SubwayMember>()
            //   .HasOptional(s => s.SubWayMemberTicketInfo) 
            //   .WithRequired(ad => ad.SubwayMember);
            //modelBuilder.Entity<SubWayTicket>()
            //.HasRequired<SubWayMemberTicketInfo>(s => s.SubWayMemberTicketInfo)
            //.WithMany(g => g.SubwayTicket)
            //.HasForeignKey<Guid>(s => s.SubWayMemberTicketInfoId);
        }
    }
}
