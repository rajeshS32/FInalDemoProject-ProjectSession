using Entity_Layer;
using Repository_Layer.Interfaces;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Logics
{
   public class CreateNewSessionServices : ICreateNewSessionServices
    {
        private readonly ICreateNewSessionRepo _createnewsession;

        public CreateNewSessionServices(ICreateNewSessionRepo createnewsession)
        {
            _createnewsession = createnewsession;
        }

        public bool CreateNewSession(Create_NewSession newsession)
        {
            _createnewsession.createNewSession(newsession);
            return true;
        }

        public void Deletesession(Create_NewSession newsession)
        {
            _createnewsession.createNewSession(newsession);

        }

        public Task<Create_NewSession> Editsession(Create_NewSession newsession)
        {
            var result = _createnewsession.editsession(newsession);
            return result;
        }

        public Task<List<Create_NewSession>> Gethappenedsessionbycourse(string course)
        {
            var result = _createnewsession.gethappenedsessionbycourse(course);
            return result;
        }

        public Task<List<Create_NewSession>> Gethappenedsessionbymentorid(int id)
        {
            var result = _createnewsession.gethappenedsessionbymentorid(id);
            return result;
        }

        public Task<List<Create_NewSession>> Getnoshowsessionbymentorid(int id)
        {
            var result = _createnewsession.getnoshowsessionbymentorid(id);
            return result;
        }

        public Task<List<Create_NewSession>> GetsessionbyID(int id)
        {
            var result = _createnewsession.getsessionbyID(id);
            return result;
        }

        public Task<List<Create_NewSession>> GetsessionbyJSID(int id)
        {
            var result = _createnewsession.getsessionbyJSID(id);
            return result;
        }

        public Task<List<Create_NewSession>> GetsessionbyMentorID(int id)
        {
            var result = _createnewsession.getsessionbyMentorID(id);
            return result;
        }

        public Task<List<Create_NewSession>> Listallcreatedsessions()
        {
            var result = _createnewsession.listallcreatedsessions();
            return result;
        }

        public Task<List<Create_NewSession>> Listallhappenedsession()
        {
            var result = _createnewsession.listallhappenedsession();
            return result;
        }

        public Task<List<Create_NewSession>> Listallnoshowsession()
        {
            var result = _createnewsession.listallnoshowsession();
            return result;
        }
    }
}
