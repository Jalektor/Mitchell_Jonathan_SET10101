using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikMedical.Emergency.Model
{
    public class Patient
    {
        public string PatientName { get; set; }
        public string PatientDOB { get; set; }
        public string Address { get; set; }
        public string NHSRegNos { get; set; }
        public string MedicalCondition { get; set; }

        public string FormMessage ()
        {
            string message = PatientName + "\n" +
                            PatientDOB + "\n" +
                            Address + "\n" +
                            NHSRegNos + "\n" +
                            MedicalCondition;

            return message;
        }
    }

}
