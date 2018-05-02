using SubwayTest.Repository;
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
        void Index();
        [OperationContract]
        void Create(SubwayMember subwayMember);
        [OperationContract]
        void Update(SubwayMember subwayMember);
        [OperationContract]
        void Delete(Guid id);
    }
}
