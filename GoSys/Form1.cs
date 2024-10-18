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

namespace EncrypSenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Banco.abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insereUsuario";
            cmd.Parameters.Add("@nome_usuario", SqlDbType.VarChar).Value = txtNomeUsuario.Text;
            cmd.Parameters.Add("@senha", SqlDbType.Text).Value = ValidaSenha.validCryptographyPass(txtSenha.Text);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            MessageBox.Show("Usuário gravado com suscesso");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new EncrypSenha.Form2();
          frm2.ShowDialog();
        }
    }
}
