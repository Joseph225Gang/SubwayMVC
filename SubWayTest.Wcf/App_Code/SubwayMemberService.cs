using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SubWayTest.Domain;

namespace SubWayTest.Wcf
{
    public class SubwayMemberService : ISubwayMemberService
    {
        private DataContext db = new DataContext();
        public void Create(SubwayMember member)
        {
            try
            {
                db.SubwayMember.Add(member);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}