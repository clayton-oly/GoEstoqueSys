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
using System.Text.RegularExpressions;

namespace GoSys
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }


        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            cmbFiltrar.SelectedIndex = 0;
            cmbNivel.SelectedIndex = 0;
            this.alteraBotoes(1);
            txtId.Enabled = false;
           

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
                desabilitaControles();
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
        public void desabilitaControles()
        {
            txtNomeUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;
            txtEmail.Enabled = false;
            cmbNivel.Enabled = false;
            txtLogin.Enabled = false;

        }
        public void habilitaControles()
        {
            txtNomeUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirmaSenha.Enabled = true;
            txtEmail.Enabled = true;
            cmbNivel.Enabled = true;
            txtLogin.Enabled = true;
          

        }

        public void LimpaTela()
        {
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtId.Clear();
            dgvFor.Rows.Clear();

        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeUsuario.Text == string.Empty)
                {
                    MessageBox.Show("Insira o Usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtNomeUsuario.Focus();

                }

                if (txtLogin.Text == string.Empty)
                {
                    MessageBox.Show("Insira o Login!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtLogin.Focus();
                }

                else if (txtSenha.Text == string.Empty)
                {
                    MessageBox.Show("Insira a senha!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    txtSenha.Focus();
                }

                else if (txtConfirmaSenha.Text == string.Empty)
                {
                    MessageBox.Show("Confirme a senha!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    txtConfirmaSenha.Focus();
                }

                else if (txtSenha.Text != txtConfirmaSenha.Text)
                {
                    MessageBox.Show("As senhas não conferem!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmaSenha.Focus();
                }

                else if (Validacao.ValidaEmail(txtEmail.Text) == false)
                {

                    MessageBox.Show("Por favor insira um E-mail válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    txtEmail.Focus();
                }

                else
                {
                    Usuarios U = new Usuarios();
                    U.Nome = txtNomeUsuario.Text;
                    U.Login = txtLogin.Text;
                    U.Nivel = cmbNivel.Text;
                    U.Senha = txtSenha.Text;
                    U.Email = txtEmail.Text;
                    U.inserir();
                    txtId.Text = U.Id.ToString();
                    MessageBox.Show("Usúario cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Usuário não cadastrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(6);
            this.habilitaControles();
            dgvFor.Enabled = false;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.Text == "CÓDIGO")
            {
                string pesquisar = txtPesquisar.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Banco.abrir();
                cmd.CommandText = "select * from login where id like '%" + pesquisar + "%'";

                SqlDataReader dr = cmd.ExecuteReader();
                dgvFor.Rows.Clear();
                int linha = 0;
                while (dr.Read())

                {
                    dgvFor.Rows.Add();
                    dgvFor.Rows[linha].Cells["cliId"].Value = dr.GetValue(0);
                    dgvFor.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                    dgvFor.Rows[linha].Cells["clnLogin"].Value = dr.GetValue(2);
                    dgvFor.Rows[linha].Cells["clnPerfil"].Value = dr.GetValue(4);
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
                cmd.CommandText = "select * from login where usuario like '%" + pesquisar + "%'";

                SqlDataReader dr = cmd.ExecuteReader();
                dgvFor.Rows.Clear();
                int linha = 0;
                while (dr.Read())

                {
                    dgvFor.Rows.Add();
                    dgvFor.Rows[linha].Cells["cliId"].Value = dr.GetValue(0);
                    dgvFor.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                    dgvFor.Rows[linha].Cells["clnLogin"].Value = dr.GetValue(2);
                    dgvFor.Rows[linha].Cells["clnPerfil"].Value = dr.GetValue(4);
                    dgvFor.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);

                    linha++;
                }


                cmd.Connection.Close();
            }
            else if (cmbFiltrar.Text == "LOGIN")
            {
                string pesquisar = txtPesquisar.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Banco.abrir();
                cmd.CommandText = "select * from login where login like '%" + pesquisar + "%'";

                SqlDataReader dr = cmd.ExecuteReader();
                dgvFor.Rows.Clear();
                int linha = 0;
                while (dr.Read())

                {
                    dgvFor.Rows.Add();
                    dgvFor.Rows[linha].Cells["cliId"].Value = dr.GetValue(0);
                    dgvFor.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                    dgvFor.Rows[linha].Cells["clnLogin"].Value = dr.GetValue(2);
                    dgvFor.Rows[linha].Cells["clnPerfil"].Value = dr.GetValue(4);
                    dgvFor.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);

                    linha++;
                }


                cmd.Connection.Close();
            }

            else if (cmbFiltrar.Text == "EMAIL")
            {
                string pesquisar = txtPesquisar.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Banco.abrir();
                cmd.CommandText = "select * from login where email like '%" + pesquisar + "%'";

                SqlDataReader dr = cmd.ExecuteReader();
                dgvFor.Rows.Clear();
                int linha = 0;
                while (dr.Read())

                {
                    dgvFor.Rows.Add();
                    dgvFor.Rows[linha].Cells["cliId"].Value = dr.GetValue(0);
                    dgvFor.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                    dgvFor.Rows[linha].Cells["clnLogin"].Value = dr.GetValue(2);
                    dgvFor.Rows[linha].Cells["clnPerfil"].Value = dr.GetValue(4);
                    dgvFor.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);

                    linha++;
                }


                cmd.Connection.Close();
            }
        }

        private void dgvFor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dgvFor.CurrentRow.Cells[0].Value.ToString();
                txtNomeUsuario.Text = dgvFor.CurrentRow.Cells[1].Value.ToString();
                txtLogin.Text = dgvFor.CurrentRow.Cells[2].Value.ToString();
                cmbNivel.Text = dgvFor.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dgvFor.CurrentRow.Cells[4].Value.ToString();
                btnAlterar.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Selecione um usuario válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeUsuario.Text == string.Empty)
                {
                    MessageBox.Show("Insira o nome de usúario!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtNomeUsuario.Focus();

                }
                else if (txtNomeUsuario.Text == string.Empty)
                {

                    MessageBox.Show("Por favor insira login ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtLogin.Focus();
                }

                else if (txtSenha.Text == string.Empty)
                {
                    MessageBox.Show("Insira a senha!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    txtSenha.Focus();
                }

                else if (txtConfirmaSenha.Text == string.Empty)
                {
                    MessageBox.Show("Confirme a senha!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    txtConfirmaSenha.Focus();
                }

                else if (txtSenha.Text != txtConfirmaSenha.Text)
                {
                    MessageBox.Show("As senhas não conferem!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmaSenha.Focus();
                }
                else if (Validacao.ValidaEmail(txtEmail.Text) == false)
                {

                    MessageBox.Show("Por favor insira um CPF válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtEmail.Focus();
                }
                else
                {
                SqlCommand comm = new SqlCommand();
                comm.Connection = Banco.abrir();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "sp_alteraUsuario";
                comm.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(txtId.Text);
                comm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtNomeUsuario.Text;
                comm.Parameters.Add("@login", SqlDbType.VarChar).Value = txtLogin.Text;
                comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;
                comm.Parameters.Add("@NivelAcesso", SqlDbType.VarChar).Value = cmbNivel.Text;
                comm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                comm.ExecuteNonQuery();
                comm.Connection.Close();

                MessageBox.Show("Dados salvados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbEmail.Visible = false;
                this.alteraBotoes(7);
                this.desabilitaControles();
                this.LimpaTela();
                dgvFor.Enabled = true;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Para editar você precisa consultar o usuario antes pelo código", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            //lbEmailVali.Text = verificaPontos(txtSenha.Text);
        }


        int qtdCaracteres;
        int qtdMaiusculas;
        int qtdMinusculas;
        int qtdNumeros;
        int qtdSimbolos;
        int qtdRepeticao;

        int somaPontos(string Senha)
        {
            if (Senha == null) return 0;
            qtdCaracteres = getCaracteres(Senha);
            qtdMaiusculas = getMaiusculas(Senha);
            qtdMinusculas = getMinusculas(Senha);
            qtdNumeros = getNumeros(Senha);
            qtdSimbolos = getSimbolos(Senha);
            qtdRepeticao = getRepeticao(Senha);
            return (qtdCaracteres + qtdMaiusculas + qtdMinusculas + qtdNumeros + qtdSimbolos) - qtdRepeticao;
        }

        int getCaracteres(string Senha)
        {
            // Máximo de 10 caracteres, multiplicando 6 vezes cada caractere.
            return Math.Min(10, Senha.Length) * 6;
        }

        int getMaiusculas(string Senha)
        {
            // Multiplica em 5 a quantidade de letras maiúsculas da senha, com máximo de 2!
            return Math.Min(2, Senha.Length - Regex.Replace(Senha, "[A-Z]", "").Length) * 5;
        }

        int getMinusculas(string Senha)
        {
            // Multiplica em 5 a quantidade de letras minúsculas da senha, com máximo de 2!
            return Math.Min(2, Senha.Length - Regex.Replace(Senha, "[a-z]", "").Length) * 5;
        }

        int getNumeros(string Senha)
        {
            // Multiplica em 5 a quantidade de números, com máximo de 2 números!
            return Math.Min(2, Senha.Length - Regex.Replace(Senha, "[0-9]", "").Length) * 5;
        }

        int getSimbolos(string Senha)
        {
            // Multiplica em 5 a quantidade de símbolos!
            return Math.Min(2, Regex.Replace(Senha, "[a-zA-Z0-9]", "").Length) * 5;
        }

        int getRepeticao(string Senha)
        {
            Regex regex = new Regex(@"(\w)*.*\1");
            bool Repete = regex.IsMatch(Senha);
            if (Repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        string verificaPontos(string Senha)
        {
            int Pontos = somaPontos(Senha);
            string resultado = "";

            if (Pontos < 50)
            {
                resultado = "Senha muito fraca!";
            }
            else if (Pontos < 60)
            {
                resultado = "Senha fraca!";
            }
            else if (Pontos < 80)
            {
                resultado = "Senha mediana!";
            }
            else if (Pontos < 100)
            {
                resultado = "Senha forte!";
            }
            else
            {
                resultado = "Senha muito forte!";
            }
            return resultado.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaControles();
            txtNomeUsuario.Focus();
            this.LimpaTela();
            this.alteraBotoes(2);
            dgvFor.Enabled = false;
            btnPesquisar.Enabled = false;
            cmbFiltrar.Enabled = false;
            txtPesquisar.Enabled = false;
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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (cmbFiltrar.Text == "EMAIL")
                {
                    txtPesquisar.MaxLength = 60;    
                    
                }

                else if (cmbFiltrar.Text == "LOGIN")
                {
                    txtPesquisar.MaxLength = 20;

               }
                

                else if (cmbFiltrar.Text == "NOME")
                {
                    sololetras(e);
                    txtPesquisar.MaxLength = 40;

                }


                else if (cmbFiltrar.Text == "CÓDIGO")
                {
                    solonumero(e);
                    txtPesquisar.MaxLength = 5;

                }

            }

            catch (Exception)
            {

                MessageBox.Show("Não foi possivel consultar salvar dados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void txtNomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }
    }
 }

    
    

    





