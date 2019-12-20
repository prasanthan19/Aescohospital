using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aescohospital.Models
{
    public class PatientModel
    {
        public int patientID { get; set; }
        public string pfname { get; set; }
        public string plname { get; set; }
        public string pnic { get; set; }
        public int pmobno { get; set; }
        public string paddress { get; set; }
       

    }
}