using System.Collections.Generic;
using System.ServiceModel;

namespace MyService
{
    [ServiceContract]
    public interface INewsHandler
    {
        [OperationContract]
        List<New> GetNewsFromTable();
        [OperationContract]
        New GetNewByNumber(int number);
        [OperationContract]
        void SaveNewByNumber(int number);
        [OperationContract]
        int NewsCount();
    }
}