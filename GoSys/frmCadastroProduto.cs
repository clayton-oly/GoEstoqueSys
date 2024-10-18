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
using System.Drawing.Imaging;

namespace GoSys
{
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Visible = false;
            btnConsultaa.Visible = false;

            if (op == 1)
            {
                btnCancelar.Enabled = true;
                btnInserir.Enabled = true;
                btnNovo.Enabled = false;
                btnConsulta.Enabled = false;
                txtNome.Focus();

            }
            if (op == 2)
            {
                btnInserir.Enabled = false;
                btnCancelar.Enabled = false;
                btnNovo.Enabled = true;
                btnConsulta.Enabled = true;
            }
            if (op == 3)
            {
                btnSalvar.Visible = true;
                btnCancelar.Enabled = true;
            }
            if (op == 4)
            {
                btnAlterar.Enabled = true;
                btnNovo.Enabled = true;
                btnConsultaa.Visible = true;
                btnCancelar.Enabled = true;
            }
            if (op == 5)
            {
                btnCancelar.Enabled = false;
                btnNovo.Enabled = true;
                btnConsulta.Enabled = false;
                txtNome.Focus();
            }


            if (op == 6)
            {
                btnAlterar.Enabled = true;
                btnNovo.Enabled = true;
                btnConsultaa.Visible = true;
                btnCancelar.Enabled = true;


            }
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



        private void btnInserir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (txtNome.Text == string.Empty)
                    {
                        MessageBox.Show("campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //txtCPFCNPJ.BackColor = Color.Red;
                        txtNome.Focus();
                    }

                    else if (txtCodigoBarras.Text == string.Empty)
                    {
                        MessageBox.Show("campo código de barras vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //txtCPFCNPJ.BackColor = Color.Red;
                        txtCodigoBarras.Focus();
                    }
                    else if (txtQuant.Text == string.Empty)
                    {
                        MessageBox.Show("campo quantidade vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //txtCPFCNPJ.BackColor = Color.Red;
                        txtQuant.Focus();
                    }
                    else if (txtQuant.Text == string.Empty)
                    {
                        MessageBox.Show("campo valor vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //txtCPFCNPJ.BackColor = Color.Red;
                        txtValorUnitario.Focus();
                    }


                    else
                    {
                        Produto P = new Produto();
                        P.Nome = txtNome.Text;
                        P.Valor = txtValorUnitario.Text;
                        P.Status = txtStatus.Text;
                        P.Codigo = txtCodigoBarras.Text;
                        P.Modelo = txtModelo.Text;
                        P.Codigoint = txtCodigoInterno.Text;
                        P.Referencia = txtReferencia.Text;
                        P.Unidade = txtUnidade.Text;
                        P.Foto = ConverterFotoParaByteArray();
                        P.Cor = txtCor.Text;
                        P.Quantidade = txtQuant.Text;
                        P.inserir();
                        txtCodigo.Text = P.Id.ToString();


                        this.alteraBotoes(5);
                        this.LimpaTela();
                        this.desabilitaControles();

                        MessageBox.Show("Produto cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancelar.Enabled = false;
                        btnInserir.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel salvar dados, verifique se o código de barras já foi cadastrado, ou se os campos foi preenchido corretamente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 && n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception )
            {

            }
        }



        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                btnConsulta.Enabled = false;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
                btnConsultaa.Visible = true;
                this.LimpaTela();

            }
            catch (Exception)
            {

            }

        }

        private void lbConsulta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://colorschemedesigner.com/csd-3.5/");
        }

        private void gerar_Click(object sender, EventArgs e)
        {
            if (cdgCaixaCores.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCor.BackColor = cdgCaixaCores.Color;
                string color;
                color = string.Format("{0:X8}", txtCor.BackColor.ToArgb());
                color = color.Remove(color.IndexOf("x") + 1, 2);
                txtCor.Text = color;
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            txtStatus.SelectedIndex = 0;
            txtUnidade.SelectedIndex = 0;
            this.desabilitaControles();
            this.alteraBotoes(0);
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = (@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=goDB;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "Select nome_produto from PRODUTO";
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                lbxConsulta.DisplayMember = "nome_produto";
                lbxConsulta.DataSource = dt;

            }
            catch (Exception)
            {

                MessageBox.Show("ERRO AO CONECTAR NO BANCO DE DADOS DA TABELA CLIENTE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                picFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Arquivo de Imagen(*.PNG; *JPG; *.GIF)" +
               " | *.PNG; *.JPG; *.GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.habilitaControles();
            this.alteraBotoes(3);
            txtCodigo.Enabled = false;
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.habilitaControles();
            this.alteraBotoes(1);
            this.LimpaTela();
            txtCodigo.Enabled = false;
        }

        public void desabilitaControles()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtValorUnitario.Enabled = false;
            txtStatus.Enabled = false;
            txtCodigoBarras.Enabled = false;
            txtModelo.Enabled = false;
            txtCor.Enabled = false;
            txtCodigoInterno.Enabled = false;
            txtReferencia.Enabled = false;
            txtUnidade.Enabled = false;
            txtQuant.Enabled = false;
            btnFoto.Enabled = false;
            gerar.Enabled = false;


        }
        public void habilitaControles()
        {
            txtNome.Enabled = true;
            txtValorUnitario.Enabled = true;
            txtStatus.Enabled = true;
            txtCodigoBarras.Enabled = true;
            txtModelo.Enabled = true;
            txtCor.Enabled = true;
            txtCodigoInterno.Enabled = true;
            txtReferencia.Enabled = true;
            txtUnidade.Enabled = true;
            txtQuant.Enabled = true;
            btnFoto.Enabled = true;
            gerar.Enabled = true;

        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtValorUnitario.Clear();
            txtCodigoBarras.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtCodigoInterno.Clear();
            txtReferencia.Clear();
            txtQuant.Clear();

        }


        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorUnitario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.desabilitaControles();
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
                    txtNome.Focus();
                }

                else if (txtCodigoBarras.Text == string.Empty)
                {
                    MessageBox.Show("campo código de barras vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtCodigoBarras.Focus();
                }
                else if (txtQuant.Text == string.Empty)
                {
                    MessageBox.Show("campo quantidade vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtQuant.Focus();
                }
                else if (txtValorUnitario.Text == string.Empty)
                {
                    MessageBox.Show("campo valor vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtValorUnitario.Focus();
                }

                else
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = Banco.abrir();
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "sp_alteraProduto";
                    comm.Parameters.Add("@id_produto", SqlDbType.Int).Value = txtCodigo.Text;
                    comm.Parameters.Add("@nome_produto", SqlDbType.VarChar).Value = txtNome.Text;
                    comm.Parameters.Add("@valor_unitario", SqlDbType.VarChar).Value = txtValorUnitario.Text;
                    comm.Parameters.Add("@statuss", SqlDbType.VarChar).Value = txtStatus.Text;
                    comm.Parameters.Add("@codigo_barra", SqlDbType.VarChar).Value = txtCodigoBarras.Text;
                    comm.Parameters.Add("@modelo", SqlDbType.VarChar).Value = txtModelo.Text;
                    comm.Parameters.Add("@cor_produto", SqlDbType.VarChar).Value = txtCor.Text;
                    comm.Parameters.Add("@codigo_interno", SqlDbType.VarChar).Value = txtCodigoInterno.Text;
                    comm.Parameters.Add("@referencia", SqlDbType.VarChar).Value = txtReferencia.Text;
                    comm.Parameters.Add("@unidade_medida", SqlDbType.VarChar).Value = txtUnidade.Text;
                    comm.Parameters.Add("@quant_produto", SqlDbType.VarChar).Value = txtQuant.Text;
                    comm.Parameters.Add("@foto_produto", SqlDbType.Image).Value = ConverterFotoParaByteArray();
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();
                    MessageBox.Show("Dados salvos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    btnCancelar.Enabled = false;
                    btnSalvar.Visible = false;
                    this.desabilitaControles();

                }
            }

            catch (Exception )
            {
               MessageBox.Show("Código de barras já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnConsultaa_Click(object sender, EventArgs e)
        {
            Produto P = new Produto();
            try
            {
                
                if (txtCodigo.Text == string.Empty)
                {
                    MessageBox.Show("Coloque um código valido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    this.txtCodigo.Focus();
                   

                }
                else if (P.consultar(Convert.ToInt32(txtCodigo.Text)))
                {

                    txtNome.Text = P.Nome;
                    txtValorUnitario.Text = P.Valor;
                    txtCodigoBarras.Text = P.Codigo;
                    txtCodigoInterno.Text = P.Codigoint;
                    txtCor.Text = P.Cor;
                    txtModelo.Text = P.Modelo;
                    txtReferencia.Text = P.Referencia;
                    txtStatus.Text = P.Status;
                    txtUnidade.Text = P.Unidade;
                    txtQuant.Text = P.Quantidade;

                    System.IO.MemoryStream stream =
                    new System.IO.MemoryStream(P.Foto);
                    picFoto.Image = Bitmap.FromStream(stream);

                    this.alteraBotoes(6);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Produto não cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);
        }

        private void txtQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);
        }

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);
        }
    }
}


        
    

    



