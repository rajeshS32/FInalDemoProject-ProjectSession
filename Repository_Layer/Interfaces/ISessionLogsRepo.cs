using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.Interfaces
{
   public interface ISessionLogsRepo
    {
        Task<bool> createsessionstatus(Session_Logs newstatus);
        Task<List<Session_Logs>> getstatusbyid(int id);
        Task<bool> createnewpayment(Session_Logs newpayment);
        Task<List<Session_Logs>> getpaymentbyid(int id);
        Task<bool> createnewtransaction(Session_Logs newtrn);
        Task<List<Session_Logs>> gettrnbyid(int id);
    }
}
