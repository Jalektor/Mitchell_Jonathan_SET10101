using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using KwikMedical.Emergency.Model;

namespace KwikMedical.Office
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patient _Patient = null;

            TcpListener server = null;

            try
            {
                int port = 123;
                IPAddress ip = IPAddress.Parse("127.0.0.1");

                server = new TcpListener(ip, port);

                server.Start();

                byte[] bytes = new byte[1024];
                string data = null;

                    Console.WriteLine("Waiting for a Connection...");

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    NetworkStream stream = client.GetStream();

                    int i;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = Encoding.ASCII.GetString(bytes, 0, i);
                        _Patient = new Patient();

                        _Patient = JsonConvert.DeserializeObject<Patient>(data);

                        string message = _Patient.FormMessage();

                        Console.WriteLine(message);

                        Console.WriteLine("Reading from DB");

                        string odbcMessage = _Patient.SendToODBC();


                        Console.WriteLine(odbcMessage);
                    }

                    client.Close();
            }
            catch(SocketException e)
            {
                Console.WriteLine("Socket Exception: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
    }
}
