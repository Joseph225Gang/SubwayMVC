using SubWayTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SubWayTest.Wcf
{
    [ServiceContract]
    public interface ISubwayMemberService
    {
        [OperationContract]
        void Create(SubwayMember member);
    }
}
