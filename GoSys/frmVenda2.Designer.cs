namespace GoSys
{
    partial class frmVenda2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVlrTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_Descontos = new System.Windows.Forms.ComboBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtItens = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgVendas = new System.Windows.Forms.DataGridView();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmitente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.btnDestinatario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEmitente = new System.Windows.Forms.Button();
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVendas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVlrTotal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cb_Descontos);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.txtItens);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.txtIdPedido);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dvgVendas);
            this.groupBox1.Controls.Add(this.txtQuant);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.txtValorUnitario);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEstoque);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(13, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(860, 443);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(480, 44);
            this.txtVlrTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.ReadOnly = true;
            this.txtVlrTotal.Size = new System.Drawing.Size(100, 24);
            this.txtVlrTotal.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 18);
            this.label14.TabIndex = 51;
            this.label14.Text = "Valor Total";
            // 
            // cb_Descontos
            // 
            this.cb_Descontos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Descontos.FormattingEnabled = true;
            this.cb_Descontos.Items.AddRange(new object[] {
            "NENHUM",
            "3%",
            "5%",
            "10%",
            "15%",
            "20%"});
            this.cb_Descontos.Location = new System.Drawing.Point(638, 43);
            this.cb_Descontos.Name = "cb_Descontos";
            this.cb_Descontos.Size = new System.Drawing.Size(100, 26);
            this.cb_Descontos.TabIndex = 50;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(739, 398);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(104, 28);
            this.btnFechar.TabIndex = 49;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtItens
            // 
            this.txtItens.Location = new System.Drawing.Point(70, 348);
            this.txtItens.Margin = new System.Windows.Forms.Padding(4);
            this.txtItens.Name = "txtItens";
            this.txtItens.ReadOnly = true;
            this.txtItens.Size = new System.Drawing.Size(148, 24);
            this.txtItens.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Itens:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(627, 398);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 28);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Total da Venda:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(354, 349);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(148, 24);
            this.txtValor.TabIndex = 43;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(515, 398);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(104, 28);
            this.btnFinalizar.TabIndex = 47;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(9, 44);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(68, 24);
            this.txtIdPedido.TabIndex = 40;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(672, 347);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(81, 28);
            this.btnAlterar.TabIndex = 45;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(762, 347);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 28);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(85, 44);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(173, 24);
            this.txtProduto.TabIndex = 39;
            this.txtProduto.Validating += new System.ComponentModel.CancelEventHandler(this.txtProduto_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Quantidade";
            // 
            // dvgVendas
            // 
            this.dvgVendas.AllowUserToAddRows = false;
            this.dvgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVendas.Location = new System.Drawing.Point(9, 78);
            this.dvgVendas.Margin = new System.Windows.Forms.Padding(6);
            this.dvgVendas.Name = "dvgVendas";
            this.dvgVendas.ReadOnly = true;
            this.dvgVendas.RowHeadersVisible = false;
            this.dvgVendas.RowTemplate.Height = 24;
            this.dvgVendas.Size = new System.Drawing.Size(834, 256);
            this.dvgVendas.TabIndex = 3;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(263, 44);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(100, 24);
            this.txtQuant.TabIndex = 36;
            this.txtQuant.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuant_Validating);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(583, 347);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(81, 28);
            this.btnInserir.TabIndex = 35;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(371, 44);
            this.txtValorUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ReadOnly = true;
            this.txtValorUnitario.Size = new System.Drawing.Size(100, 24);
            this.txtValorUnitario.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(742, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 33;
            this.label13.Text = "Estoque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "C.Produto";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(745, 43);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(100, 24);
            this.txtEstoque.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Valor Unitario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Desconto %";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtEmitente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCodigoVenda);
            this.groupBox2.Controls.Add(this.btnDestinatario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnEmitente);
            this.groupBox2.Controls.Add(this.txtOperacao);
            this.groupBox2.Controls.Add(this.txtSituacao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(860, 144);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "LOJA"});
            this.cmbCliente.Location = new System.Drawing.Point(15, 100);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(428, 26);
            this.cmbCliente.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cliente";
            // 
            // txtEmitente
            // 
            this.txtEmitente.Location = new System.Drawing.Point(15, 44);
            this.txtEmitente.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmitente.Name = "txtEmitente";
            this.txtEmitente.ReadOnly = true;
            this.txtEmitente.Size = new System.Drawing.Size(428, 24);
            this.txtEmitente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedor";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(534, 44);
            this.txtCodigoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.ReadOnly = true;
            this.txtCodigoVenda.Size = new System.Drawing.Size(148, 24);
            this.txtCodigoVenda.TabIndex = 5;
            // 
            // btnDestinatario
            // 
            this.btnDestinatario.Location = new System.Drawing.Point(455, 98);
            this.btnDestinatario.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestinatario.Name = "btnDestinatario";
            this.btnDestinatario.Size = new System.Drawing.Size(57, 28);
            this.btnDestinatario.TabIndex = 28;
            this.btnDestinatario.Text = "...";
            this.btnDestinatario.UseVisualStyleBackColor = true;
            this.btnDestinatario.Click += new System.EventHandler(this.btnDestinatario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código Venda";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(695, 44);
            this.txtData.Margin = new System.Windows.Forms.Padding(4);
            this.txtData.MaxLength = 3;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(148, 24);
            this.txtData.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Operação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data";
            // 
            // btnEmitente
            // 
            this.btnEmitente.Location = new System.Drawing.Point(455, 44);
            this.btnEmitente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmitente.Name = "btnEmitente";
            this.btnEmitente.Size = new System.Drawing.Size(57, 28);
            this.btnEmitente.TabIndex = 23;
            this.btnEmitente.Text = "...";
            this.btnEmitente.UseVisualStyleBackColor = true;
            this.btnEmitente.Click += new System.EventHandler(this.btnEmitente_Click);
            // 
            // txtOperacao
            // 
            this.txtOperacao.Location = new System.Drawing.Point(534, 98);
            this.txtOperacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.ReadOnly = true;
            this.txtOperacao.Size = new System.Drawing.Size(148, 24);
            this.txtOperacao.TabIndex = 26;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(695, 98);
            this.txtSituacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtSituacao.MaxLength = 3;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(148, 24);
            this.txtSituacao.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Situação";
            // 
            // frmVenda2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVenda2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenda2";
            this.Load += new System.EventHandler(this.frmVenda2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVendas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgVendas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmitente;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtItens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDestinatario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEmitente;
        private System.Windows.Forms.TextBox txtOperacao;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cb_Descontos;
        private System.Windows.Forms.TextBox txtVlrTotal;
        private System.Windows.Forms.Label label14;
    }
}