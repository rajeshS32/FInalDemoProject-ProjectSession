using Entity_Layer;
using Repository_Layer.Interfaces;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ServiceLayer.Logics
{
    public class AdminRegistrationServices : IAdminRegistrationServices
    {
        private readonly IAdminRegistrationRepo _adminregistration;

        public AdminRegistrationServices(IAdminRegistrationRepo adminregistration)
        {
            _adminregistration = adminregistration;
        }

        public void DeleteProfile(Admin_Registration registration, string word)
        {
            if (word == "ConfirmDelete")
            {
                _adminregistration.deleteProfile(registration, word);
            }
        }

        public Task<Admin_Registration> EditProfile(Admin_Registration registration)
        {
            var result = _adminregistration.editProfile(registration);
            return result;
        }

        public List<Admin_Registration> ListAllUsers()
        {
            var result = _adminregistration.listAllUsers();
            return result;
        }

        public bool NewUser(Admin_Registration registration)
        {
            _adminregistration.newUser(registration);
            return true;
        }

        public Task<List<Admin_Registration>> ProfileDetails(int id)
        {
           var result=  _adminregistration.profileDetails(id);
            return result;
        }

        public Task<List<Admin_Registration>> SearchUser(int id)
        {
            var result = _adminregistration.searchUser(id);
            return result;
        }

        public bool ValidateLogin(string Username, string Password)
        {
            try
            {
                _adminregistration.validateLogin(Username, Password);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }
    }
}
