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
    public partial class EditJogos : Form
    {
        public EditJogos()
        {
            InitializeComponent();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração concluida!");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtTipo.Clear();
            txtPlataforma.Clear();
            txtTitulo.Clear();
        }

        private void EditJogos_Load(object sender, EventArgs e)
        {

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
