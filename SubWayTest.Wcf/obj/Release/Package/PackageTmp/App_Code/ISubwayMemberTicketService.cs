using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Wcf
{
    [ServiceContract]
    public interface ISubwayMemberTicketService
    {
        [OperationContract]
        void Create();
        [OperationContract]
        void Update();
        [OperationContract]
        void Delete();
    }
}
