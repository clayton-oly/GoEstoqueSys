namespace GoSys
{
    partial class frmConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCompl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCPF);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar pelo:";
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(18, 64);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(100, 22);
            this.rbCPF.TabIndex = 1;
            this.rbCPF.Text = "CPF/CNPJ";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(18, 33);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(67, 22);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(728, 76);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(144, 36);
            this.btLocalizar.TabIndex = 11;
            this.btLocalizar.Text = " ";
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(213, 41);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(658, 24);
            this.txtValor.TabIndex = 10;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCPF,
            this.clnData,
            this.clnTelefone,
            this.clnEmail,
            this.clnCEP,
            this.clnEnd,
            this.clnBairro,
            this.clnCompl,
            this.clnCidade,
            this.clnEstado,
            this.clnNum});
            this.dgvClientes.Location = new System.Drawing.Point(13, 124);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(858, 476);
            this.dgvClientes.TabIndex = 17;
            this.dgvClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentDoubleClick);
            // 
            // clnId
            // 
            this.clnId.FillWeight = 72.99879F;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.Width = 50;
            // 
            // clnNome
            // 
            this.clnNome.FillWeight = 111.8956F;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            // 
            // clnCPF
            // 
            this.clnCPF.FillWeight = 93.62366F;
            this.clnCPF.HeaderText = "CPF";
            this.clnCPF.MinimumWidth = 15;
            this.clnCPF.Name = "clnCPF";
            // 
            // clnData
            // 
            this.clnData.FillWeight = 222.4679F;
            this.clnData.HeaderText = "Nascimento";
            this.clnData.Name = "clnData";
            // 
            // clnTelefone
            // 
            this.clnTelefone.FillWeight = 113.5312F;
            this.clnTelefone.HeaderText = "Telefone";
            this.clnTelefone.Name = "clnTelefone";
            // 
            // clnEmail
            // 
            this.clnEmail.FillWeight = 89.49163F;
            this.clnEmail.HeaderText = "E-mail";
            this.clnEmail.Name = "clnEmail";
            // 
            // clnCEP
            // 
            this.clnCEP.FillWeight = 73.51005F;
            this.clnCEP.HeaderText = "CEP";
            this.clnCEP.Name = "clnCEP";
            // 
            // clnEnd
            // 
            this.clnEnd.FillWeight = 108.5003F;
            this.clnEnd.HeaderText = "Endereço";
            this.clnEnd.Name = "clnEnd";
            // 
            // clnBairro
            // 
            this.clnBairro.FillWeight = 76.12125F;
            this.clnBairro.HeaderText = "Bairro";
            this.clnBairro.Name = "clnBairro";
            // 
            // clnCompl
            // 
            this.clnCompl.FillWeight = 127.2728F;
            this.clnCompl.HeaderText = "Complemento";
            this.clnCompl.Name = "clnCompl";
            this.clnCompl.Width = 130;
            // 
            // clnCidade
            // 
            this.clnCidade.FillWeight = 70.89091F;
            this.clnCidade.HeaderText = "Cidade";
            this.clnCidade.Name = "clnCidade";
            // 
            // clnEstado
            // 
            this.clnEstado.FillWeight = 68.57716F;
            this.clnEstado.HeaderText = "Estado";
            this.clnEstado.Name = "clnEstado";
            // 
            // clnNum
            // 
            this.clnNum.FillWeight = 71.11874F;
            this.clnNum.HeaderText = "Numero";
            this.clnNum.Name = "clnNum";
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 613);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaClientes";
            this.Text = "Consulta Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCompl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNum;
    }
}