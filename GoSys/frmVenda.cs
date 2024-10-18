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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }


        //SqlConnection conexao = new SqlConnection("Data Source=ITQ0514104W10-1;Initial Catalog=goDB;Persist Security Info=True;User ID=sa;Password=senac@itq");

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=goDB;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
        private string strMySQL;
        double totalvenda;
        int valor_removido;
        int valor_total_removido;
        string id_verifica;
        string id_consulta;
        string vrltotal1;
        string vrltotal2;

        private void GerarCodigoVenda()
        {
            strMySQL = "select max(id_pedido) from VENDA";

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(strMySQL, conexao);


                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lbCodigo.Text = "1";
                }
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    lbCodigo.Text = ra.ToString();
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

        private void ConsultarProduto()
        {

            strMySQL = "SELECT * FROM PRODUTO WHERE id_produto like '%" + txtCod_produto.Text + "%'";
            SqlCommand comando = new SqlCommand(strMySQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows)
                {
                    MessageBox.Show("PRODUTO NÃO ENCONTRANDO!", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCod_produto.Clear();
                    txtCod_produto.Focus();
                }
                else
                {
                    txtnome.Text = dr["nome_produto"].ToString();
                    txtVlrProd.Text = dr["valor_unitario"].ToString();
                    txtqtd_produto_estoque.Text = dr["quant_produto"].ToString();

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

        void limparControles()
        {
            txtCod_produto.Clear();
            txtnome.Clear();
            txtQuant.Clear();
            txtVlrTotal.Clear();
            txtVlrProd.Clear();
            cb_desconto.SelectedIndex = 0;
            txtqtd_produto_estoque.Clear();
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
                    comando.Parameters.AddWithValue("@id_pedido", lbCodigo.Text);
                    comando.Parameters.AddWithValue("@ValorTotal", lbl_total_compra.Text);
                    comando.Parameters.AddWithValue("@usuario", cmbCliente.Text);
                    lbl_total_compra.Text = lbl_total_compra.Text.Replace("R$", "");
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
                lbl_total_compra.Text = "0";
                txtCod_produto.Focus();
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
                comando.Parameters.AddWithValue("@id_pedido", lbCodigo.Text);
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





        private void Venda_Load(object sender, EventArgs e)
        {
            GerarCodigoVenda();
            NomearDataGrid();
            cb_desconto.SelectedIndex = 0;
            txtCod_produto.Focus();
            lbl_total_compra.Text = "0";
            cmbCliente.SelectedIndex = 0;
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

        private void txtCod_produto_Validating(object sender, CancelEventArgs e)
        {
            if (txtCod_produto.Text != string.Empty)
            {
                ConsultarProduto();
            }
            else
            {
                txtCod_produto.Focus();
            }
        }

        private void txtQuant_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                if (txtCod_produto.Text != string.Empty)
                {
                    if (txtQuant.Text != string.Empty)
                    {
                        if (int.Parse(txtQuant.Text) <= int.Parse(txtqtd_produto_estoque.Text))
                        {

                            txtVlrTotal.Text = (float.Parse(txtVlrProd.Text) * float.Parse(txtQuant.Text)).ToString();
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
                        txtCod_produto.Focus();
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
                    txtCod_produto.Focus();
                    txtQuant.Clear();

                }
            }

            catch (Exception)
            {


            }

       }    

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            {
                if (txtCod_produto.Text == string.Empty)
                {
                    MessageBox.Show("SELECIONE UM PRODUTO", "PRODUTO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtQuant.Text == string.Empty)
                {
                    MessageBox.Show("INSIRA UMA QUANTIDADE", "QUANTIDADE INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    id_consulta = txtCod_produto.Text;
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
                        if (cb_desconto.Text == "NENHUM")
                        {
                            string desconto = "0%";

                            dvgVendas.Rows.Add(txtCod_produto.Text, txtnome.Text, txtVlrProd.Text, txtQuant.Text, desconto, txtVlrTotal.Text);
                            totalvenda += double.Parse(vrltotal2);
                            string Formato1 = String.Format("{0:C}", totalvenda);
                            lbl_total_compra.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");
                            limparControles();

                        }

                        else if (cb_desconto.Text == "3%")
                        {
                            string exibe_descont = "3%";
                            double percentual = 3.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtCod_produto.Text, txtnome.Text, txtVlrProd.Text, txtQuant.Text, exibe_descont, Formato1);
                            lbl_total_compra.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                        else if (cb_desconto.Text == "5%")
                        {
                            string exibe_descont = "5%";
                            double percentual = 5.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtCod_produto.Text, txtnome.Text, txtVlrProd.Text, txtQuant.Text, exibe_descont, Formato1);
                            lbl_total_compra.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                        else if (cb_desconto.Text == "10%")
                        {
                            string exibe_descont = "10%";
                            double percentual = 10.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtCod_produto.Text, txtnome.Text, txtVlrProd.Text, txtQuant.Text, exibe_descont, Formato1);
                            lbl_total_compra.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                        else if (cb_desconto.Text == "15%")
                        {
                            string exibe_descont = "15%";
                            double percentual = 15.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtCod_produto.Text, txtnome.Text, txtVlrProd.Text, txtQuant.Text, exibe_descont, Formato1);
                            lbl_total_compra.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                        else if (cb_desconto.Text == "20%")
                        {
                            string exibe_descont = "20%";
                            double percentual = 20.0 / 100.0;
                            double valor = double.Parse(vrltotal2);
                            double total_desconto = valor - (percentual * valor);
                            totalvenda += total_desconto;
                            string Formato1 = String.Format("{0:C}", total_desconto);
                            dvgVendas.Rows.Add(txtCod_produto.Text, txtnome.Text, txtVlrProd.Text, txtQuant.Text, exibe_descont, Formato1);
                            lbl_total_compra.Text = Formato1;
                            txtVlrTotal.Text = txtVlrTotal.Text.Replace("R$", "");

                            limparControles();

                        }
                    }

                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
          
                GravarVenda();
                GerarCodigoVenda();
            lbl_total_compra.Text = "0";
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    dvgVendas.Rows.RemoveAt(dvgVendas.CurrentRow.Index);
                    lbl_total_compra.Text = "0";
                    totalvenda = 0;
                    valor_total_removido = 0;
                    for (int i = 0; i < dvgVendas.Rows.Count; i++)
                    {


                        valor_removido = Int32.Parse(dvgVendas.Rows[i].Cells[5].Value.ToString());
                        valor_total_removido += valor_removido;




                    }
                    lbl_total_compra.Text = valor_total_removido.ToString();
                    totalvenda = valor_total_removido;
                    limparControles();
                }
                catch (Exception)
                {


                }


                }
            }
            public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void txtVlrTotal_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtVlrTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {

                String[] separador = txtVlrTotal.Text.Split(new char[] { ',' });
                int qtdDigito = separador[0].Trim().Length;

                if (qtdDigito == 0) txtVlrTotal.SelectionStart = 12;

                switch (qtdDigito)
                {
                    case 1:
                        txtVlrTotal.Text = "0.00";
                        txtVlrTotal.SelectionStart = 2;
                        break;
                    case 2:
                        txtVlrTotal.Text = "00.00";
                        txtVlrTotal.SelectionStart = 3;
                        break;
                    case 3:
                        txtVlrTotal.Text = "000.00";
                        txtVlrTotal.SelectionStart = 4;
                        break;
                    case 5:
                        txtVlrTotal.Text = "0,000.00";
                        txtVlrTotal.SelectionStart = 6;
                        break;
                    case 6:
                        txtVlrTotal.Text = "00,000.00";
                        txtVlrTotal.SelectionStart = 7;
                        break;
                    case 7:
                        txtVlrTotal.Text = "000,000.00";
                        txtVlrTotal.SelectionStart = 8;
                        break;
                    case 9:
                        txtVlrTotal.Text = "0,000,000.00";
                        txtVlrTotal.SelectionStart = 10;
                        break;
                    case 10:
                        txtVlrTotal.Text = "00,000,000.00";
                        txtVlrTotal.SelectionStart = 11;
                        break;
                    case 11:
                        txtVlrTotal.Text = "000,000,000.00";
                        txtVlrTotal.SelectionStart = 12;
                        break;
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCod_produto_TextChanged(object sender, EventArgs e)
        {

        }
    }
   }
 

