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
    public partial class SubWayTicket
    {
        /// <summary>
        /// 主鍵
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// 起點位置
        /// </summary>
        [DataMember]
        public string FromPlace { get; set; }

        /// <summary>
        /// 終點位置
        /// </summary>
        [DataMember]
        public string Destination { get; set; }

        /// <summary>
        /// 起點時間
        /// </summary>
        [DataMember]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 終點時間
        /// </summary>
        [DataMember]
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        [DataMember]
        public decimal TicketPrice { get; set; }

        /// <summary>
        /// 票種類
        /// </summary>
        [DataMember]
        public TicketType TicketType { get; set; }
        [DataMember]
        public virtual SubwayMember SubwayMember { get; set; }
        [DataMember]
        public Guid SubwayMemberId { get; set; }
    }
}
