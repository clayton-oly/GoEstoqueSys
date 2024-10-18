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


namespace GoSys
{
    public partial class frmCadastroClientes : Form
    {
        public String operacao;
        public frmCadastroClientes()
        {
            InitializeComponent();
        }
       
        public void alteraBotoes(int op)
        {
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnConsultar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelUp.Visible = false;

            if (op == 1)
            {
                btnNovo.Enabled = true;
         
            }
            if (op == 2)
            {
                btnInserir.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;
            }
            if (op == 3)
            {
                btnSalvar.Visible = true;
                btnCancelUp.Visible = true;
                btnSalvar.Enabled = true;  
                btnCancelUp.Enabled = true;
                btnNovo.Enabled = false;
            }
            if (op == 4)
            {
                btnAlterar.Enabled = true;  
                btnSalvar.Enabled = true;
            }
            if (op == 5)
            {
                btnAlterar.Enabled = true;   

            }


            if (op == 6)
            {
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
            }
        }


        public void desabilitaControles()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtCPFCNPJ.Enabled = false;
            txtEmail.Enabled = false;
            txtData.Enabled = false;
            txTelefone.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCompl.Enabled = false;
            mskCEP.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtNum.Enabled = false;


        }
        public void habilitaControles()
        {
            txtNome.Enabled = true;
            txtCPFCNPJ.Enabled = true;
            txtEmail.Enabled = true;
            txtData.Enabled = true;
            txTelefone.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCompl.Enabled = true;
            mskCEP.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtNum.Enabled = true;
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCPFCNPJ.Clear();
            txtEmail.Clear();
            txTelefone.Clear();
            txtData.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
            txtCompl.Clear();
            txtRua.Clear();
            txtNum.Clear();
            mskCEP.Clear();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(3);
            this.habilitaControles();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                   this.txtNome.Focus();

                }

                else if (txtCPFCNPJ.Text == string.Empty)
                {
                    MessageBox.Show("campo CPF vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    this.txtCPFCNPJ.Focus();
                }



                else if (txTelefone.Text == string.Empty)
                {
                    MessageBox.Show("campo Telefone vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txTelefone.Focus();
                }

                else if (Validacao.Cpf(txtCPFCNPJ.Text) == false)
                {

                    MessageBox.Show("Por favor insira um CPF válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCPFCNPJ.Focus();
                }


                else
                {
                        Clientes C = new Clientes();
                        C.Nome = txtNome.Text;
                        C.Cpf = txtCPFCNPJ.Text;
                        C.Datanasc = txtData.Text;
                        C.Telefone = txTelefone.Text;
                        C.Email = txtEmail.Text;
                        C.Cep = mskCEP.Text;
                        C.Endereco = txtRua.Text;
                        C.Bairro = txtBairro.Text;
                        C.Complemento = txtCompl.Text;
                        C.Cidade = txtCidade.Text;
                        C.Uf = txtEstado.Text;
                        C.Num = txtNum.Text;
                        // LIMPA OS PONTOS
                        //txtCPFCNPJ.Text = txtCPFCNPJ.Text.Replace(".", "");
                        //txtCPFCNPJ.Text = txtCPFCNPJ.Text.Replace("-", "");
                        //txtCPFCNPJ.Text = txtCPFCNPJ.Text.Replace("/", "");

                        C.inserir();
                        txtCodigo.Text = C.Id.ToString();
                        MessageBox.Show("Cliente Cadastrado com sucesso!", " Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.alteraBotoes(1);
                        this.desabilitaControles();
                        lbEmail.Visible = false;
                        lbCPFINVALIDO.Visible = false;
                        this.LimpaTela();

                    }

                }

            catch (Exception)
            {

                MessageBox.Show("CPF já cadastrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void btnCep_Click_1(object sender, EventArgs e)
        {
            WebCEP(mskCEP.Text);
            txtRua.Focus();
        }

        public void WebCEP(string CEP)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" +
                CEP.Replace("-", "").Trim() + "&formato=xml");
            txtRua.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim() +
                " " + ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
            txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
            txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
            txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString().Trim();


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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes C = new Clientes();
                if (C.consultar(Convert.ToInt32(txtCodigo.Text)) == true)
                {
                    txtNome.Text = C.Nome;
                    txtCPFCNPJ.Text = C.Cpf;
                    txtEmail.Text = C.Email;
                    txtData.Text = C.Datanasc;
                    txTelefone.Text = C.Telefone;
                    txtRua.Text = C.Endereco;
                    txtNum.Text = C.Num;
                    txtBairro.Text = C.Bairro;
                    txtCidade.Text = C.Cidade;
                    txtEstado.Text = C.Uf;
                    txtCompl.Text = C.Complemento;
                    mskCEP.Text = C.Cep;
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Cliente não cadastrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       


        private void btnCancelar_Click(object sender, EventArgs e)

        {
            this.LimpaTela();
            this.desabilitaControles();
            this.alteraBotoes(1);
      
        }
 
        public void solonumero(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception )
            {
              

            }

        }

        public void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {


            }

        }


        private void txtCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                solonumero(e);


                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtCPFCNPJ.TextLength)
                    {

                        case 0:
                            txtCPFCNPJ.Text = "";
                            break;

                        case 3:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + ".";
                            txtCPFCNPJ.SelectionStart = 5;
                            break;

                        case 7:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + ".";
                            txtCPFCNPJ.SelectionStart = 9;
                            break;

                        case 11:
                            txtCPFCNPJ.Text = txtCPFCNPJ.Text + "-";
                            txtCPFCNPJ.SelectionStart = 12;
                            break;

                    }


                }

            }
            catch (Exception)
            {

            }
       
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                solonumero(e);


                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtData.TextLength)
                    {

                        case 0:
                            txtData.Text = "";
                            break;
                        case 2:
                            txtData.Text = txtData.Text + "/";
                            txtData.SelectionStart = 4;

                            break;

                        case 5:
                            txtData.Text = txtData.Text + "/";
                            txtData.SelectionStart = 9;

                            break;
                    }

                }

            }
            catch (Exception)
            {

            }
        }

        private void mskCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                solonumero(e);


                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (mskCEP.TextLength)
                    {

                        case 0:
                            mskCEP.Text = "";
                            break;
                        case 5:
                            mskCEP.Text = mskCEP.Text + "-";
                            mskCEP.SelectionStart = 8;

                            break;

                    }
                }

            }
            catch (Exception)
            {

          
            }
           
        }


        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                solonumero(e);

                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txTelefone.TextLength)
                    {

                        case 0:
                            txTelefone.Text = "(";
                            txTelefone.SelectionStart = 2;
                            break;

                        case 3:
                            txTelefone.Text = txTelefone.Text + ")";
                            txTelefone.SelectionStart = 5;
                            break;

                        case 9:
                            txTelefone.Text = txTelefone.Text + "-";
                            txTelefone.SelectionStart = 11;
                            break;
                    }
                }

            }
            catch (Exception)
            {
                
            }
           
        }

        private void frmClientes_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    this.LimpaTela();
                    btnAlterar.Enabled = false;
                }

                if (e.KeyCode == Keys.F6)
                {
                    txtCPFCNPJ.Focus();
                    Clipboard.SetText(txtCPFCNPJ.Text);

                }
                if (e.KeyCode == Keys.F7)
                {
                    txtNome.Focus();
                    Clipboard.SetText(txtNome.Text);

                }

                if (e.KeyCode == Keys.F8)
                {
                    txTelefone.Focus();
                    Clipboard.SetText(txTelefone.Text);

                }

                if (e.KeyCode == Keys.F9)
                {
                    txTelefone.Focus();

                    DialogResult result;
                    result = MessageBox.Show("Deseja fechar?", "Encerrar GoSys",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);


                    if (result == DialogResult.Yes)
                    {

                        this.LimpaTela();
                        this.Close();
                    }

                }

            }
            catch (Exception)
            {

                
            }
   
                
       }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaControles();
            txtNome.Focus();
            this.alteraBotoes(2);
            this.LimpaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    this.txtNome.Focus();

                }

                else if (txtCPFCNPJ.Text == string.Empty)
                {
                    MessageBox.Show("campo CPF vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    this.txtCPFCNPJ.Focus();
                }



                else if (txTelefone.Text == string.Empty)
                {
                    MessageBox.Show("campo Telefone vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txTelefone.Focus();
                }

                else if (Validacao.Cpf(txtCPFCNPJ.Text) == false)
                {

                    MessageBox.Show("Por favor insira um CPF válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCPFCNPJ.Focus();
                }


                else
                {

                    SqlCommand comm = new SqlCommand();
                    comm.Connection = Banco.abrir();
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "sp_alteraCliente";
                    comm.Parameters.Add("@id_cliente", SqlDbType.Int).Value = txtCodigo.Text;
                    comm.Parameters.Add("@nome_cliente", SqlDbType.VarChar).Value = txtNome.Text;
                    comm.Parameters.Add("@cpf_cliente", SqlDbType.Char).Value = txtCPFCNPJ.Text;
                    comm.Parameters.Add("@data_nascimento", SqlDbType.VarChar).Value = txtData.Text;
                    comm.Parameters.Add("@telefone_cliente", SqlDbType.VarChar).Value = txTelefone.Text;
                    comm.Parameters.Add("@email_cliente", SqlDbType.VarChar).Value = txtEmail.Text;
                    comm.Parameters.Add("@cep", SqlDbType.Char).Value = mskCEP.Text;
                    comm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtRua.Text;
                    comm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtBairro.Text;
                    comm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = txtCompl.Text;
                    comm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text;
                    comm.Parameters.Add("@estado", SqlDbType.Char).Value = txtEstado.Text;
                    comm.Parameters.Add("@numero_end", SqlDbType.VarChar).Value = txtNum.Text;
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    this.alteraBotoes(6);
                    this.desabilitaControles();
                    MessageBox.Show("Dados salvos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
            }

            catch (Exception)
            {

                MessageBox.Show("Não foi possivel salvar dados, verifique se os campos foi preenchido corretamente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnCancelUp_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(6);
            this.desabilitaControles();
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.LimpaTela();
        }

        private void txtCPFCNPJ_Validated(object sender, EventArgs e)
        {
            if (Validacao.Cpf(txtCPFCNPJ.Text) == false)
            {
                lbCPFINVALIDO.Visible = true;
            }
            else
            {
                lbCPFINVALIDO.Visible = false;
            }

        }

        private void btnSAIR_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            desabilitaControles();
            this.alteraBotoes(1);
            btnAlterar.Enabled = false;
            lbCPFINVALIDO.Visible = false;

            if (Program.idtransferido != 0)
            {
                txtCodigo.Text = Program.idtransferido.ToString();
                btnConsultar_Click(sender, e);

                this.alteraBotoes(4);
            }

        }
    }
}
    
    







