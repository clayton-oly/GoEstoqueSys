using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoSys
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public string Perfil = string.Empty;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToLongDateString();
            data = data.Substring(0, 1).ToUpper() + data.Substring(1, data.Length - 1);
            stsData.Text = data;

           // frmSplash l = new frmSplash();
           // l.ShowDialog();

           // frmLogar lg = new frmLogar();
           // lg.ShowDialog();

            stUsuario.Text = frmLogar.usuarioConectado;
            //stPerfil.Text = frmLogar.usuarioPerfil ;
            if (frmLogar.usuarioPerfil == "GERENTE")
            {
                mBackup.Enabled = false;
            }
            if(frmLogar.usuarioPerfil == "ADMINISTRADOR")
            {
            }
            if(frmLogar.usuarioPerfil == "VENDEDOR")
            {
                mRelatorioProduto.Enabled = false;
                mBackup.Enabled = false;
                mCUsuario.Enabled = false;
                mEUsuario.Enabled = false;

            }


        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Deseja fechar?", "Encerrar GoSys",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroClientes fn = new frmCadastroClientes();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();
        }


        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultaClientes fn = new frmConsultaClientes();

            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);
            fn.Show();
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            //stsSegundos.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Deseja fechar?", "Encerrar GoSys",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCadastroClientes fn = new frmCadastroClientes();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

            frmCadastroFornecedor fn = new frmCadastroFornecedor();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);
            fn.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           frmCadastroProduto fn = new frmCadastroProduto();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);
            fn.Show();
        }


        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre fn = new frmSobre();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }


        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto fn = new frmCadastroProduto();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);
            fn.Show();
        }

        private void consultaGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientes fn = new frmConsultaClientes();

            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);
            fn.Show();
        }

        private void registosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor fn = new frmCadastroFornecedor();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);
            fn.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor fn = new frmCadastroFornecedor();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);
            fn.Show();
        }


        private void baToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup fn = new frmBackup();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();
        }

        private void relatorioGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda fn = new frmVenda();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();
        }

        private void geradorCBarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeradorBarras fn = new frmGeradorBarras();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();

        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogar fn = new frmLogar();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();

        }

        private void enviarEmailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmail fn = new frmEmail();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();
        }

        private void mCUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario fn = new frmCadastroUsuario();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();
        }

        private void vendas2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda2 fn = new frmVenda2();
            pnPrincipal.Controls.Clear();
            fn.TopLevel = false;
            pnPrincipal.Controls.Add(fn);

            fn.Show();
        }

        private void mCliente_Click(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}



