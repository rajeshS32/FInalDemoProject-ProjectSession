using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.Interfaces
{
   public interface ICreateNewSessionRepo
    {
        Task<bool> createNewSession(Create_NewSession newsession);
        Task<Create_NewSession> editsession(Create_NewSession newsession);
        void deletesession(Create_NewSession newsession);
        Task<List<Create_NewSession>> getsessionbyID(int id);
        Task<List<Create_NewSession>> getsessionbyJSID(int id);
        Task<List<Create_NewSession>> getsessionbyMentorID(int id);
        Task<List<Create_NewSession>> listallcreatedsessions();
        Task<List<Create_NewSession>> listallhappenedsession();
        Task<List<Create_NewSession>> gethappenedsessionbycourse(string course);
        Task<List<Create_NewSession>> gethappenedsessionbymentorid(int id);
        Task<List<Create_NewSession>> listallnoshowsession();
        Task<List<Create_NewSession>> getnoshowsessionbymentorid(int id);


    }
}
