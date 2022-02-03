using Data_Layer;
using Entity_Layer;
using Repository_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Repository_Layer.Logics
{
    public class AdminRegistrationRepo : IAdminRegistrationRepo
    {
        private readonly SessionDbContext _sessiondbcontext;
        public AdminRegistrationRepo(SessionDbContext sessiondbcontext)
        {
            _sessiondbcontext = sessiondbcontext;
        }

        public void deleteProfile(Admin_Registration registration, string word)
        {
            var result = _sessiondbcontext.AdminRegistration;
            try
            {
                result.Remove(registration);
                _sessiondbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<Admin_Registration> editProfile(Admin_Registration registration)
        {
            var result = _sessiondbcontext.AdminRegistration;
            try
            {
                _sessiondbcontext.AdminRegistration.Update(registration);
                await _sessiondbcontext.SaveChangesAsync();
                return await Task.FromResult(registration);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Admin_Registration> listAllUsers()
        {
            List<Admin_Registration> ad = new List<Admin_Registration>();
            Admin_Registration ss = new Admin_Registration();
         var res=  _sessiondbcontext.AdminRegistration.Select(a => new { a.BranchAddress, a.BranchID, a.DateTime }).ToList();

            foreach(var item in res)
            {
                ss.BranchAddress = item.BranchAddress;
                ss.BranchID = item.BranchID;
                ss.DateTime = item.DateTime;
                ad.Add(ss);
            }

            return ad;
            
            //var result = _sessiondbcontext.AdminRegistration.ToList();
            //return result;
        }

        public async Task<bool> newUser(Admin_Registration registration)
        {
            await _sessiondbcontext.AdminRegistration.AddAsync(registration);
            await _sessiondbcontext.SaveChangesAsync();
            return true;

        }

        public Task<List<Admin_Registration>> profileDetails(int id)
        {
            var result = _sessiondbcontext.AdminRegistration.Where(a => a.EmployeeID == id).ToList();
            return Task.FromResult(result);
        }

        public Task<List<Admin_Registration>> searchUser(int id)
        {
            var result = _sessiondbcontext.AdminRegistration.Where(a => a.EmployeeID == id).ToList();
            return Task.FromResult(result);
        }

        public bool validateLogin(string Username, string Password)
        {
            var result = _sessiondbcontext.AdminRegistration.Where(a => a.UserName.Equals(Username) && a.Password.Equals(Password));
            if (result == null)
            {
                //throw exception
            }
            return true;
        }
    }
}
