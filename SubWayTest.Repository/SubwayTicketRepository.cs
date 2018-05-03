using SubWayTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Repository
{

    public class SubwayTicketRepository
    {
        private SubwayContext db = new SubwayContext();

        public void Create(SubWayTicket ticket)
        {
            try
            {
                db.SubWayTicket.Add(ticket);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public IEnumerable<SubWayTicket> Index()
        {
            var list = db.SubWayTicket.ToList();
            List<SubWayTicket> subwayTicketList = new List<SubWayTicket>();
            foreach (var item in list)
            {
                var tempTicket = new SubWayTicket();
                tempTicket.ArrivalTime = item.ArrivalTime;
                tempTicket.Destination = item.Destination;
                tempTicket.FromPlace = item.FromPlace;
                tempTicket.StartTime = item.StartTime;
                tempTicket.SubwayMemberId = item.SubwayMemberId;
                tempTicket.Id = item.Id;
                tempTicket.TicketPrice = item.TicketPrice;
                tempTicket.TicketType = item.TicketType;
                subwayTicketList.Add(tempTicket);
            }
            return subwayTicketList;
        }
    }
}
