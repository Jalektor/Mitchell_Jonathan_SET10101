using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikMedical.Ambulance.Model
{
    public class CallOutDetails
    {
        public int PatientNHSNumber { get; set; }
        public string Who { get; set; }
        public string What { get; set; }
        public string When { get; set; }
        public string Where { get; set; }
        public string Action { get; set; }
        public string Time { get; set; }

        public string FormMessage()
        {
            string message = PatientNHSNumber + "\n" + 
                             Who + "\n" + 
                             What + "\n" + 
                             Where + "\n" + 
                             Action + "\n" + 
                             Time;

            return message;
        }
    }
}
