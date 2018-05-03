using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubWayTest.Repository;
using SubWayTest.Domain;
using SubWayTest.Test.ServiceReference1;

namespace SubWayTest.Test
{
    /// <summary>
    /// Summary description for SubwayMemberRepositoryTest
    /// </summary>
    [TestClass]
    public class SubwayMemberRepositoryTest
    {
        private SubwayMemberServiceClient client = new SubwayMemberServiceClient();

        [TestMethod]
        public void TestMethod1()
        {
            SubwayMemberRepository subwayMemberRepository = new SubwayMemberRepository();
            SubwayMember member = new SubwayMember()
            {
                Id = Guid.NewGuid(),
                LastName = "lia1",
                FirstName = "lia1",
                BirthDate = DateTime.Now
            };
            SubWayTicket ticket = new SubWayTicket()
            {
                Id = Guid.NewGuid(),
                ArrivalTime = DateTime.Now,
                Destination = "Taipei",
                FromPlace = "Taipei",
                StartTime = DateTime.Now,
                TicketPrice = 100,
                TicketType = TicketType.Adult
            };
            member.SubwayTicket = new List<SubWayTicket>();
            member.SubwayTicket.Add(ticket);
            subwayMemberRepository.Create(member);
        }

        [TestMethod]
        public void TestSubwayTicket()
        {
            SubWayTicket ticket = new SubWayTicket()
            {
                Id = Guid.NewGuid(),
                ArrivalTime = DateTime.Now,
                Destination = "台北市",
                FromPlace = "新北市",
                StartTime = DateTime.Now,
                TicketPrice = 100,
                TicketType = TicketType.Adult
            };
        }

        [TestMethod]
        public void MemberServiceTest()
        {
            SubwayMember member = new SubwayMember()
            {
                Id = Guid.NewGuid(),
                LastName = "lia1",
                FirstName = "lia1",
                BirthDate = DateTime.Now
            };
            client.Create(member);
            client.Close();
        }
    }
}
