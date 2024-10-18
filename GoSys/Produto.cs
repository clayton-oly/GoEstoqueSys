using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GoSys
{
    public class Produto
    {
        private int id;
        private string nome;
        private string valor;
        private string status;
        private string codigo;
        private string modelo;
        private string codigoint;
        private string referencia;
        private string unidade;
        private string cor;
        private string quantidade;
        private byte[] foto;



        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Valor { get { return valor; } set { valor = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public string Codigoint { get { return codigoint; } set { codigoint = value; } }
        public string Referencia { get { return referencia; } set { referencia = value; } }
        public string Unidade { get { return unidade; } set { unidade = value; } }
        public string Cor { get { return cor; } set { cor = value; } }
        public string Quantidade { get { return quantidade; } set { quantidade = value; } }
        public byte[] Foto { get { return foto; } set { foto = value; } }


        public Produto()
        {

        }
        public Produto(int _id, string _nome, string _valor, string _status, string _codigo, string _modelo, string _codigoint, string _referencia, string _unidade, string _quantidade, string _cor, byte[] _foto)
        {
            id = _id;
            nome = _nome;
            valor = _valor;
            status = _status;
            codigo = _codigo;
            modelo = _modelo;
            codigoint = _codigoint;
            referencia = _referencia;
            unidade = _unidade;
            cor = _cor;
            quantidade = _quantidade;
            foto = _foto;

        }

        public void inserir()
        {

            SqlCommand comm = new SqlCommand();
            comm.Connection = Banco.abrir();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_insereProduto";
            comm.Parameters.Add("@nome_produto", SqlDbType.VarChar).Value = nome;
            comm.Parameters.Add("@valor_unitario", SqlDbType.VarChar).Value = valor;
            comm.Parameters.Add("@statuss", SqlDbType.VarChar).Value = status;
            comm.Parameters.Add("@codigo_barra", SqlDbType.VarChar).Value = codigo;
            comm.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
            comm.Parameters.Add("@cor_produto", SqlDbType.VarChar).Value = cor;
            comm.Parameters.Add("@codigo_interno", SqlDbType.Char).Value = codigoint;
            comm.Parameters.Add("@referencia ", SqlDbType.VarChar).Value = referencia;
            comm.Parameters.Add("@unidade_medida", SqlDbType.VarChar).Value = unidade;
            comm.Parameters.Add("@quant_produto", SqlDbType.VarChar).Value = quantidade;
            comm.Parameters.Add("@foto", SqlDbType.Image).Value = foto;
            comm.ExecuteNonQuery();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select @@identity";
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }


        public bool consultar(int _id)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = Banco.abrir();
            comm.CommandText = "select nome_produto,valor_unitario,statuss,codigo_barra,modelo,cor_produto,codigo_interno,referencia,unidade_medida, quant_produto,foto_produto from PRODUTO where id_produto =" + _id;
            SqlDataReader dr = comm.ExecuteReader();
            bool verifica = false;
            while (dr.Read())
            {
                nome = dr.GetString(0);
                valor = dr.GetString(1);
                status = dr.GetString(2);
                codigo = dr.GetString(3);
                modelo = dr.GetString(4);
                cor = dr.GetString(5);
                codigoint = dr.GetString(6);
                referencia = dr.GetString(7);
                unidade = dr.GetString(8);
                quantidade = dr.GetString(9);
                foto = (byte[])dr.GetValue(10);

                verifica = true;
            }
            comm.Connection.Close();
            return verifica;


        }
    }
}


