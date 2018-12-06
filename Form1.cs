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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CadJogos CadJogos = new CadJogos();
            CadJogos.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditJogos EditJogos = new EditJogos();
            EditJogos.ShowDialog();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Sobre Sobre = new Sobre();
            Sobre.ShowDialog();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            CadFornecedor CadFornecedor = new CadFornecedor();
            CadFornecedor.ShowDialog();
        }

        private void BtnEditFornecedor_Click(object sender, EventArgs e)
        {
            EditFornecedor EditFornecedor = new EditFornecedor();
            EditFornecedor.ShowDialog();
        }

        private void BtnListaBanco_Click(object sender, EventArgs e)
        {
            Lista Lista = new Lista();
            Lista.ShowDialog();
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

        private void BtnBugReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bug reportado com sucesso!");
        }
    }
}
