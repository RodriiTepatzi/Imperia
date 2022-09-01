using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Login : Form
    {

        public string usuario, ip, puerto;
        private bool userBoxActive=false, ipBoxActive=false, puertoBoxActive=false;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ipBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                            e.KeyChar != (char)Keys.Back &&
                            e.KeyChar != '.')
            {
                e.Handled = true;
            }


        }

        private void puertoBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {

                    e.Handled = true;
                    return;

                }
            
        }

        private void conectarbtn_MouseEnter(object sender, EventArgs e)
        {
            conectarbtn.Image = Cliente.Properties.Resources.conectar_hover;
        }

        private void userBox_KeyUp(object sender, KeyEventArgs e)
        {
            FormChecker();
        }

        private void ipBox_KeyUp(object sender, KeyEventArgs e)
        {
            FormChecker();
        }

        private void puertoBox_KeyUp(object sender, KeyEventArgs e)
        {
            FormChecker();
        }

        private void conectarbtn_MouseLeave(object sender, EventArgs e)
        {
            conectarbtn.Image = Cliente.Properties.Resources.conectar;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            userBox.Select();
            Tip.SetToolTip(button1, "Cerrar");
            Tip.SetToolTip(userBox, "Inserte nombre de usuario. \nMáximo 12 dígitos.");
            Tip.SetToolTip(ipBox, "Ingrese la IP del servidor. \nPor defecto es 127.0.0.1");
            Tip.SetToolTip(puertoBox, "Puerto de conexión para el servidor. \nPor defecto es 8000.");
            Tip.SetToolTip(conectarbtn, "Conectar al servidor");
            FormChecker();
        }

        private void conectarbtn_Click(object sender, EventArgs e)
        {
            //if 
            this.usuario = userBox.Text.ToString();
            this.ip = ipBox.Text.ToString();
            this.puerto = puertoBox.Text.ToString();

            Form1 chat = new Form1();
            chat.SetUsuario(usuario);
            chat.SetIp(ip);
            chat.SetPuerto(puerto);
            chat.Show();
            this.Hide();

           

        }

        private void FormChecker()
        {

            /// Chequea el campo user no este vacio
            if (String.IsNullOrEmpty(userBox.Text.ToString()))
            {
                userBoxActive = false;
                lineShape1.BorderColor = Color.Red;
            }
            else
            {
                userBoxActive = true;
                lineShape1.BorderColor = Color.MidnightBlue;
            }

            /// Chequea el campo ip si no es ta vacio
            /// 

            if (String.IsNullOrEmpty(ipBox.Text.ToString()))
            {
                ipBoxActive = false;
                lineShape2.BorderColor = Color.Red;
            }
            else
            {
                ipBoxActive = true;
                lineShape2.BorderColor = Color.MidnightBlue;
            }

            /// Chequea el campo puerto si no es ta vacio
            /// 

            if (String.IsNullOrEmpty(puertoBox.Text.ToString()))
            {
                puertoBoxActive = false;
                lineShape3.BorderColor = Color.Red;
            }
            else
            {
                puertoBoxActive = true;
                lineShape3.BorderColor = Color.MidnightBlue;
            }


            /// Chequea que todos los campos esten activos.
            /// 

            if (userBoxActive && ipBoxActive && puertoBoxActive)
            {
                conectarbtn.Enabled = true;
            }
            else
            {
                conectarbtn.Enabled = false;
            }


        }
    }
}
