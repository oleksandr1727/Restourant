using System.Net;
using System.Net.Sockets;

namespace ServerApp
{
        class Program
        {
            static int port = 4041; // порт для прийому вхідних запитів
            static void Main(string[] args)
            {
                // получаємо адрес для запуску сокета
                IPAddress iPAddress = IPAddress.Parse("127.0.0.10");
                IPEndPoint ipPoint = new IPEndPoint(iPAddress, port);

                // створюємо сокет
                TcpListener listener = new TcpListener(ipPoint); // зв'язує

                try
                {
                    // зв'язує сокет з локальною точкою, по якій будем приймати дані
                    // починає прослуховувати
                    listener.Start();
                    Console.WriteLine("Server started! Waiting for connection...");
                    TcpClient client = listener.AcceptTcpClient(); //присилає підконекченого ;) клієнта

                    while (client.Connected)
                    {
                        NetworkStream ns = client.GetStream();

                        StreamReader sr = new StreamReader(ns);
                        string response = sr.ReadLine(); // читає те що нам прийшло

                        Console.WriteLine($"{client.Client.RemoteEndPoint} - {response} at {DateTime.Now.ToShortTimeString()}");

                        // відправляємо відповідь
                        string message = "Message was send!";

                        StreamWriter sw = new StreamWriter(ns);
                        sw.WriteLine(message);

                        sw.Flush(); // інфа полетіла до клієнта           
                    }
                    // закрываем сокет
                    client.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                listener.Stop();
            }
        }
}
