using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KwikMedical.Emergency.Model;
using Newtonsoft.Json;
using System.Net.Sockets;

namespace KwikMedical.Emergency.Communication
{
    public class SendMessage
    {
        Patient _Patient = null;
        string _Data { get; set; }

        public SendMessage(Patient patient)
        {
            _Patient = patient;
        }

        public void PrepareData()
        {
            string JSONMessage = JsonConvert.SerializeObject(_Patient);

            SendData(JSONMessage);
        }

        public void SendData(string data)
        {
            _Data = data;
            string ip = "127.0.0.1";
            int port = 123;

            try
            {
                TcpClient client = new TcpClient(ip, port);

                byte[] dataSent = Encoding.ASCII.GetBytes(data);

                NetworkStream stream = client.GetStream();

                stream.Write(dataSent, 0, dataSent.Length);

                // Shutdowns connection on Client end and ends stream
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

        }

        public void InsertInfo()
        {

        }
    }
}
