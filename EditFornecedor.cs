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
    public partial class EditFornecedor : Form
    {
        public EditFornecedor()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração concluida!");
        }

        private void EditFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtContato.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração foi cancelada!");
            Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
