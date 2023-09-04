namespace SuperHeroShirt
{
    partial class FormVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.bindingSourceVenda = new System.Windows.Forms.BindingSource(this.components);
            this.superHeroShirtsDBDataSet = new SuperHeroShirt.SuperHeroShirtsDBDataSet();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCriarVenda = new System.Windows.Forms.Button();
            this.panelItensVenda = new System.Windows.Forms.Panel();
            this.btnInserirItemVenda = new System.Windows.Forms.Button();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vendaTableAdapter = new SuperHeroShirt.SuperHeroShirtsDBDataSetTableAdapters.VendaTableAdapter();
            this.funcionariosTableAdapter = new SuperHeroShirt.SuperHeroShirtsDBDataSetTableAdapters.FuncionariosTableAdapter();
            this.clienteTableAdapter = new SuperHeroShirt.SuperHeroShirtsDBDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new SuperHeroShirt.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIdItensVenda = new System.Windows.Forms.TextBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensVendaTableAdapter = new SuperHeroShirt.SuperHeroShirtsDBDataSetTableAdapters.ItensVendaTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new SuperHeroShirt.SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter();
            this.produtoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panelItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data da venda";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceVenda, "DataVenda", true));
            this.dtpDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVenda.Location = new System.Drawing.Point(6, 75);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(315, 26);
            this.dtpDataVenda.TabIndex = 2;
            // 
            // bindingSourceVenda
            // 
            this.bindingSourceVenda.AllowNew = true;
            this.bindingSourceVenda.DataMember = "Venda";
            this.bindingSourceVenda.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // superHeroShirtsDBDataSet
            // 
            this.superHeroShirtsDBDataSet.DataSetName = "SuperHeroShirtsDBDataSet";
            this.superHeroShirtsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceVenda, "FuncionarioID", true));
            this.cmbVendedor.DataSource = this.funcionariosBindingSource;
            this.cmbVendedor.DisplayMember = "Nome";
            this.cmbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(6, 131);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(315, 28);
            this.cmbVendedor.TabIndex = 3;
            this.cmbVendedor.ValueMember = "FuncionarioID";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceVenda, "ClienteID", true));
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(7, 186);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(315, 28);
            this.cmbCliente.TabIndex = 4;
            this.cmbCliente.ValueMember = "ClienteID";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVenda, "TotalVenda", true));
            this.txtTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(381, 188);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(159, 26);
            this.txtTotalVenda.TabIndex = 7;
            this.txtTotalVenda.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor total da venda";
            // 
            // btnCriarVenda
            // 
            this.btnCriarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarVenda.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCriarVenda.Location = new System.Drawing.Point(398, 230);
            this.btnCriarVenda.Name = "btnCriarVenda";
            this.btnCriarVenda.Size = new System.Drawing.Size(142, 44);
            this.btnCriarVenda.TabIndex = 9;
            this.btnCriarVenda.Text = "Criar venda";
            this.btnCriarVenda.UseVisualStyleBackColor = true;
            this.btnCriarVenda.Click += new System.EventHandler(this.btnCriarVenda_Click);
            // 
            // panelItensVenda
            // 
            this.panelItensVenda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelItensVenda.Controls.Add(this.btnInserirItemVenda);
            this.panelItensVenda.Controls.Add(this.dgvItensVenda);
            this.panelItensVenda.Controls.Add(this.label9);
            this.panelItensVenda.Controls.Add(this.label7);
            this.panelItensVenda.Controls.Add(this.nudQuantidade);
            this.panelItensVenda.Controls.Add(this.cmbProduto);
            this.panelItensVenda.Controls.Add(this.label6);
            this.panelItensVenda.Controls.Add(this.txtIdItensVenda);
            this.panelItensVenda.Location = new System.Drawing.Point(7, 320);
            this.panelItensVenda.Name = "panelItensVenda";
            this.panelItensVenda.Size = new System.Drawing.Size(533, 389);
            this.panelItensVenda.TabIndex = 10;
            this.panelItensVenda.Visible = false;
            // 
            // btnInserirItemVenda
            // 
            this.btnInserirItemVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirItemVenda.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnInserirItemVenda.Location = new System.Drawing.Point(366, 110);
            this.btnInserirItemVenda.Name = "btnInserirItemVenda";
            this.btnInserirItemVenda.Size = new System.Drawing.Size(142, 44);
            this.btnInserirItemVenda.TabIndex = 11;
            this.btnInserirItemVenda.Text = "Inserir";
            this.btnInserirItemVenda.UseVisualStyleBackColor = true;
            this.btnInserirItemVenda.Click += new System.EventHandler(this.btnInserirItemVenda_Click);
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AllowUserToAddRows = false;
            this.dgvItensVenda.AutoGenerateColumns = false;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoIdDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dgvItensVenda.DataSource = this.itensVendaBindingSource;
            this.dgvItensVenda.Location = new System.Drawing.Point(17, 170);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.Size = new System.Drawing.Size(491, 216);
            this.dgvItensVenda.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Produto";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itensVendaBindingSource, "Quantidade", true));
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(388, 77);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 26);
            this.nudQuantidade.TabIndex = 13;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "ProdutoId", true));
            this.cmbProduto.DataSource = this.produtoBindingSource;
            this.cmbProduto.DisplayMember = "NomeProduto";
            this.cmbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(17, 76);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(365, 28);
            this.cmbProduto.TabIndex = 11;
            this.cmbProduto.ValueMember = "ProdutoID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(196, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Itens da venda";
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.EstoqueTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.ItensVendaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SuperHeroShirt.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = this.vendaTableAdapter;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVenda, "VendaID", true));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(427, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 11;
            // 
            // txtIdItensVenda
            // 
            this.txtIdItensVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "VendaId", true));
            this.txtIdItensVenda.Location = new System.Drawing.Point(388, 124);
            this.txtIdItensVenda.Name = "txtIdItensVenda";
            this.txtIdItensVenda.Size = new System.Drawing.Size(100, 20);
            this.txtIdItensVenda.TabIndex = 17;
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataMember = "ItensVenda";
            this.itensVendaBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // itensVendaTableAdapter
            // 
            this.itensVendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            this.produtoIdDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            this.produtoIdDataGridViewTextBoxColumn.DataSource = this.produtoBindingSource;
            this.produtoIdDataGridViewTextBoxColumn.DisplayMember = "NomeProduto";
            this.produtoIdDataGridViewTextBoxColumn.HeaderText = "ProdutoId";
            this.produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            this.produtoIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.produtoIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.produtoIdDataGridViewTextBoxColumn.ValueMember = "ProdutoID";
            this.produtoIdDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 721);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panelItensVenda);
            this.Controls.Add(this.btnCriarVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panelItensVenda.ResumeLayout(false);
            this.panelItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCriarVenda;
        private System.Windows.Forms.Panel panelItensVenda;
        private System.Windows.Forms.Button btnInserirItemVenda;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSourceVenda;
        private SuperHeroShirtsDBDataSet superHeroShirtsDBDataSet;
        private SuperHeroShirtsDBDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIdItensVenda;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ItensVendaTableAdapter itensVendaTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn produtoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}