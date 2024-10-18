using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GoSys
{
   public class Fornecedor
    {

        private int id;
        private string nome;
        private string cnpj;
        private string inscricao;
        private string telefone;
        private string email;



        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cnpj { get { return cnpj; } set { cnpj = value; } }
        public string Incricao { get { return inscricao; } set { inscricao = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Email { get { return email; } set { email = value; } }


        public Fornecedor()
        {

        }
        public Fornecedor(int _id, string _nome, string _cnpj, string _inscricao, string _telefone, string _email)
        {
            id = _id;
            nome = _nome;
            cnpj = _cnpj;
            inscricao = _inscricao;
            telefone = _telefone;
            email = _email;

        }

        public void inserir()
        {

            SqlCommand comm = new SqlCommand();
            comm.Connection = Banco.abrir();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_insereFornecedor";
            comm.Parameters.Add("@nome_fornecedor ", SqlDbType.VarChar).Value = nome;
            comm.Parameters.Add("@cnpj ", SqlDbType.VarChar).Value = cnpj;
            comm.Parameters.Add("@inscricao_estadual ", SqlDbType.VarChar).Value = inscricao;
            comm.Parameters.Add("@telefone_fornecedor ", SqlDbType.VarChar).Value = telefone;
            comm.Parameters.Add("@email_fornecedor ", SqlDbType.VarChar).Value = email;
            comm.ExecuteNonQuery();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select @@identity";
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }
    }
}
