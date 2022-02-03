using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_Layer
{
   public class Admin_Registration
    {
        [Key]
        public int PrimaryID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public long OffficialContactNo { get; set; }
        public long MobileNo { get; set; }
        public string OfficialMailID { get; set; }
        public string Designation { get; set; }
        public int BranchID { get; set; }
        public string BranchAddress { get; set; }
        public string Secret_PassCode { get; set; }
        public DateTime DateTime { get; set; }


    }
}
