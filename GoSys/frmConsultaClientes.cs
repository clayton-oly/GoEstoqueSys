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
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }


        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {

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

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                {

                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from cliente where nome_cliente like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvClientes.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvClientes.Rows.Add();
                        dgvClientes.Rows[linha].Cells["clnId"].Value = dr.GetValue(0);
                        dgvClientes.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                        dgvClientes.Rows[linha].Cells["clnCPF"].Value = dr.GetValue(2);
                        dgvClientes.Rows[linha].Cells["clnData"].Value = dr.GetValue(3);
                        dgvClientes.Rows[linha].Cells["clnTelefone"].Value = dr.GetValue(4);
                        dgvClientes.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);
                        dgvClientes.Rows[linha].Cells["clnCEP"].Value = dr.GetValue(6);
                        dgvClientes.Rows[linha].Cells["clnEnd"].Value = dr.GetValue(7);
                        dgvClientes.Rows[linha].Cells["clnBairro"].Value = dr.GetValue(8);
                        dgvClientes.Rows[linha].Cells["clnCompl"].Value = dr.GetValue(9);
                        dgvClientes.Rows[linha].Cells["clnCidade"].Value = dr.GetValue(10);
                        dgvClientes.Rows[linha].Cells["clnEstado"].Value = dr.GetValue(11);
                        dgvClientes.Rows[linha].Cells["clnNum"].Value = dr.GetValue(12);

                        linha++;
                    }


                    cmd.Connection.Close();
                }


                else if (rbCPF.Checked)     
                {
                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from cliente where cpf like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvClientes.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvClientes.Rows.Add();
                        dgvClientes.Rows[linha].Cells["clnId"].Value = dr.GetValue(0);
                        dgvClientes.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                        dgvClientes.Rows[linha].Cells["clnCPF"].Value = dr.GetValue(2);
                        dgvClientes.Rows[linha].Cells["clnData"].Value = dr.GetValue(3);
                        dgvClientes.Rows[linha].Cells["clnTelefone"].Value = dr.GetValue(4);
                        dgvClientes.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);
                        dgvClientes.Rows[linha].Cells["clnCEP"].Value = dr.GetValue(6);
                        dgvClientes.Rows[linha].Cells["clnEnd"].Value = dr.GetValue(7);
                        dgvClientes.Rows[linha].Cells["clnBairro"].Value = dr.GetValue(8);
                        dgvClientes.Rows[linha].Cells["clnCompl"].Value = dr.GetValue(9);
                        dgvClientes.Rows[linha].Cells["clnCidade"].Value = dr.GetValue(10);
                        dgvClientes.Rows[linha].Cells["clnEstado"].Value = dr.GetValue(11);
                        dgvClientes.Rows[linha].Cells["clnNum"].Value = dr.GetValue(12);
                        linha++;
                    }


                    cmd.Connection.Close();

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Não foi possivel fazer a consulta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            } 

            }
        
     

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Program.idtransferido = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                frmCadastroClientes frc = new frmCadastroClientes();

                Program.fp.pnPrincipal.Controls.Clear();
                frc.TopLevel = false;
                Program.fp.pnPrincipal.Controls.Add(frc);
                Program.fp.Show();
                frc.Show();

            }
            catch (Exception)
            {

                MessageBox.Show("Selecione algum cliente", "informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbCPF.Checked)
            {
                solonumero(e);

                if (char.IsNumber(e.KeyChar) == true)

                    switch (txtValor.TextLength)
                    {

                        case 0:
                            txtValor.Text = "";
                            break;

                        case 3:
                            txtValor.Text = txtValor.Text + ".";
                            txtValor.SelectionStart = 5;
                            break;

                        case 7:
                            txtValor.Text = txtValor.Text + ".";
                            txtValor.SelectionStart = 9;
                            break;

                        case 11:
                            txtValor.Text = txtValor.Text + "-";
                            txtValor.SelectionStart = 12;
                            break;

                    }
                }
            else
            {
                sololetras(e);
            }

            }
        }
    }