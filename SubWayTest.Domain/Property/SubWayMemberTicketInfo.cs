using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Domain
{
    [DataContract]
    public partial class SubWayMemberTicketInfo
    {
        [DataMember]
        //[ForeignKey("SubwayMember")]
        public Guid SubwayMemberId { get; set; }
        [DataMember]
        public Guid id { get; set; }
        [DataMember]
        public  virtual SubwayMember SubwayMember{ get; set; }
        [DataMember]
        public ICollection<SubWayTicket> SubwayTicket { get; set; }
        [DataMember]
        public Guid SubwayTicketId { get; set; }
    }
}
