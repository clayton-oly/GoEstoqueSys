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
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }
        public static ListBox anexo = new ListBox();

        bool arq;

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Endereço de email obrigatório", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                  else if (txtEmail.Text == string.Empty)
                {

                    MessageBox.Show("Por favor insira o email ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtEmail.Focus();
                }
                else if (txtSenha.Text == string.Empty)
                {

                    MessageBox.Show("Por favor insira uma senha ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtSenha.Focus();
                }

                else if (Validacao.ValidaEmail(txtEmail.Text) == false)
                {

                    MessageBox.Show("Por favor insira um E-mail válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtEmail.Focus();
                }

                else if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("senha é obrigatório", "senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                  
                    btnLogar.Enabled = false;
                    txtEmail.Enabled = false;
                    txtSenha.Enabled = false;
                    groupBox2.Enabled = true;
                    btnDeslogar.Enabled = true;
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
          

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Envio send = new Envio();
                send.Enviar(arq, txtEmail.Text, txtSenha.Text, txtPara.Text, txtCc.Text, txtCco.Text, txtAssunto.Text, rtbAssunto.Text);
                if (Envio.erro == true)
                {
                    MessageBox.Show("Endereço de email destinatario e obrigatorio","Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Email Enviado com sucesso", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();
                }

            }
            catch (Exception )
            {

                MessageBox.Show("email ou senha inválido tente logar novamente", "informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string file = dialog.FileName;
                    listBox1.Items.Add(file);
                    anexo.Items.Add(file);
                    arq = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                anexo.Items.Remove(listBox1.SelectedItem);
                btnAnexar.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void listBox1_SelectedItem(object sender, EventArgs e)
        {
            try
            {
                btnAnexar.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            btnDeslogar.Enabled = false;
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (Validacao.ValidaEmail(txtEmail.Text) == false)
            {

                lbEmail.Visible = true;

            }
            else
            {
                lbEmail.Visible = false;
            }
        }

            public void desabilitaControles()
        {
            btnLogar.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            groupBox2.Enabled = false;



        }
        public void habilitaControles()
        {
            btnLogar.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            groupBox2.Enabled = true;

        }

        public void LimpaTela()
        {
            txtAssunto.Clear();
            txtCc.Clear();
            txtCco.Clear();
            txtPara.Clear();
            rtbAssunto.Clear();
            listBox1.Items.Clear();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            groupBox2.Enabled = false;
            txtEmail.Clear();
            txtSenha.Clear();
            btnDeslogar.Enabled = false;
            btnLogar.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }
    }

 }

