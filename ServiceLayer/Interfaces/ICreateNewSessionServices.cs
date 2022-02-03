using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
   public interface ICreateNewSessionServices
    {
        bool CreateNewSession(Create_NewSession newsession);
        Task<Create_NewSession> Editsession(Create_NewSession newsession);
        void Deletesession(Create_NewSession newsession);
        Task<List<Create_NewSession>> GetsessionbyID(int id);
        Task<List<Create_NewSession>> GetsessionbyJSID(int id);
        Task<List<Create_NewSession>> GetsessionbyMentorID(int id);
        Task<List<Create_NewSession>> Listallcreatedsessions();
        Task<List<Create_NewSession>> Listallhappenedsession();
        Task<List<Create_NewSession>> Gethappenedsessionbycourse(string course);
        Task<List<Create_NewSession>> Gethappenedsessionbymentorid(int id);
        Task<List<Create_NewSession>> Listallnoshowsession();
        Task<List<Create_NewSession>> Getnoshowsessionbymentorid(int id);
    }
}
