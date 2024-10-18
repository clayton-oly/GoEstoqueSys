namespace GoSys
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.label1 = new System.Windows.Forms.Label();
            this.dvgVendas = new System.Windows.Forms.DataGridView();
            this.txtCod_produto = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbCompra = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lbl_total_compra = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_desconto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVlrTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtqtd_produto_estoque = new System.Windows.Forms.TextBox();
            this.txtVlrProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Produto";
            // 
            // dvgVendas
            // 
            this.dvgVendas.AllowUserToAddRows = false;
            this.dvgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVendas.Location = new System.Drawing.Point(26, 79);
            this.dvgVendas.Margin = new System.Windows.Forms.Padding(4);
            this.dvgVendas.Name = "dvgVendas";
            this.dvgVendas.ReadOnly = true;
            this.dvgVendas.RowHeadersVisible = false;
            this.dvgVendas.RowTemplate.Height = 24;
            this.dvgVendas.Size = new System.Drawing.Size(804, 210);
            this.dvgVendas.TabIndex = 3;
            // 
            // txtCod_produto
            // 
            this.txtCod_produto.Location = new System.Drawing.Point(21, 54);
            this.txtCod_produto.Name = "txtCod_produto";
            this.txtCod_produto.Size = new System.Drawing.Size(185, 24);
            this.txtCod_produto.TabIndex = 4;
            this.txtCod_produto.TextChanged += new System.EventHandler(this.txtCod_produto_TextChanged);
            this.txtCod_produto.Validating += new System.ComponentModel.CancelEventHandler(this.txtCod_produto_Validating);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.Red;
            this.lbCodigo.Location = new System.Drawing.Point(16, 20);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(183, 55);
            this.lbCodigo.TabIndex = 5;
            this.lbCodigo.Text = "Código";
            // 
            // lbCompra
            // 
            this.lbCompra.AutoSize = true;
            this.lbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompra.Location = new System.Drawing.Point(27, 316);
            this.lbCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompra.Name = "lbCompra";
            this.lbCompra.Size = new System.Drawing.Size(179, 25);
            this.lbCompra.TabIndex = 6;
            this.lbCompra.Text = "Total da  compra:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(692, 310);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(138, 40);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(404, 310);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(138, 40);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar Produto";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(548, 310);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(138, 40);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.lbl_total_compra);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.dvgVendas);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.lbCodigo);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.lbCompra);
            this.groupBox1.Location = new System.Drawing.Point(14, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 376);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "data_nascimento";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LOJA"});
            this.comboBox1.Location = new System.Drawing.Point(290, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 26);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "data_nascimento";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DisplayMember = "data_nascimento";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "LOJA"});
            this.cmbCliente.Location = new System.Drawing.Point(645, 46);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(185, 26);
            this.cmbCliente.TabIndex = 21;
            this.cmbCliente.ValueMember = "data_nascimento";
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lbl_total_compra
            // 
            this.lbl_total_compra.AutoSize = true;
            this.lbl_total_compra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_compra.ForeColor = System.Drawing.Color.Red;
            this.lbl_total_compra.Location = new System.Drawing.Point(213, 316);
            this.lbl_total_compra.Name = "lbl_total_compra";
            this.lbl_total_compra.Size = new System.Drawing.Size(89, 25);
            this.lbl_total_compra.TabIndex = 11;
            this.lbl_total_compra.Text = "VENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cb_desconto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtVlrTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtqtd_produto_estoque);
            this.groupBox2.Controls.Add(this.txtVlrProd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtQuant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtnome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCod_produto);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 192);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "R$:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "R$:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Desconto %";
            // 
            // cb_desconto
            // 
            this.cb_desconto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_desconto.FormattingEnabled = true;
            this.cb_desconto.Items.AddRange(new object[] {
            "NENHUM",
            "3%",
            "5%",
            "10%",
            "15%",
            "20%"});
            this.cb_desconto.Location = new System.Drawing.Point(652, 128);
            this.cb_desconto.Name = "cb_desconto";
            this.cb_desconto.Size = new System.Drawing.Size(185, 26);
            this.cb_desconto.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Valor Total";
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(451, 130);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.ReadOnly = true;
            this.txtVlrTotal.Size = new System.Drawing.Size(185, 24);
            this.txtVlrTotal.TabIndex = 15;
            this.txtVlrTotal.TextChanged += new System.EventHandler(this.txtVlrTotal_TextChanged);
            this.txtVlrTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrTotal_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantidade Estoque";
            // 
            // txtqtd_produto_estoque
            // 
            this.txtqtd_produto_estoque.Location = new System.Drawing.Point(21, 130);
            this.txtqtd_produto_estoque.Name = "txtqtd_produto_estoque";
            this.txtqtd_produto_estoque.ReadOnly = true;
            this.txtqtd_produto_estoque.Size = new System.Drawing.Size(185, 24);
            this.txtqtd_produto_estoque.TabIndex = 13;
            // 
            // txtVlrProd
            // 
            this.txtVlrProd.Location = new System.Drawing.Point(247, 130);
            this.txtVlrProd.Name = "txtVlrProd";
            this.txtVlrProd.ReadOnly = true;
            this.txtVlrProd.Size = new System.Drawing.Size(151, 24);
            this.txtVlrProd.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(652, 54);
            this.txtQuant.MaxLength = 3;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(185, 24);
            this.txtQuant.TabIndex = 11;
            this.txtQuant.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuant_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome do Produto";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(223, 54);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(413, 24);
            this.txtnome.TabIndex = 5;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgVendas;
        private System.Windows.Forms.TextBox txtCod_produto;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbCompra;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_desconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtqtd_produto_estoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtVlrProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total_compra;
        private System.Windows.Forms.TextBox txtVlrTotal;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}