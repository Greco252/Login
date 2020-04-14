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
    public partial class frmTelaCadastro: Form
    {
        public frmTelaCadastro()
        {
            InitializeComponent();
        }

        private void lblRepetirS_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin f2 = new FrmLogin();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
        }
    }
}
