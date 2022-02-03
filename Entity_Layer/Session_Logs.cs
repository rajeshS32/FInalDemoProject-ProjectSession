using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_Layer
{
   public class Session_Logs
    {
        [Key]
        public int PrimaryID { get; set; }
        public int SessionStatusID { get; set; }
        public string SessionStatus { get; set; }
        public int JsID { get; set; }
        public string JsName { get; set; }
        public int MentorID { get; set; }
        public string MentorName { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int SessionPaymentID { get; set; }
        public int SessionAmountPerHour { get; set; }
        public int AmountPaid { get; set; }
        public int BalancePayment { get; set; }
        public int SessionTrnID { get; set; }
        public string Trn_BankDetails { get; set; }
        public string Trn_status { get; set; }
        public DateTime Trn_DateTime { get; set; }

    }
}
