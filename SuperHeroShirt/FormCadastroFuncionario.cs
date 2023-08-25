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
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superHeroShirtsDBDataSet);

        }

        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.superHeroShirtsDBDataSet.Venda);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.superHeroShirtsDBDataSet.Funcionarios);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int id = funcionariosBindingSource.Count;
            txtID.Text = id.ToString();
        }
    }
}
