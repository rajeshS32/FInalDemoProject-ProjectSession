using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;
using Entity_Layer;

namespace FInalDemoProject_ProjectSession.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateNewSessionController : ControllerBase
    {
        private readonly ICreateNewSessionServices _createNewsessionservices;

        public CreateNewSessionController(ICreateNewSessionServices createNewsessionservices)
        {
            _createNewsessionservices = createNewsessionservices;
        }

        [HttpGet]
        [Route("getall")]
        public Task<List<Create_NewSession>> getall()
        {
            return _createNewsessionservices.Listallcreatedsessions();

        }

        [HttpPost]
        [Route("add")]
        public bool add(Create_NewSession ne)
        {
            _createNewsessionservices.CreateNewSession(ne);
            return true;
        }

        [HttpPut]
        [Route("edit")]
        public Task<Create_NewSession> Editsession(Create_NewSession newsession)
        {
            var result = _createNewsessionservices.Editsession(newsession);
            return result;
        }

        [HttpDelete]
        [Route("delete")]
        public void deletesession(Create_NewSession newsession)
        {
            _createNewsessionservices.Deletesession(newsession);
        }

        [HttpGet]
        [Route("gethpdbycouse")]
        public Task<List<Create_NewSession>> Gethappenedsessionbycourse(string course)
        {
            var result = _createNewsessionservices.Gethappenedsessionbycourse(course);
            return result;
        }

        [HttpGet]
        [Route("gethpdbyid")]
        public Task<List<Create_NewSession>> Gethappenedsessionbymentorid(int id)
        {
            var result = _createNewsessionservices.Gethappenedsessionbymentorid(id);
            return result;
        }

        [HttpGet]
        [Route("getnobyid")]
        public Task<List<Create_NewSession>> Getnoshowsessionbymentorid(int id)
        {
            var result = _createNewsessionservices.Getnoshowsessionbymentorid(id);
            return result;
        }

        [HttpGet]
        [Route("getsessionbyid")]
        public Task<List<Create_NewSession>> GetsessionbyID(int id)
        {
            var result =_createNewsessionservices.GetsessionbyID(id);
            return result;
        }

        [HttpGet]
        [Route("getbyjsid")]
        public Task<List<Create_NewSession>> GetsessionbyJSID(int id)
        {
            var result = _createNewsessionservices.GetsessionbyJSID(id);
            return result;
        }

        [HttpGet]
        [Route("getbymentorid")]
        public Task<List<Create_NewSession>> GetsessionbyMentorID(int id)
        {
            var result = _createNewsessionservices.GetsessionbyMentorID(id);
            return result;
        }


        [HttpGet]
        [Route("listallhpd")]
        public Task<List<Create_NewSession>> Listallhappenedsession()
        {
            var result = _createNewsessionservices.Listallhappenedsession();
            return result;
        }

        [HttpGet]
        [Route("listallno")]
        public Task<List<Create_NewSession>> Listallnoshowsession()
        {
            var result = _createNewsessionservices.Listallnoshowsession();
            return result;
        }
    }
}
