using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBoxGames
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://servicos.unifg.edu.br/webmail/esqueciSenha.asp?_ga=2.61482852.930200815.1543179034-1353064694.1542925565");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Fechar o Programa?",
                "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!");
            }
            else
            {
                Close();
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();

            MessageBox.Show("Usuário Logado Com Sucesso !");
        }
    }
}
