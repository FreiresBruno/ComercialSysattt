namespace ComercialSys
{
    partial class FrmProduto
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
            txtDescricao = new TextBox();
            txtClasseDesconto = new TextBox();
            mskCodigo = new MaskedTextBox();
            mskValor = new MaskedTextBox();
            cmbUnidedeVendas = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnInserir = new Button();
            txtEstoqueMinimo = new TextBox();
            label7 = new Label();
            btnObterPorID = new Button();
            btnEditar = new Button();
            groupBox1 = new GroupBox();
            cmbCategoria = new ComboBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            CodigodeBarras = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            valorunitario = new DataGridViewTextBoxColumn();
            unidadedevenda = new DataGridViewTextBoxColumn();
            categoriaID = new DataGridViewTextBoxColumn();
            estoqueminimo = new DataGridViewTextBoxColumn();
            classededesconto = new DataGridViewTextBoxColumn();
            label8 = new Label();
            txtId = new MaskedTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(370, 106);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(190, 23);
            txtDescricao.TabIndex = 1;
            // 
            // txtClasseDesconto
            // 
            txtClasseDesconto.Location = new Point(371, 264);
            txtClasseDesconto.Name = "txtClasseDesconto";
            txtClasseDesconto.Size = new Size(190, 23);
            txtClasseDesconto.TabIndex = 6;
            // 
            // mskCodigo
            // 
            mskCodigo.Location = new Point(370, 77);
            mskCodigo.Mask = "0 000000 000000";
            mskCodigo.Name = "mskCodigo";
            mskCodigo.Size = new Size(190, 23);
            mskCodigo.TabIndex = 0;
            // 
            // mskValor
            // 
            mskValor.Location = new Point(370, 140);
            mskValor.Name = "mskValor";
            mskValor.Size = new Size(190, 23);
            mskValor.TabIndex = 2;
            // 
            // cmbUnidedeVendas
            // 
            cmbUnidedeVendas.FormattingEnabled = true;
            cmbUnidedeVendas.Items.AddRange(new object[] { "1 - METRO", "2 - UNIDADE", "3 - QUILOGRAMA", "4 - LITRO", "5 - CAIXA ", "6 - MILILITRO", "7 - PEÇA ", "8 - FARDO", "9 - FRASCO", "10 - PACOTE", "11 - GRAMA" });
            cmbUnidedeVendas.Location = new Point(370, 172);
            cmbUnidedeVendas.Name = "cmbUnidedeVendas";
            cmbUnidedeVendas.Size = new Size(190, 23);
            cmbUnidedeVendas.TabIndex = 3;
            cmbUnidedeVendas.SelectedIndexChanged += cmbUnidedeVendas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 80);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 8;
            label1.Text = "Código de barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 109);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 143);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 10;
            label3.Text = "Valor unitário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 175);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 11;
            label4.Text = "Unidade de venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 214);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Categoria ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 238);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 13;
            label6.Text = "Estoque minimo";
            label6.Click += label6_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(512, 299);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 30);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(370, 235);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(190, 23);
            txtEstoqueMinimo.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 267);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 14;
            label7.Text = "Classe de Desconto";
            // 
            // btnObterPorID
            // 
            btnObterPorID.Location = new Point(380, 299);
            btnObterPorID.Name = "btnObterPorID";
            btnObterPorID.Size = new Size(94, 30);
            btnObterPorID.TabIndex = 7;
            btnObterPorID.Text = "&Obter por ID";
            btnObterPorID.UseVisualStyleBackColor = true;
            btnObterPorID.Click += btnObterPorID_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(239, 299);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 30);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEstoqueMinimo);
            groupBox1.Controls.Add(txtClasseDesconto);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(btnObterPorID);
            groupBox1.Controls.Add(mskCodigo);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(mskValor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbUnidedeVendas);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(21, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 504);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(370, 206);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(191, 23);
            cmbCategoria.TabIndex = 16;
            cmbCategoria.SelectedIndexChanged += txtCategoria_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, CodigodeBarras, descricao, valorunitario, unidadedevenda, categoriaID, estoqueminimo, classededesconto });
            dataGridView1.Location = new Point(30, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(804, 128);
            dataGridView1.TabIndex = 15;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // CodigodeBarras
            // 
            CodigodeBarras.HeaderText = "CODIGO DE BARRAS";
            CodigodeBarras.Name = "CodigodeBarras";
            CodigodeBarras.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.HeaderText = "DESCRIÇÃO";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // valorunitario
            // 
            valorunitario.HeaderText = "VALOR UNITARIO";
            valorunitario.Name = "valorunitario";
            valorunitario.ReadOnly = true;
            // 
            // unidadedevenda
            // 
            unidadedevenda.HeaderText = "UNIDADE DE VENDA";
            unidadedevenda.Name = "unidadedevenda";
            unidadedevenda.ReadOnly = true;
            // 
            // categoriaID
            // 
            categoriaID.HeaderText = "CATEGORIAID";
            categoriaID.Name = "categoriaID";
            categoriaID.ReadOnly = true;
            // 
            // estoqueminimo
            // 
            estoqueminimo.HeaderText = "ESTOQUE MINIMO";
            estoqueminimo.Name = "estoqueminimo";
            estoqueminimo.ReadOnly = true;
            // 
            // classededesconto
            // 
            classededesconto.HeaderText = "CLASSE DE DESCONTO";
            classededesconto.Name = "classededesconto";
            classededesconto.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 34);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 8;
            label8.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(371, 34);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(64, 23);
            txtId.TabIndex = 2;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 565);
            Controls.Add(groupBox1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDescricao;
        private TextBox txtClasseDesconto;
        private MaskedTextBox mskCodigo;
        private MaskedTextBox mskValor;
        private ComboBox cmbUnidedeVendas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnInserir;
        private TextBox txtEstoqueMinimo;
        private Label label7;
        private Button btnObterPorID;
        private Button btnEditar;
        private GroupBox groupBox1;
        private MaskedTextBox txtId;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn CodigodeBarras;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn valorunitario;
        private DataGridViewTextBoxColumn unidadedevenda;
        private DataGridViewTextBoxColumn categoriaID;
        private DataGridViewTextBoxColumn estoqueminimo;
        private DataGridViewTextBoxColumn classededesconto;
        private ComboBox cmbCategoria;
    }
}