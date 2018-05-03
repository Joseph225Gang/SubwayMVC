using SubWayTest.Domain;
using SubWayTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SubWayTest.Api
{
    public class SubwayTicketApiController : ApiController
    {
        private SubwayTicketRepository subwayTicketRepository = new SubwayTicketRepository();
        private SubwayContext db = new SubwayContext();

        [HttpPost]
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
