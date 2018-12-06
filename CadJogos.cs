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
using MessagingToolkit.QRCode.Codec;

namespace RedBoxGames
{
    public partial class CadJogos : Form
    {
        public CadJogos()
        {
            InitializeComponent();
        }

        private void CadJogos_Load(object sender, EventArgs e)
        {

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            /* string de conexao */
            string stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Will\RedBox\RedBoxGames\REDBOX.mdb";
            string incluirSQL = "INSERT INTO jogos(Tipo,Plataforma,TituloJogo)values(@Tipo,@Plataforma,@TituloJogo)";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@Tipo", OleDbType.VarChar).Value = txtTipo.Text;
            comando.Parameters.Add("@Plataforma", OleDbType.VarChar).Value = txtPlataforma.Text;
            comando.Parameters.Add("@TituloJogo", OleDbType.VarChar).Value = txtTitulo.Text;

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

            txtCodigo.Clear();
            txtTipo.Clear();
            txtPlataforma.Clear();
            txtTitulo.Clear();
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro foi cancelado!");
            Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            /* Seta Para Voltar ao Menu Principal */
            Close();
        }

        private void btnGerarQRCode_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGerarQRCode_Click_1(object sender, EventArgs e)
        {
            QRCodeEncoder qrCodecEncoder = new QRCodeEncoder();
            qrCodecEncoder.QRCodeBackgroundColor = System.Drawing.Color.White;
            qrCodecEncoder.QRCodeForegroundColor = System.Drawing.Color.Black;
            qrCodecEncoder.CharacterSet = "UTF-8";
            qrCodecEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodecEncoder.QRCodeScale = 6;
            qrCodecEncoder.QRCodeVersion = 0;
            qrCodecEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;

            Image imageQRCode;
            //string a ser gerada

            
            String tipo, plataforma, titulo;

            tipo = Convert.ToString(txtTipo.Text);
            plataforma = Convert.ToString(txtPlataforma.Text);
            titulo = Convert.ToString(txtTitulo.Text);

            imageQRCode = qrCodecEncoder.Encode(titulo);
            GerarQRCode.Image = imageQRCode;
        }
    }
}

