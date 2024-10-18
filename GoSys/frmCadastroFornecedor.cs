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
    public partial class frmCadastroFornecedor : Form
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public String operacao;

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
            catch (Exception)
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

        public void CNPJMETODO(KeyPressEventArgs a)
        {
            if (char.IsNumber(a.KeyChar) == true)
            {
                switch (txtCNPJ.TextLength)
                {

                    case 0:
                        txtCNPJ.Text = "";
                        break;

                    case 2:
                        txtCNPJ.Text = txtCNPJ.Text + ".";
                        txtCNPJ.SelectionStart = 4;
                        break;

                    case 6:
                        txtCNPJ.Text = txtCNPJ.Text + ".";
                        txtCNPJ.SelectionStart = 8;
                        break;

                    case 10:
                        txtCNPJ.Text = txtCNPJ.Text + "/";
                        txtCNPJ.SelectionStart = 12;
                        break;

                    case 15:
                        txtCNPJ.Text = txtCNPJ.Text + "-";
                        txtCNPJ.SelectionStart = 17;
                        break;

                }


            }
        }




        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltrar.Text == "CÓDIGO")
                {
                    string pesquisar = txtPesquisar.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from Fornecedor where id_fornecedor like '%" + pesquisar + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvFor.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvFor.Rows.Add();
                        dgvFor.Rows[linha].Cells["cliId"].Value = dr.GetValue(0);
                        dgvFor.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                        dgvFor.Rows[linha].Cells["clnCNPJ"].Value = dr.GetValue(2);
                        dgvFor.Rows[linha].Cells["clnEstadual"].Value = dr.GetValue(3);
                        dgvFor.Rows[linha].Cells["clnTelefone"].Value = dr.GetValue(4);
                        dgvFor.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);

                        linha++;
                    }


                    cmd.Connection.Close();
                }

                else if (cmbFiltrar.Text == "NOME")
                {
                    string pesquisar = txtPesquisar.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from Fornecedor where nome_fornecedor like '%" + pesquisar + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvFor.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
 
                        dgvFor.Rows.Add();
                        dgvFor.Rows[linha].Cells["cliId"].Value = dr.GetValue(0);
                        dgvFor.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                        dgvFor.Rows[linha].Cells["clnCNPJ"].Value = dr.GetValue(2);
                        dgvFor.Rows[linha].Cells["clnEstadual"].Value = dr.GetValue(3);
                        dgvFor.Rows[linha].Cells["clnTelefone"].Value = dr.GetValue(4);
                        dgvFor.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);

                        linha++;
                    }


                    cmd.Connection.Close();
                }
                else if (cmbFiltrar.Text == "CNPJ")
                {
                    string pesquisar = txtPesquisar.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from Fornecedor where cnpj like '%" + pesquisar + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvFor.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvFor.Rows.Add();
                        dgvFor.Rows[linha].Cells["cliId"].Value = dr.GetValue(0);
                        dgvFor.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                        dgvFor.Rows[linha].Cells["clnCNPJ"].Value = dr.GetValue(2);
                        dgvFor.Rows[linha].Cells["clnEstadual"].Value = dr.GetValue(3);
                        dgvFor.Rows[linha].Cells["clnTelefone"].Value = dr.GetValue(4);
                        dgvFor.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);

                        linha++;
                    }


                    cmd.Connection.Close();
                }

                else if (cmbFiltrar.Text == "TELEFONE")
                {
                    string pesquisar = txtPesquisar.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from Fornecedor where telefone_fornecedor like '%" + pesquisar + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvFor.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvFor.Rows.Add();
                        dgvFor.Rows[linha].Cells["cliId"].Value = dr.GetValue(0);
                        dgvFor.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                        dgvFor.Rows[linha].Cells["clnCNPJ"].Value = dr.GetValue(2);
                        dgvFor.Rows[linha].Cells["clnEstadual"].Value = dr.GetValue(3);
                        dgvFor.Rows[linha].Cells["clnTelefone"].Value = dr.GetValue(4);
                        dgvFor.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);

                        linha++;
                    }


                    cmd.Connection.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao consultar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            cmbFiltrar.SelectedIndex = 0;
            desabilitaControles();
            this.alteraBotoes(1);
           
        }
        public void alteraBotoes(int op)
        {

            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnCancelUp.Enabled = false;

            if (op == 1)
            {
                btnNovo.Enabled = true;
                btnSalvar.Visible = false;
            }
            if (op == 2)
            {
                btnInserir.Enabled = true;
                btnCancelUp.Enabled = true;
                btnNovo.Enabled = false;
            }

            if (op == 4)
            {
                btnAlterar.Enabled = true;  
                btnNovo.Enabled = false;
            }
            if (op == 5)
            {
                btnAlterar.Enabled = true;  

            }
            if (op == 6)
            {
                btnAlterar.Enabled = false;  
                btnSalvar.Visible = true;
                btnCancelUp.Enabled = true;

            }
            if (op == 7)
            {
                btnAlterar.Enabled = false;  
                btnSalvar.Visible = false;
                btnCancelUp.Enabled = false;
                btnNovo.Enabled = true;
            }

        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFornecedor.Text == string.Empty)
                {
                    MessageBox.Show("campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    this.txtFornecedor.Focus();

                }

                else if (txtCNPJ.Text == string.Empty)
                {
                    MessageBox.Show("campo CNPJ vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    this.txtCNPJ.Focus();
                }



                else if (txtTelefone.Text == string.Empty)
                {
                    MessageBox.Show("campo Telefone vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtTelefone.Focus();
                }

                else if (Validacao.Cpf(txtCNPJ.Text) == true)
                {

                    MessageBox.Show("Por favor insira um CNPJ válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCNPJ.Focus();
                }
                else if (Validacao.IsCnpj(txtCNPJ.Text) == false)
                {

                    MessageBox.Show("Por favor insira um CNPJ válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCNPJ.Focus();
                }


                else
                {
                    Fornecedor F = new Fornecedor();
                    F.Nome = txtFornecedor.Text;
                    F.Cnpj = txtCNPJ.Text;
                    F.Incricao = txtEstadual.Text;
                    F.Telefone = txtTelefone.Text;
                    F.Email = txtEmail.Text;
                    F.inserir();
                    txtCodigo.Text = F.Id.ToString();


                    MessageBox.Show("Fornecedor Cadastrado com sucesso!", " Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.alteraBotoes(1);
                    this.desabilitaControles();
                    this.LimpaTela();
                    lbEmail.Visible = false;
                    dgvFor.Enabled = true;
                    btnPesquisar.Enabled = true;
                    cmbFiltrar.Enabled = true;
                    txtPesquisar.Enabled = true;

                }

            }

            catch (Exception)
            {

                MessageBox.Show("CNPJ já cadastrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCNPJ.TextLength)
                {

                    case 0:
                        txtCNPJ.Text = "";
                        break;

                    case 2:
                        txtCNPJ.Text = txtCNPJ.Text + ".";
                        txtCNPJ.SelectionStart = 4;
                        break;

                    case 6:
                        txtCNPJ.Text = txtCNPJ.Text + ".";
                        txtCNPJ.SelectionStart = 8;
                        break;

                    case 10:
                        txtCNPJ.Text = txtCNPJ.Text + "/";
                        txtCNPJ.SelectionStart = 12;
                        break;

                    case 15:
                        txtCNPJ.Text = txtCNPJ.Text + "-";
                        txtCNPJ.SelectionStart = 17;
                        break;

                }


            }
        }

        private void txtCNPJ_Validated(object sender, EventArgs e)
        {
            if (Validacao.IsCnpj(txtCNPJ.Text) == false)
            {
                lbCNPJINVALIDO.Visible = true;
            }
            else
            {
                lbCNPJINVALIDO.Visible = false;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelefone.TextLength)
                {

                    case 0:
                        txtTelefone.Text = "(";
                        txtTelefone.SelectionStart = 2;
                        break;

                    case 3:
                        txtTelefone.Text = txtTelefone.Text + ")";
                        txtTelefone.SelectionStart = 5;
                        break;

                    case 9:
                        txtTelefone.Text = txtTelefone.Text + "-";
                        txtTelefone.SelectionStart = 11;
                        break;
                }
            }
        }

        private void txtFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void dgvFor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = dgvFor.CurrentRow.Cells[0].Value.ToString();
                txtFornecedor.Text = dgvFor.CurrentRow.Cells[1].Value.ToString();
                txtCNPJ.Text = dgvFor.CurrentRow.Cells[2].Value.ToString();
                txtEstadual.Text = dgvFor.CurrentRow.Cells[3].Value.ToString();
                txtTelefone.Text = dgvFor.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvFor.CurrentRow.Cells[5].Value.ToString();

                btnAlterar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione um fornecedor válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaControles();
            txtFornecedor.Focus();
            this.LimpaTela();
            this.alteraBotoes(2);
            dgvFor.Enabled = false;
            btnPesquisar.Enabled = false;
            cmbFiltrar.Enabled = false;
            txtPesquisar.Enabled = false;
            

        }

        public void desabilitaControles()
        {
            txtFornecedor.Enabled = false;
            txtCNPJ.Enabled = false;
            txtEstadual.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;


        }
        public void habilitaControles()
        {
            txtFornecedor.Enabled = true;
            txtCNPJ.Enabled = true;
            txtEstadual.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtFornecedor.Clear();
            txtCNPJ.Clear();
            txtEstadual.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            dgvFor.Rows.Clear();


        }

        private void btnCancelUp_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.desabilitaControles();
            this.alteraBotoes(1);
            dgvFor.Enabled = true;
            btnPesquisar.Enabled = true;
            cmbFiltrar.Enabled = true;
            txtPesquisar.Enabled = true;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(6);
            this.habilitaControles();
            dgvFor.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtFornecedor.Text == string.Empty)
                {
                    MessageBox.Show("campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    this.txtFornecedor.Focus();

                }

                else if (txtCNPJ.Text == string.Empty)
                {
                    MessageBox.Show("campo CNPJ vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    this.txtCNPJ.Focus();
                }



                else if (txtTelefone.Text == string.Empty)
                {
                    MessageBox.Show("campo Telefone vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtTelefone.Focus();
                }

                else if (Validacao.Cpf(txtCNPJ.Text) == true)
                {

                    MessageBox.Show("Por favor insira um CNPJ válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCNPJ.Focus();
                }
                else if (Validacao.IsCnpj(txtCNPJ.Text) == false)
                {

                    MessageBox.Show("Por favor insira um CNPJ válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCNPJ.Focus();
                }


                else
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = Banco.abrir();
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "sp_alteraFornecedor";
                    comm.Parameters.Add("@id_fornecedor", SqlDbType.Int).Value = txtCodigo.Text;
                    comm.Parameters.Add("@nome_fornecedor", SqlDbType.VarChar).Value = txtFornecedor.Text;
                    comm.Parameters.Add("@cnpj", SqlDbType.Char).Value = txtCNPJ.Text;
                    comm.Parameters.Add("@inscricao_estadual", SqlDbType.VarChar).Value = txtEstadual.Text;
                    comm.Parameters.Add("@telefone_fornecedor", SqlDbType.VarChar).Value = txtTelefone.Text;
                    comm.Parameters.Add("@email_fornecedor", SqlDbType.VarChar).Value = txtEmail.Text;
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();
                    lbEmail.Visible = false;
                    this.alteraBotoes(7);
                    this.desabilitaControles();
                    this.LimpaTela();
                    dgvFor.Enabled = true;
                    MessageBox.Show("Dados salvos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
            }

            catch (Exception)
            {

                MessageBox.Show("CNPJ Já cadastrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (cmbFiltrar.Text == "CNPJ")
                {
                    solonumero(e);
                    txtPesquisar.MaxLength = 18;
                    if (char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                    }

                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (txtPesquisar.TextLength)
                        {

                            case 0:
                                txtPesquisar.Text = "";
                                break;

                            case 2:
                                txtPesquisar.Text = txtPesquisar.Text + ".";
                                txtPesquisar.SelectionStart = 4;
                                break;

                            case 6:
                                txtPesquisar.Text = txtPesquisar.Text + ".";
                                txtPesquisar.SelectionStart = 8;
                                break;

                            case 10:
                                txtPesquisar.Text = txtPesquisar.Text + "/";
                                txtPesquisar.SelectionStart = 12;
                                break;

                            case 15:
                                txtPesquisar.Text = txtPesquisar.Text + "-";
                                txtPesquisar.SelectionStart = 17;
                                break;
                        }
                    }
                }

                else if (cmbFiltrar.Text == "TELEFONE")
                {
                    solonumero(e);
                    txtPesquisar.MaxLength = 14;

                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (txtPesquisar.TextLength)
                        {

                            case 0:
                                txtPesquisar.Text = "(";
                                txtPesquisar.SelectionStart = 2;
                                break;

                            case 3:
                                txtPesquisar.Text = txtPesquisar.Text + ")";
                                txtPesquisar.SelectionStart = 5;
                                break;

                            case 9:
                                txtPesquisar.Text = txtPesquisar.Text + "-";
                                txtPesquisar.SelectionStart = 11;
                                break;
                        }

                    }
                }


                else if (cmbFiltrar.Text == "NOME")
                {
                    sololetras(e);
                    txtPesquisar.MaxLength = 80;

                }


                else if (cmbFiltrar.Text == "CÓDIGO")
                {
                    solonumero(e);
                    txtPesquisar.MaxLength = 5;

                }

            }

            catch (Exception)
            {

                MessageBox.Show("Não foi possivel consultar dados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void txtEstadual_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
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
    }
}
    



    


