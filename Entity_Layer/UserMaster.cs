using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Layer
{
   public class UserMaster : IdentityUser
    {
        public string Contact { get; set; }
        public string Address { get; set; }
        public string IdProofNumber { get; set; }
        public bool? Enabled { get; set; }
    }

}
