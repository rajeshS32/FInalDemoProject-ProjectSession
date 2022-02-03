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
   public class CreateNewSessionRepo : ICreateNewSessionRepo
    {
        private readonly SessionDbContext _sessiondbcontext;

        public CreateNewSessionRepo(SessionDbContext sessiondbcontext)
        {
            _sessiondbcontext = sessiondbcontext;
        }

        public async Task<bool> createNewSession(Create_NewSession newsession)
        {
            try
            {
                await _sessiondbcontext.CreateNewSession.AddAsync(newsession);
                await _sessiondbcontext.SaveChangesAsync();
                return true;
            }
         catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void deletesession(Create_NewSession newsession)
        {
            var result = _sessiondbcontext.CreateNewSession;
            try
            {
                result.Remove(newsession);
                _sessiondbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Create_NewSession> editsession(Create_NewSession newsession)
        {
            try
            {
                _sessiondbcontext.CreateNewSession.Update(newsession);
                await _sessiondbcontext.SaveChangesAsync();
                return await Task.FromResult(newsession);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<List<Create_NewSession>> gethappenedsessionbycourse(string course)
        {
            var result = _sessiondbcontext.CreateNewSession.Where(a => a.CourseName == course).ToList();
            return Task.FromResult(result);

        }
        
        public Task<List<Create_NewSession>> gethappenedsessionbymentorid(int id)
        {
            var result = _sessiondbcontext.CreateNewSession.Where(a => a.MentorID == id).ToList();
            return Task.FromResult(result);
        }

        public Task<List<Create_NewSession>> getnoshowsessionbymentorid(int id)
        {
            var result = _sessiondbcontext.CreateNewSession.Where(a => a.MentorID == id).ToList();
            return Task.FromResult(result);
        }

        public Task<List<Create_NewSession>> getsessionbyID(int id)
        {
            var result = _sessiondbcontext.CreateNewSession.Where(a => a.SessionID == id).ToList();
            return Task.FromResult(result);
        }

        public Task<List<Create_NewSession>> getsessionbyJSID(int id)
        {
            var result = _sessiondbcontext.CreateNewSession.Where(a => a.JsID == id).ToList();
            return Task.FromResult(result);
        }

        public Task<List<Create_NewSession>> getsessionbyMentorID(int id)
        {
            var result = _sessiondbcontext.CreateNewSession.Where(a => a.MentorID == id).ToList();
            return Task.FromResult(result);
        }

        public Task<List<Create_NewSession>> listallcreatedsessions()
        { 
            var res = _sessiondbcontext.CreateNewSession;
            var result = res.ToList();
            return Task.FromResult(result);
        }

        public Task<List<Create_NewSession>> listallhappenedsession()
        {
            var result = _sessiondbcontext.CreateNewSession.ToList();
            return Task.FromResult(result);
        }

        public Task<List<Create_NewSession>> listallnoshowsession()
        {
            var result = _sessiondbcontext.CreateNewSession.ToList();
            return Task.FromResult(result);
        }
    }
}
