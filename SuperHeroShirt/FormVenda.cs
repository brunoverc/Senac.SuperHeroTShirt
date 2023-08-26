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
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.superHeroShirtsDBDataSet.Cliente);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.superHeroShirtsDBDataSet.Funcionarios);

            this.vendaTableAdapter.Fill(this.superHeroShirtsDBDataSet.Venda);

            //Colocando nosso form em modo de adição, ou seja,
            //limpando os campos e deixando para inserir um novo.
            this.bindingSourceVenda.AddNew();
            //Coloca o ID no campo ID
            int id = bindingSourceVenda.Count;
            txtID.Text = id.ToString();
            //Coloca a data de hoje no campo de data
            dtpDataVenda.Value = DateTime.Now;
            //Coloque o valor total da compra como zero
            txtTotalVenda.Text = "0";
        }

        private void btnCriarVenda_Click(object sender, EventArgs e)
        {
            //Código para salvar uma venda
            this.Validate();
            this.bindingSourceVenda.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superHeroShirtsDBDataSet);

            MessageBox.Show("Venda criada com sucesso, insira os itens da venda");
        }
    }
}
