using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Domain
{
    [DataContract]
    public partial class SubwayMember
    {
        /// <summary>
        /// 主鍵
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// 身分證
        /// </summary>
        [DataMember]
        public string PerosonalId { get; set; }

        /// <summary>
        /// 會員Id
        /// </summary>
        [DataMember]
        public string MemberId { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [DataMember]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// 會員名子
        /// </summary>
        [DataMember]
        public string MemberName { get; set; }

        /// <summary>
        /// 會員帳號
        /// </summary>
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public IList<SubWayTicket> SubwayTicket { get; set; }
    }
}
