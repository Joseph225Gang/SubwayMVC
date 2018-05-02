using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubWayTest.WcfTest.ServiceReference1;
using SubWayTest.Domain;
using SubWayTest.Wcf;
using SubWayTest.Repository;

namespace SubWayTest.WcfTest
{
    [TestClass]
    public class SubwayMemberTest
    {
        private Repository.SubwayContext db = new Repository.SubwayContext();
        [TestMethod]
        public void Create()
        {
            SubwayMember member = new SubwayMember()
            {
                Id = Guid.NewGuid(),
                LastName = "li",
                FirstName = "li",
                BirthDate = DateTime.Now
            };
            db.SubwayMember.Add(member);
            db.SaveChanges();
        }

        [TestMethod]
        public void CreateService()
        {
            SubwayMemberRepository subwayMemberRepository = new SubwayMemberRepository();
            SubwayMember member = new SubwayMember()
            {
                Id = Guid.NewGuid(),
                LastName = "lia",
                FirstName = "lia",
                BirthDate = DateTime.Now
            };
            subwayMemberRepository.Create(member);
        }
    }
}
