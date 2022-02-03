using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_Layer
{
   public class Create_NewSession
    {
        [Key]
        public int PrimaryID { get; set; }
        public int SessionID { get; set; }
        public int JsID { get; set; }
        public string JsName { get; set; }
        public int MentorID { get; set; }
        public string MentorName { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public DateTime SessionDateTime { get; set; }
        public int AmountPerHour { get; set; }
        public int SessionHappenedID { get; set; }
        public DateTime SessionHappenedDateTime { get; set; }
        public int NOShowSessionID { get; set; }
        public int NOShowSessionJs_ID { get; set; }
        public DateTime NOShowSessionJs_DateTime{ get; set; }
        public string NOShowSessionJs_Reason { get; set; }
        public int NOShowSessionMentor_ID{ get; set; }
        public DateTime NOShowSessionMentor_DateTime { get; set; }
        public string NOShowSessionMentor_Reason { get; set; }

    }
}
