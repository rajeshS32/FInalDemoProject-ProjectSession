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
    public class AdminRegistrationController : ControllerBase
    {
        private readonly IAdminRegistrationServices _adminregistrationervices;
        public AdminRegistrationController(IAdminRegistrationServices adminregistrationervices)
        {
            _adminregistrationervices = adminregistrationervices;
        }

        [HttpGet]
        [Route("listall")]
        public List<Admin_Registration> list()
        {
            var result = _adminregistrationervices.ListAllUsers();
            return result;
        }


        [HttpPost]
        [Route("new")]
        public bool addnew(Admin_Registration regs)
        {
            _adminregistrationervices.NewUser(regs);
            return true;
        }

        [Route("edit")]
        [HttpPut]
        public Task<Admin_Registration> edit(Admin_Registration regs)
        {
            var result = _adminregistrationervices.EditProfile(regs);
            return result;
        }

        [Route("delete")]
        [HttpDelete]
        public void delete(Admin_Registration regs, string word)
        {
            _adminregistrationervices.DeleteProfile(regs, word);
        }

        [HttpPost]
        [Route("login")]
        public bool login(string username, string password)
        {
            _adminregistrationervices.ValidateLogin(username, password);
            return true;
        }

        [HttpGet]
        [Route("profilebyid")]
        public Task<List<Admin_Registration>> getprofilebyempid(int id)
        {
            var result= _adminregistrationervices.ProfileDetails(id);
            return result;
        }

        [HttpGet]
        [Route("userbyid")]
        public Task<List<Admin_Registration>> getuserbyempid(int id)
        {
            var result = _adminregistrationervices.SearchUser(id);
            return result;
        }

    }
}
