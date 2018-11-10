using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using KwikMedical.Ambulance.Model;
using System.Windows;

namespace KwikMedical.Ambulance.Communication
{
    public class SendToDB
    {
        public CallOutDetails Details;

        public void WriteToODBC(CallOutDetails _details)
        {
            try
            {

                //(patientRegNumber, who, what, when, where, action, time)
                Details = _details;

                //string sqlInsert = $"INSERT INTO kwikmedical.calloutdetails (who) VALUES {Details.Who}";//, {Details.Who},{Details.What},{Details.When},{Details.Where},{Details.Action},{Details.Time}";

                string sqlInsert = $"INSERT INTO kwikmedical.calloutdetails (patientNhsNos, who) VALUES ({_details.PatientNHSNumber}, '{_details.Who}');";
                OdbcConnection dbConnection = new OdbcConnection("DSN=KwikMedical");

                //OdbcDataAdapter adapter = new OdbcDataAdapter("", dbConnection);

                //adapter.InsertCommand = new OdbcCommand(sqlInsert);

                //dbConnection.Open();
                //OdbcCommand dbCommmand = dbConnection.CreateCommand();

                OdbcCommand dbCommand = new OdbcCommand();

                dbCommand.Connection = dbConnection;
                dbCommand.Connection.Open();

                dbCommand.CommandText = sqlInsert;

                //dbCommand.Parameters.Add("@patientNhsNos", OdbcType.Int, 11, "123");
                //dbCommand.Parameters.Add("@who", OdbcType.VarChar, 45, "response");

                dbCommand.ExecuteNonQuery();

                //dbCommmand.ExecuteNonQueryAsync();
                dbCommand.Connection.Close();
                dbCommand.Dispose();
                //adapter.Dispose();
                //dbConnection.Close();
            }
            catch(OdbcException ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }
        }

    }
}
