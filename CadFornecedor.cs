using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RedBoxGames
{
    public partial class CadFornecedor : Form
    {
        public CadFornecedor()
        {
            InitializeComponent();
        }

        private void CadFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            /* string de conexao */
            string stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Will\RedBox\RedBoxGames\REDBOX.mdb";
            string incluirSQL = "INSERT INTO Fornecedor(Nome,CPF/CNPJ,Contato)values(@Nome,@CPF,@Contato)";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@Nome", OleDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@CPF/CNPJ", OleDbType.VarChar).Value = txtCPF.Text;
            comando.Parameters.Add("@Contato", OleDbType.VarChar).Value = txtContato.Text;

            try
            {
                obterConexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obterConexao.Close();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtContato.Clear();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro foi cancelado!");
            Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
