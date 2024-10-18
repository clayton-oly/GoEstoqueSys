using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace GoSys
{
    public partial class frmLogar : Form
    {

        public static string Acesso;
        public static bool logado = false;
        public static string usuarioConectado;
        public static string usuarioPerfil;



        public frmLogar()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            txtEmail.Visible = false;
            txtRecup.Visible = false;
            lbEmail.Visible = false;
            lbUsuario.Visible = false;
            lbEnviar.Visible = false;
            lbCancel.Visible = false;

            if (op == 1)
            {
                txtEmail.Visible = false;
                txtRecup.Visible = false;
                lbEmail.Visible = false;
                lbUsuario.Visible = false;
                lbEnviar.Visible = false;
                lbCancel.Visible = false;
            }
            if (op == 2)
            {
                txtEmail.Visible = true;
                txtRecup.Visible = true;
                lbEmail.Visible = true;
                lbUsuario.Visible = true;
                lbEnviar.Visible = true;
                lb_Recuperar.Visible = false;
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                btnLogar.Enabled = false;
                cmbNivel.Enabled = false;
                lbCancel.Visible = true;

            }
            if (op == 3)
            {
                txtEmail.Visible = false;
                txtRecup.Visible = false;
                lbEmail.Visible = false;
                lbUsuario.Visible = false;
                lbEnviar.Visible = false;
                lb_Recuperar.Visible = true;
                txtUsuario.Enabled = true;
                txtSenha.Enabled = true;
                btnLogar.Enabled = true;
                cmbNivel.Enabled = true;
                lbCancel.Visible = false;
                lbEmailVali.Visible = false;
         
            }
        }

        public void LimpaTela()
        {
            txtEmail.Clear();
            txtRecup.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();

        }

        public void logarR()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE login = @login AND senha = @senha AND NivelAcesso = @NivelAcesso");
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = txtUsuario.Text;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;
            cmd.Parameters.Add("@NivelAcesso", SqlDbType.VarChar).Value = cmbNivel.Text;

            cmd.Connection = Banco.abrir();

            SqlDataReader le = null;
            le = cmd.ExecuteReader();
            if (le.Read())
            {
                this.Hide();
                Acesso = cmbNivel.Text;
                MessageBox.Show("Bem vindo ao Sistema", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarioConectado = txtUsuario.Text;
                usuarioPerfil = cmbNivel.Text;
                logado = true;


            }
            else
            {
                MessageBox.Show("SENHA OU NIVEL DE ACESSO NÃO CONFEREM", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logado = false;

            }
        }


        private void frmLogar_Load(object sender, EventArgs e)
        {
            cmbNivel.SelectedIndex = 0;
            this.alteraBotoes(1);
            lbEmailVali.Visible = false;


        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O LOGIN E SENHA É OBRIGAORIO!");
                txtSenha.Focus();
                return;
            }


            this.logarR();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logarR();
            }
        }

        private void frmLogar_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                switch (e.CloseReason)
                {
                    case CloseReason.UserClosing:
                        e.Cancel = true;
                        break;

                }


            }
            catch (Exception)
            {

                base.OnFormClosing(e);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja sair", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void lbEnviar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("campo e-mail vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                }
                else if (txtRecup.Text == string.Empty)
                {
                    MessageBox.Show("campo Login vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                }

                else if (Validacao.ValidaEmail(txtEmail.Text) == false)
                {

                    MessageBox.Show("Por favor insira um E-mail válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                }

                else
                {
                    MailMessage mensagem = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    mensagem.From = new MailAddress("clayton.will08@gmail.com");
                    mensagem.To.Add("clayton.will08@gmail.com");
                    mensagem.Subject = ("Recuperação de Senha  " + txtEmail.Text);
                    mensagem.Body = (txtEmail.Text + "     " + txtRecup.Text);
                    mensagem.Priority = MailPriority.Normal;

                    //Configuracao SMTP para HOTMAIL
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Credentials = new System.Net.NetworkCredential("clayton.will08@gmail.com", "D@silva1996@");
                    smtp.Send(mensagem);

                    MessageBox.Show("Email de recuperação enviado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.alteraBotoes(3);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("erro ao enviar Email de recuperação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.alteraBotoes(3);
            this.LimpaTela();
        }


        private void lb_Recuperar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.alteraBotoes(2);
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (Validacao.ValidaEmail(txtEmail.Text) == false)
            {

                lbEmailVali.Visible = true;

            }
            else
            {
                lbEmailVali.Visible = false;
            }
        }
    }
}
