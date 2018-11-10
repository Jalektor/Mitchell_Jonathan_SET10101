using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

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

        public string SendToODBC()
        {
            string odbcMessage = "blank"; 
            OdbcConnection dbConnection = new OdbcConnection("DSN=KwikMedical");

            dbConnection.Open();

            OdbcCommand dbCommmand = dbConnection.CreateCommand();

            String sqlQuery = $"SELECT * FROM patientmedicalrecord WHERE patientRegNumber = {NHSRegNos}";

            dbCommmand.CommandText = sqlQuery;
            OdbcDataReader dbReader = dbCommmand.ExecuteReader();


            int count = dbReader.FieldCount;

            while(dbReader.Read())
            {
               for(int i = 0; i < count; i++)
                {
                    odbcMessage += dbReader.GetString(i) + ": ";
                }
            }

            dbReader.Close();
            dbCommmand.Dispose();
            dbConnection.Close();

            return odbcMessage;
        }
    }

}
