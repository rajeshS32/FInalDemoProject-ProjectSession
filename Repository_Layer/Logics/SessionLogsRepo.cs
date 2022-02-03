using Data_Layer;
using Entity_Layer;
using Repository_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.Logics
{
   public class SessionLogsRepo : ISessionLogsRepo
    {
        private readonly SessionDbContext _sessiondbcontext;

        public SessionLogsRepo(SessionDbContext sessiondbcontext)
        {
            _sessiondbcontext = sessiondbcontext;
        }

        public async Task<bool> createnewpayment(Session_Logs newpayment)
        {
            await _sessiondbcontext.SessionLogs.AddAsync(newpayment);
            await _sessiondbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> createnewtransaction(Session_Logs newtrn)
        { 
            await _sessiondbcontext.SessionLogs.AddAsync(newtrn);
            await _sessiondbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> createsessionstatus(Session_Logs newstatus)
        {
            await _sessiondbcontext.SessionLogs.AddAsync(newstatus);
            await _sessiondbcontext.SaveChangesAsync();
            return true;
        }

        public Task<List<Session_Logs>> getpaymentbyid(int id)
        {
            var result = _sessiondbcontext.SessionLogs.Where(a => a.SessionPaymentID == id).ToList();
            return Task.FromResult(result);
        }

        public Task<List<Session_Logs>> getstatusbyid(int id)
        {
            var result = _sessiondbcontext.SessionLogs.Where(a => a.SessionStatusID == id).ToList();
            return Task.FromResult(result);
        }

        public Task<List<Session_Logs>> gettrnbyid(int id)
        {
            var result = _sessiondbcontext.SessionLogs.Where(a => a.SessionTrnID == id).ToList();
            return Task.FromResult(result);
        }
    }
}
