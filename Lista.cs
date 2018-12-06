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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            /* string de conexao */
            string stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Will\source\repos\RedBoxGames\DB.mdb";
            string incluirSQL = "INSERT INTO Lista(Fornecedor,DataEmissão,Status,IdStatus)values(@Fornecedor,@Data,@IdStatus)";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@Fornecedor", OleDbType.VarChar).Value = txtFornecedor.Text;
            comando.Parameters.Add("@Data", OleDbType.VarChar).Value = mskData.Text;
            comando.Parameters.Add("@Status", OleDbType.VarChar).Value = txtStatus.Text;
            comando.Parameters.Add("@IdStatus", OleDbType.VarChar).Value = txtIdStatus.Text;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtFornecedor.Clear();
            mskData.Clear();
            txtStatus.Clear();
            txtIdStatus.Clear();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir este relatório?",
                  "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!");
            }
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            OleDbConnection obterConexao = new OleDbConnection();

            obterConexao.Open();
            OleDbCommand cmd = obterConexao.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Status";
            cmd.ExecuteNonQuery();
            DataTable bd = new DataTable();
            OleDbDataAdapter bdt = new OleDbDataAdapter(cmd);
            bdt.Fill(bd);
            dataGridView.DataSource = bd;
            obterConexao.Close();
        }
    }
}
