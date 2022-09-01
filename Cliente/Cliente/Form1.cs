using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Cliente
{

    public partial class Form1 : Form
    {
        public string ip, puerto;
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        static private string nick = "unknown";


        private delegate void DAddItem(String s);

        public void SetUsuario(String usuario)
        {
            nick = usuario;
        }

        public void SetIp(String ip)
        {
            this.ip = ip;
        }

        public void SetPuerto(String port)
        {
            this.puerto = port;
        }

        private void AddItem(String s)
        {
            listBox1.Items.Add(s);
        }



        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!client.Connected)
            {
                MessageBox.Show("Te haz desconectado del servidor");
                cambiarImage();
            }
            else
            {
                streamw.WriteLine(textBox1.Text);
                streamw.Flush();
                textBox1.Clear();
                textChecker();
            }

        }


        void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DAddItem(AddItem), streamr.ReadLine());

                }
                catch
                {
                    MessageBox.Show("No se ha podido conectar al servidor. Revise la conexión.");
                    cambiarImage();
                }
            }
        }

        void Conectar()
        {
            try
            {
                client.Connect(ip, int.Parse(puerto));
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);

                    streamw.WriteLine(nick);
                    streamw.Flush();

                    t.Start();

                    pictureBox1.Image = Cliente.Properties.Resources.comprobar;
                }
                else
                {
                    MessageBox.Show("El servidor no esta disponible. Revise la conexión.");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El servidor no esta disponible. Revise la conexión.");
                Application.Exit();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            Conectar();
            userlabel.Text = "Bienvenido " + nick + ", al chat del CBTIS 03.";
            status_label.Text = "Conectado a: " + ip + ":" + puerto;
            textChecker();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enviar.PerformClick();
            }
        }

        private void Enviar_MouseEnter(object sender, EventArgs e)
        {
            Enviar.Image = Cliente.Properties.Resources.enviar_hover;
        }

        private void Enviar_MouseLeave(object sender, EventArgs e)
        {
            Enviar.Image = Cliente.Properties.Resources.enviar;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Environment.Exit(0);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            textChecker();
        }

        private void textChecker()
        {
            if (String.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                Enviar.Enabled = false;
            }
            else
            {
                Enviar.Enabled = true;
            }
        } 
        
        private void cambiarImage()
        {
            CheckForIllegalCrossThreadCalls = false;
            pictureBox1.Image = Cliente.Properties.Resources.eliminar;
            status_label.Text = "Desconectado.";

            Enviar.Enabled = false;
            textBox1.Enabled = false;
            textBox1.DeselectAll();
        }
    }
}
