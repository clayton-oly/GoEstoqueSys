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
    public partial class frmVenda2 : Form
    {
        public frmVenda2()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=goDB;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
        private string strMySQL;
        double totalvenda;
        int valor_removido;
        int valor_total_removido;
        string id_verifica;
        string id_consulta;
        string vrltotal1;
        string vrltotal2;

        private void btnEmitente_Click(object sender, EventArgs e)
        {
        }

        private void frmVenda2_Load(object sender, EventArgs e)
        {
            txtEmitente.Text = frmLogar.usuarioConectado;
            cmbCliente.SelectedIndex = 0;
            txtData.Text = DateTime.Now.ToShortDateString();

            GerarCodigoVenda();
            NomearDataGrid();
            cb_Descontos.SelectedIndex = 0;
            txtProduto.Focus();
            txtValor.Text = "0";

        }

        private void btnDestinatario_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = (@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=goDB;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "Select nome_cliente from cliente";
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbCliente.DisplayMember = "nome_cliente";
                cmbCliente.DataSource = dt;

            }
            catch (Exception)
            {

                MessageBox.Show("ERRO AO CONECTAR NO BANCO DE DADOS DA TABELA CLIENTE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarProduto()
        {

            strMySQL = "SELECT * FROM PRODUTO WHERE nome_produto like '%" + txtProduto.Text + "%'";
            SqlCommand comando = new SqlCommand(strMySQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows)
                {
                    MessageBox.Show("PRODUTO NÃO ENCONTRANDO!", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtProduto.Clear();
                    txtProduto.Focus();
                }
                else
                {
                   
                    txtProduto.Text = dr["nome_produto"].ToString();
                    txtIdPedido.Text = dr["id_produto"].ToString();
                    txtValorUnitario.Text = dr["valor_unitario"].ToString();
                    txtEstoque.Text = dr["quant_produto"].ToString();
                    txtSituacao.Text = dr["statuss"].ToString();

                    txtQuant.Focus();



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void txtProduto_Validating(object sender, CancelEventArgs e)
        {
            if (txtProduto.Text != string.Empty)
            {
                ConsultarProduto();
            }
            else
            {
                txtProduto.Focus();
            }
        }

        private void txtQuant_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtProduto.Text != string.Empty)
                {
                    if (txtQuant.Text != string.Empty)
                    {
                        if (int.Parse(txtQuant.Text) <= int.Parse(txtEstoque.Text))
                        {

                            txtVlrTotal.Text = (float.Parse(txtValorUnitario.Text) * float.Parse(txtQuant.Text)).ToString();
                            vrltotal1 = txtVlrTotal.Text;
                            vrltotal2 = txtVlrTotal.Text;

                            double teste1 = double.Parse(vrltotal1);
                            string Formato1 = String.Format("{0:C}", teste1);
                            txtVlrTotal.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");


                        }
                        else
                        {
                            MessageBox.Show("QUANTIDADE PARA VENDA INDISPONIVEL", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtQuant.Clear();
                            txtQuant.Focus();

                        }
                    }
                    else if (txtQuant.Text == string.Empty)
                    {
                        txtIdPedido.Focus();
                    }
                    else
                    {

                        MessageBox.Show("DIGITE A QUANTIDADE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtQuant.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("INSIRA UM PRODUTO", "PRODUTO NAO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProduto.Focus();
                    txtQuant.Clear();

                }
            }

            catch (Exception)
            {


            }
        }
        private void GerarCodigoVenda()
        {
            strMySQL = "select max(id_pedido) from VENDA";

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(strMySQL, conexao);


                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    txtCodigoVenda.Text = "1";
                }
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    txtCodigoVenda.Text = ra.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexao.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    dvgVendas.Rows.RemoveAt(dvgVendas.CurrentRow.Index);
                    txtValor.Text = "0";
                    totalvenda = 0;
                    valor_total_removido = 0;
                    for (int i = 0; i < dvgVendas.Rows.Count; i++)
                    {


                        valor_removido = Int32.Parse(dvgVendas.Rows[i].Cells[5].Value.ToString());
                        valor_total_removido += valor_removido;




                    }
                    txtValor.Text = valor_total_removido.ToString();
                    totalvenda = valor_total_removido;
                    limparControles();
                }
                catch (Exception)
                {


                }


            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            {
                if (txtProduto.Text == string.Empty)
                {
                    MessageBox.Show("SELECIONE UM PRODUTO", "PRODUTO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtQuant.Text == string.Empty)
                {
                    MessageBox.Show("INSIRA UMA QUANTIDADE", "QUANTIDADE INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    id_consulta = txtProduto.Text;
                    bool novo = true;
                    for (int i = 0; i < dvgVendas.Rows.Count; i++)
                    {
                        id_verifica = "0";
                        id_verifica = dvgVendas.Rows[i].Cells[0].Value.ToString();

                        if (id_consulta == id_verifica)
                        {
                            MessageBox.Show("PRODUTO JA ADICIONADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            id_verifica = "null";
                            novo = false;
                        }
                    }

                    if (novo)
                    {
                        if (cb_Descontos.Text == "NENHUM")
                        {
                            string desconto = "0%";

                            dvgVendas.Rows.Add(txtIdPedido.Text, txtProduto.Text, txtValorUnitario.Text, txtQuant.Text, desconto, txtVlrTotal.Text);
                            totalvenda += double.Parse(vrltotal2);
                            string Formato1 = String.Format("{0:C}", totalvenda);
                            txtValor.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");
                            limparControles();

                        }

                        else if (cb_Descontos.Text == "3%")
                        {
                            string exibe_descont = "3%";
                            double percentual = 3.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtIdPedido.Text, txtProduto.Text, txtValorUnitario.Text, txtQuant.Text, exibe_descont, Formato1);
                            txtValor.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                        else if (cb_Descontos.Text == "5%")
                        {
                            string exibe_descont = "5%";
                            double percentual = 5.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtIdPedido.Text, txtProduto.Text, txtValorUnitario.Text, txtQuant.Text, exibe_descont, Formato1);
                            txtValor.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                        else if (cb_Descontos.Text == "10%")
                        {
                            string exibe_descont = "10%";
                            double percentual = 10.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtIdPedido.Text, txtProduto.Text, txtValorUnitario.Text, txtQuant.Text, exibe_descont, Formato1);
                            txtValor.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                        else if (cb_Descontos.Text == "15%")
                        {
                            string exibe_descont = "15%";
                            double percentual = 15.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtIdPedido.Text, txtProduto.Text, txtValorUnitario.Text, txtQuant.Text, exibe_descont, Formato1);
                            txtValor.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                        else if (cb_Descontos.Text == "20%")
                        {
                            string exibe_descont = "20%";
                            double percentual = 20.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtIdPedido.Text, txtProduto.Text, txtValorUnitario.Text, txtQuant.Text, exibe_descont, Formato1);
                            txtValor.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                    }

                }
            }
        }
                        private void update_produto_caixa(string id_produto, string quant_produto)
                        {
                            strMySQL = "SELECT quant_produto FROM PRODUTO WHERE id_produto like '%" + id_produto + "%'";
                            SqlCommand comando = new SqlCommand(strMySQL, conexao);

                            Int32 ra = Convert.ToInt32(comando.ExecuteScalar());
                            int valor2 = ra;
                            int valor1 = Convert.ToInt32(quant_produto);
                            int valor3 = valor2 - valor1;

                            quant_produto = Convert.ToString(valor3);


                            SqlCommand comando1 = new SqlCommand(strMySQL, conexao);
                            comando1.CommandType = CommandType.StoredProcedure;
                            comando1.CommandText = "sp_alteraProdutoCaixa";
                            comando1.Parameters.Clear();
                            comando1.Parameters.Add("id_produto", SqlDbType.VarChar).Value = id_produto;
                            comando1.Parameters.Add("quant_produto", SqlDbType.VarChar).Value = quant_produto;
                            comando1.ExecuteNonQuery();
                            comando1.CommandType = CommandType.Text;


        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            GravarVenda();
            GerarCodigoVenda();
            txtValor.Text = "0";

        }

        private void GravarVenda()
        {
            strMySQL = "insert into VENDA(id_pedido, ValorTotal, usuario) values (@id_pedido, @ValorTotal, @usuario)";
            SqlCommand comando = new SqlCommand(strMySQL, conexao);

            try
            {
                conexao.Open();
                for (int i = 0; i < dvgVendas.Rows.Count; i++)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id_pedido", txtCodigoVenda.Text);
                    comando.Parameters.AddWithValue("@ValorTotal", txtValor.Text);
                    comando.Parameters.AddWithValue("@usuario", cmbCliente.Text);
                    txtValor.Text = txtValor.Text.Replace("R$", "");
                    txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");


                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                inserir();
                dvgVendas.Rows.Clear();
                totalvenda = 0;
                txtValor.Text = "0";
                txtProduto.Focus();
                conexao.Close();

                MessageBox.Show("VENDA CONCLUIDA", "FINALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void inserir()
        {

            strMySQL = "insert into ITEM_PEDIDO(id_pedido, id_produto, qtd_produto, desconto, total_desconto) values (@id_pedido, @id_produto, @qtd_produto, @desconto, @total_desconto)";
            SqlCommand comando = new SqlCommand(strMySQL, conexao);

            //try
            // {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }


            for (int i = 0; i < dvgVendas.Rows.Count; i++)
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_pedido", txtValor.Text);
                comando.Parameters.AddWithValue("@id_produto", dvgVendas.Rows[i].Cells[0].Value);
                comando.Parameters.AddWithValue("@qtd_produto", dvgVendas.Rows[i].Cells[3].Value);
                comando.Parameters.AddWithValue("@desconto", dvgVendas.Rows[i].Cells[4].Value);
                comando.Parameters.AddWithValue("@total_desconto", dvgVendas.Rows[i].Cells[5].Value);
                comando.ExecuteNonQuery();

                update_produto_caixa(dvgVendas.Rows[i].Cells[0].Value.ToString(), dvgVendas.Rows[i].Cells[3].Value.ToString());


            }

            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}

        }

        void limparControles()
        {
            txtIdPedido.Clear();
            txtProduto.Clear();
            txtQuant.Clear();
            txtVlrTotal.Clear();
            txtValorUnitario.Clear();
            cb_Descontos.SelectedIndex = 0;
            txtEstoque.Clear();
        }

        private void NomearDataGrid()
        {
            dvgVendas.ColumnCount = 6;
            dvgVendas.Columns[0].Name = "CÓDIGO";
            dvgVendas.Columns[1].Name = "PRODUTO";
            dvgVendas.Columns[1].Width = 267;
            dvgVendas.Columns[2].Name = "VALOR UNITÁRIO";
            dvgVendas.Columns[3].Name = "QUANTIDADE";
            dvgVendas.Columns[4].Name = "DESCONTO";
            dvgVendas.Columns[5].Name = "TOTAL/DESCONTO";
            dvgVendas.Columns[5].Width = 150;


        }
    }
  }
  

