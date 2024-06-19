namespace ComercialSys
{
    partial class FrmPedido
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtVendedor = new TextBox();
            textBox4 = new TextBox();
            btnAbrirPedido = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label5 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox10 = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(60, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 95);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(402, 23);
            textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.ForeColor = SystemColors.HotTrack;
            textBox1.Location = new Point(616, 46);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(100, 50);
            textBox1.TabIndex = 2;
            textBox1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(60, 46);
            label2.Name = "label2";
            label2.Size = new Size(40, 13);
            label2.TabIndex = 0;
            label2.Text = "Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(60, 77);
            label3.Name = "label3";
            label3.Size = new Size(53, 13);
            label3.TabIndex = 0;
            label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(134, 73);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(259, 23);
            txtVendedor.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(663, 384);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(85, 23);
            textBox4.TabIndex = 0;
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Font = new Font("Segoe UI", 9F);
            btnAbrirPedido.Location = new Point(523, 42);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(71, 32);
            btnAbrirPedido.TabIndex = 1;
            btnAbrirPedido.Text = "&Inserir";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            btnAbrirPedido.Click += btnAbrirPedido_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnAbrirPedido);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(60, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(597, 98);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(597, 169);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(663, 490);
            button1.Name = "button1";
            button1.Size = new Size(116, 38);
            button1.TabIndex = 5;
            button1.Text = "Finalizar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(663, 413);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(85, 23);
            textBox5.TabIndex = 0;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 18F);
            textBox6.Location = new Point(663, 442);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(116, 39);
            textBox6.TabIndex = 0;
            textBox6.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(6, 32);
            label4.Name = "label4";
            label4.Size = new Size(88, 13);
            label4.TabIndex = 0;
            label4.Text = "Código de Barras";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.Location = new Point(127, 32);
            label6.Name = "label6";
            label6.Size = new Size(55, 13);
            label6.TabIndex = 0;
            label6.Text = "Descrição";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(6, 48);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(115, 23);
            textBox8.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(127, 48);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(217, 23);
            textBox9.TabIndex = 0;
            textBox9.TextChanged += this.textBox9_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F);
            label5.Location = new Point(350, 32);
            label5.Name = "label5";
            label5.Size = new Size(70, 13);
            label5.TabIndex = 0;
            label5.Text = "Valor Unitário";
            label5.Click += label5_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(350, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(85, 23);
            textBox7.TabIndex = 0;
            textBox7.TextChanged += this.textBox9_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F);
            label7.Location = new Point(455, 32);
            label7.Name = "label7";
            label7.Size = new Size(62, 13);
            label7.TabIndex = 0;
            label7.Text = "Quantidade";
            label7.Click += label5_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(455, 48);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(62, 23);
            textBox10.TabIndex = 0;
            textBox10.TextChanged += this.textBox9_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(583, 217);
            button2.Name = "button2";
            button2.Size = new Size(71, 32);
            button2.TabIndex = 1;
            button2.Text = "&Abrir ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAbrirPedido_Click;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 535);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(txtVendedor);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrirPedido;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox10;
        private Button button2;
    }
}