using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.Interfaces
{
    public interface IAdminRegistrationRepo
    {
        Task<bool> newUser(Admin_Registration registration);
        Task<Admin_Registration> editProfile(Admin_Registration registration);
        Task<List<Admin_Registration>> profileDetails(int id);
        bool validateLogin(string Username, string Password);
        void deleteProfile(Admin_Registration registration, string word);
        List<Admin_Registration> listAllUsers();
        Task<List<Admin_Registration>> searchUser(int id);

    }
}
