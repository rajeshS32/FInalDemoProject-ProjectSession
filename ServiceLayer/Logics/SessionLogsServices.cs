using Entity_Layer;
using Repository_Layer.Interfaces;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Logics
{
   public class SessionLogsServices : ISessionLogsServices
    {
        private readonly ISessionLogsRepo _createnewsession;

        public SessionLogsServices(ISessionLogsRepo createnewsession)
        {
            _createnewsession = createnewsession;
        }

        public bool Createnewpayment(Session_Logs newpayment)
        {
            _createnewsession.createnewpayment(newpayment);
            return true;
        }

        public bool Createnewtransaction(Session_Logs newtrn)
        {
            _createnewsession.createnewtransaction(newtrn);
            return true;
        }

        public bool Createsessionstatus(Session_Logs newstatus)
        {
            _createnewsession.createsessionstatus(newstatus);
            return true;
        }

        public Task<List<Session_Logs>> Getpaymentbyid(int id)
        {
            var result = _createnewsession.getpaymentbyid(id);
            return result;
        }

        public Task<List<Session_Logs>> Getstatusbyid(int id)
        {
            var result = _createnewsession.getstatusbyid(id);
            return result;
        }

        public Task<List<Session_Logs>> Gettrnbyid(int id)
        {
            var result = _createnewsession.gettrnbyid(id);
            return result;
        }
    }
}
