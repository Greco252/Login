using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmTelaCadastro f = new frmTelaCadastro();
            f.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();




        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "GrecoBrabo@gmail.com" || txtLogin.Text == "0321")
            {
                MessageBox.Show("Seja Bem vindo !");
            }
            else
            {
                MessageBox.Show("Login ou Senha Inválidos, tente novamente!");
            }
        }

        private void txtUsernameLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

