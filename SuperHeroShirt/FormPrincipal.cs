using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHeroShirt
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formularioCadastroProduto = new FormCadastroProduto();
            formularioCadastroProduto.ShowDialog();
        }

        private void cadastroDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario form = new FormCadastroFuncionario();
            form.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstoque form = new FormEstoque();
            form.ShowDialog();
        }
    }
}
