using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
   public interface ISessionLogsServices
    {
        bool Createsessionstatus(Session_Logs newstatus);
        Task<List<Session_Logs>> Getstatusbyid(int id);
        bool Createnewpayment(Session_Logs newpayment);
        Task<List<Session_Logs>> Getpaymentbyid(int id);
        bool Createnewtransaction(Session_Logs newtrn);
        Task<List<Session_Logs>> Gettrnbyid(int id);
    }
}
