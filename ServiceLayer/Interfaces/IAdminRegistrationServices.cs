using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
   public interface IAdminRegistrationServices
    {
        bool NewUser(Admin_Registration registration);
        Task<Admin_Registration> EditProfile(Admin_Registration registration);
        Task<List<Admin_Registration>> ProfileDetails(int id);
        bool ValidateLogin(string Username, string Password);
        void DeleteProfile(Admin_Registration registration,string word);
        List<Admin_Registration> ListAllUsers();
        Task<List<Admin_Registration>> SearchUser(int id);
    }
}
