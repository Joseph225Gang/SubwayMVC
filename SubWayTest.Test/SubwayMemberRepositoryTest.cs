using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubWayTest.Repository;
using SubWayTest.Domain;

namespace SubWayTest.Test
{
    /// <summary>
    /// Summary description for SubwayMemberRepositoryTest
    /// </summary>
    [TestClass]
    public class SubwayMemberRepositoryTest
    {

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
            subwayMemberRepository.Create(member);
        }
    }
}
