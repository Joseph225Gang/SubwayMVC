using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Domain
{
    public partial class SubWayMemberTicketInfo
    {
        public Guid id { get; set; }
        public  SubwayMember SubwayMember{ get; set; }
        public IList<SubWayTicket> SubwayTicket { get; set; }
    }
}
