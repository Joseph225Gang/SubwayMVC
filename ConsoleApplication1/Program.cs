
using ConsoleApplication1.ServiceReference1;
using SubWayTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SubwayContext db = new SubwayContext();
            SubwayMemberServiceClient client = new SubwayMemberServiceClient();
            SubwayMember member = new SubwayMember()
            {
                Id = Guid.NewGuid(),
                LastName = "Li",
                FirstName = "Li",
                MemberId = Guid.NewGuid().ToString(),
                MemberName = "wang",
                Password = "12345678",
                BirthDate = DateTime.Now
            };
            client.Create(db, member);
            client.Close();
            Console.ReadKey();
        }
    }
}
