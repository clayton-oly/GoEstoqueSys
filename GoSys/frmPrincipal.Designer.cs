namespace GoSys
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCliente2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mFornecedor2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mProduto2 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.vendas2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRelatorioProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEnviar = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.mGerador = new System.Windows.Forms.ToolStripMenuItem();
            this.confToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mEUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mASenha = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mSair = new System.Windows.Forms.ToolStripMenuItem();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCliente,
            this.consultasToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.confToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1080, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mCliente
            // 
            this.mCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.mFornecedor,
            this.mProduto,
            this.testeToolStripMenuItem});
            this.mCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCliente.Name = "mCliente";
            this.mCliente.Size = new System.Drawing.Size(89, 25);
            this.mCliente.Text = "&Cadastro";
            this.mCliente.Click += new System.EventHandler(this.mCliente_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.clientesToolStripMenuItem.Text = "Cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mFornecedor
            // 
            this.mFornecedor.Name = "mFornecedor";
            this.mFornecedor.Size = new System.Drawing.Size(166, 26);
            this.mFornecedor.Text = "Fornecedor";
            this.mFornecedor.Click += new System.EventHandler(this.registosToolStripMenuItem_Click);
            // 
            // mProduto
            // 
            this.mProduto.Name = "mProduto";
            this.mProduto.Size = new System.Drawing.Size(166, 26);
            this.mProduto.Text = "Produto";
            this.mProduto.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCliente2,
            this.mFornecedor2,
            this.mProduto2});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.consultasToolStripMenuItem.Text = "Consulta";
            // 
            // mCliente2
            // 
            this.mCliente2.Name = "mCliente2";
            this.mCliente2.Size = new System.Drawing.Size(166, 26);
            this.mCliente2.Text = "Cliente";
            this.mCliente2.Click += new System.EventHandler(this.consultaGeralToolStripMenuItem_Click);
            // 
            // mFornecedor2
            // 
            this.mFornecedor2.Name = "mFornecedor2";
            this.mFornecedor2.Size = new System.Drawing.Size(166, 26);
            this.mFornecedor2.Text = "Fornecedor";
            this.mFornecedor2.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // mProduto2
            // 
            this.mProduto2.Name = "mProduto2";
            this.mProduto2.Size = new System.Drawing.Size(166, 26);
            this.mProduto2.Text = "Produto";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mVenda,
            this.vendas2ToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(137, 25);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // mVenda
            // 
            this.mVenda.Name = "mVenda";
            this.mVenda.Size = new System.Drawing.Size(148, 26);
            this.mVenda.Text = "Venda";
            this.mVenda.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // vendas2ToolStripMenuItem
            // 
            this.vendas2ToolStripMenuItem.Name = "vendas2ToolStripMenuItem";
            this.vendas2ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.vendas2ToolStripMenuItem.Text = "Vendas 2";
            this.vendas2ToolStripMenuItem.Click += new System.EventHandler(this.vendas2ToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRelatorioProduto});
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // mRelatorioProduto
            // 
            this.mRelatorioProduto.Name = "mRelatorioProduto";
            this.mRelatorioProduto.Size = new System.Drawing.Size(239, 26);
            this.mRelatorioProduto.Text = "Relatorio de Produto";
            this.mRelatorioProduto.Click += new System.EventHandler(this.relatorioGeralToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEnviar,
            this.calculadoraToolStripMenuItem,
            this.explorerToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem,
            this.mBackup,
            this.mGerador});
            this.ferramentasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // mEnviar
            // 
            this.mEnviar.Name = "mEnviar";
            this.mEnviar.Size = new System.Drawing.Size(286, 26);
            this.mEnviar.Text = "Enviar E-mail";
            this.mEnviar.Click += new System.EventHandler(this.enviarEmailToolStripMenuItem1_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.explorerToolStripMenuItem.Text = "Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // mBackup
            // 
            this.mBackup.Name = "mBackup";
            this.mBackup.Size = new System.Drawing.Size(286, 26);
            this.mBackup.Text = "Backup do banco de Dados";
            this.mBackup.Click += new System.EventHandler(this.baToolStripMenuItem_Click);
            // 
            // mGerador
            // 
            this.mGerador.Name = "mGerador";
            this.mGerador.Size = new System.Drawing.Size(286, 26);
            this.mGerador.Text = "Gerador Código de Barras";
            this.mGerador.Click += new System.EventHandler(this.geradorCBarrasToolStripMenuItem_Click);
            // 
            // confToolStripMenuItem
            // 
            this.confToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCUsuario,
            this.mEUsuario,
            this.mASenha});
            this.confToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confToolStripMenuItem.Name = "confToolStripMenuItem";
            this.confToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.confToolStripMenuItem.Text = "Usuario";
            // 
            // mCUsuario
            // 
            this.mCUsuario.Name = "mCUsuario";
            this.mCUsuario.Size = new System.Drawing.Size(215, 26);
            this.mCUsuario.Text = "Cadastrar Usuario";
            this.mCUsuario.Click += new System.EventHandler(this.mCUsuario_Click);
            // 
            // mEUsuario
            // 
            this.mEUsuario.Name = "mEUsuario";
            this.mEUsuario.Size = new System.Drawing.Size(215, 26);
            this.mEUsuario.Text = "Editar Usuario";
            // 
            // mASenha
            // 
            this.mASenha.Name = "mASenha";
            this.mASenha.Size = new System.Drawing.Size(215, 26);
            this.mASenha.Text = "Alterar Senha";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjuda,
            this.sairToolStripMenuItem,
            this.mSobre,
            this.mSair});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // mAjuda
            // 
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(125, 26);
            this.mAjuda.Text = "Ajuda";
            this.mAjuda.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(122, 6);
            // 
            // mSobre
            // 
            this.mSobre.Name = "mSobre";
            this.mSobre.Size = new System.Drawing.Size(125, 26);
            this.mSobre.Text = "Sobre";
            this.mSobre.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // mSair
            // 
            this.mSair.Name = "mSair";
            this.mSair.Size = new System.Drawing.Size(125, 26);
            this.mSair.Text = "Sair";
            this.mSair.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // timerData
            // 
            this.timerData.Enabled = true;
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(4, 135);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(123, 123);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(4, 4);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(123, 123);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(4, 528);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 120);
            this.btnSair.TabIndex = 4;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.Location = new System.Drawing.Point(4, 397);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(123, 123);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(4, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 123);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnConsultas, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSair, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnClientes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConfig, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(131, 656);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnPrincipal.Location = new System.Drawing.Point(168, 37);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(900, 652);
            this.pnPrincipal.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Aqua;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.stUsuario,
            this.toolStripStatusLabel1,
            this.stsData,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 732);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 25);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Aqua;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(80, 20);
            this.toolStripStatusLabel4.Text = "USUÁRIO:";
            // 
            // stUsuario
            // 
            this.stUsuario.BackColor = System.Drawing.Color.Aqua;
            this.stUsuario.Name = "stUsuario";
            this.stUsuario.Size = new System.Drawing.Size(119, 20);
            this.stUsuario.Text = "Usuario Logado";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Aqua;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(509, 20);
            this.toolStripStatusLabel1.Text = "                                                                                 " +
    "                                            ";
            // 
            // stsData
            // 
            this.stsData.Name = "stsData";
            this.stsData.Size = new System.Drawing.Size(62, 20);
            this.stsData.Text = "stsData";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Aqua;
            this.toolStripStatusLabel5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel5.Image")));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatusLabel5.Text = "Version 1.0";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.testeToolStripMenuItem.Text = "Teste";
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 757);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mCliente;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mFornecedor;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCliente2;
        private System.Windows.Forms.ToolStripMenuItem mFornecedor2;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRelatorioProduto;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAjuda;
        private System.Windows.Forms.ToolStripSeparator sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSair;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem mSobre;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mProduto;
        private System.Windows.Forms.ToolStripMenuItem mProduto2;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mVenda;
        private System.Windows.Forms.ToolStripMenuItem mBackup;
        public System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mGerador;
        private System.Windows.Forms.ToolStripMenuItem mEnviar;
        private System.Windows.Forms.ToolStripMenuItem confToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCUsuario;
        private System.Windows.Forms.ToolStripMenuItem mEUsuario;
        private System.Windows.Forms.ToolStripMenuItem mASenha;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel stUsuario;
        private System.Windows.Forms.ToolStripStatusLabel stsData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem vendas2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
    }
}

