using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace Servidor
{
    class Servidor_Chat
    {
        private string IPAdd, puerto;

        private TcpListener server;
        private TcpClient client = new TcpClient();
        private IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 8000);
        private List<Connection> list = new List<Connection>();

        Connection con;


        private struct Connection
        {
            public NetworkStream stream;
            public StreamWriter streamw;
            public StreamReader streamr;
            public string nick;
        }

        public Servidor_Chat()
        {
            Inicio();
        }

        public void Inicio()
        {
            Console.WriteLine("INFO [" + DateTime.Now.ToString("g") + "] " + "El servidor ha sido iniciado con exito.");
            server = new TcpListener(ipendpoint);
            server.Start();

            while (true)
            {
                client = server.AcceptTcpClient();

                con = new Connection();
                con.stream = client.GetStream();
                con.streamr = new StreamReader(con.stream);
                con.streamw = new StreamWriter(con.stream);

                con.nick = con.streamr.ReadLine();

                list.Add(con);
                Console.WriteLine("INFO [" + DateTime.Now.ToString("g") + "] " + con.nick + " se a conectado.");
                foreach (Connection c in list)
                {
                    try
                    {
                        c.streamw.WriteLine("[" + DateTime.Now.ToString("g") + "] " + con.nick + " se ha conectado.");
                        c.streamw.Flush();
                    }
                    catch
                    {
                    }
                }


                Thread t = new Thread(Escuchar_conexion);

                t.Start();
            }
        }

        void Escuchar_conexion()
        {
            Connection hcon = con;

            do
            {
                try
                {
                    string tmp = hcon.streamr.ReadLine();
                    Console.WriteLine("INFO [" + DateTime.Now.ToString("g") + "] " + hcon.nick + ": " + tmp);
                    foreach (Connection c in list)
                    {
                        try
                        {
                            c.streamw.WriteLine("[" + DateTime.Now.ToString("g") + "] " + hcon.nick + ": " + tmp);
                            c.streamw.Flush();
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                    list.Remove(hcon);
                    Console.WriteLine("INFO [" + DateTime.Now.ToString("g") + "] " + con.nick + " se a desconectado.");
                    foreach (Connection c in list)
                    {
                        try
                        {
                            c.streamw.WriteLine("[" + DateTime.Now.ToString("g") + "] " + con.nick + " se ha ido.");
                            c.streamw.Flush();
                        }
                        catch
                        {
                        }
                    }
                    break;
                }
            } while (true);
        }

    }
}
