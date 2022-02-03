using Entity_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FInalDemoProject_ProjectSession.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionLogsController : ControllerBase
    {
        private readonly ISessionLogsServices _sessionlogsservices;

        public SessionLogsController(ISessionLogsServices sessionlogsservices)
        {
            _sessionlogsservices = sessionlogsservices;
        }

        [HttpPost]
        [Route("createnew")]
        public bool Createnewpayment(Session_Logs newpayment)
        {
            _sessionlogsservices.Createnewpayment(newpayment);
            return true;
        }

        [HttpPost]
        [Route("Createtrn")]
        public bool Createnewtransaction(Session_Logs newtrn)
        {
            _sessionlogsservices.Createnewtransaction(newtrn);
            return true;
        }

        [HttpPost]
        [Route("Createstatus")]
        public bool Createsessionstatus(Session_Logs newstatus)
        {
            _sessionlogsservices.Createsessionstatus(newstatus);
            return true;
        }
        
        [HttpGet("{payid}")]
        public Task<List<Session_Logs>> Getpaymentbyid(int id)
        {
            var result = _sessionlogsservices.Getpaymentbyid(id);
            return result;
        }

        [HttpGet("{statusid}")]
        
        public Task<List<Session_Logs>> Getstatusbyid(int id)
        {
            var result = _sessionlogsservices.Getstatusbyid(id);
            return result;
        }

        [HttpGet("{trnid}")]
        public Task<List<Session_Logs>> Gettrnbyid(int id)
        {
            var result = _sessionlogsservices.Gettrnbyid(id);
            return result;
        }
    }
}
