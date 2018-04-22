using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Domain
{
    public partial class SubwayMember
    {
        /// <summary>
        /// 主鍵
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 身分證
        /// </summary>
        public string PerosonalId { get; set; }

        /// <summary>
        /// 會員Id
        /// </summary>
        public string MemberId { get; set; }
        
        /// <summary>
        /// 名
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDate { get; set; }
    
        /// <summary>
        /// 會員名子
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 會員帳號
        /// </summary>
        public string PassWord { get; set; }
    }
}
