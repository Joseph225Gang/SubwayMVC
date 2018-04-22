using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Domain
{
    public partial class SubWayTicket
    {
        /// <summary>
        /// 主鍵
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 起點位置
        /// </summary>
        public string FromPlace { get; set; }

        /// <summary>
        /// 終點位置
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// 起點時間
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 終點時間
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        public decimal TicketPrice { get; set; }

        /// <summary>
        /// 票種類
        /// </summary>
        public TicketType TicketType { get; set; }
    }
}
