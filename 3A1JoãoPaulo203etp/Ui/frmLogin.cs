using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1JoãoPaulo203etp.Code.BLL;
using _3A1JoãoPaulo203etp.Code.DTO;

namespace _3A1JoãoPaulo203etp.Ui
{
    public partial class frmLogin : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO logindto = new LoginDTO();
        public frmLogin()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            logindto.Email = txtEmail.Text;
            logindto.Senha = txtSenha.Text;

            if(loginBLL.RealizarLogin(logindto) == true)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique Email e senha");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
