using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace GoSys
{
    public class Clientes
    {
        //atributos
        private int id;
        private string nome;
        private string datanasc;
        private string cpf;
        private string email;
        private string endereco;
        private string cep;
        private string telefone;
        private string num;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;

        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Datanasc { get { return datanasc; } set { datanasc = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
        public string Cep { get { return cep; } set { cep = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Num { get { return num; } set { num = value; } }
        public string Complemento { get { return complemento; } set { complemento = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string Uf { get { return uf; } set { uf = value; } }

        //construtores
        public Clientes()
        {

        }
        public Clientes(int _id, string _nome, string _datanasc, string _cpf, string _email, string _endereco, string _cep, string _telefone, string _num, string _complemento, string _bairro, string _cidade, string _uf)
        {
            id = _id;
            nome = _nome;
            datanasc = _datanasc;
            cpf = _cpf;
            email = _email;
            endereco = _endereco;
            cep = _cep;
            telefone = _telefone;
            num = _num;
            complemento = _complemento;
            bairro = _bairro;
            cidade = _cidade;
            uf = _uf;


        }
        public void inserir()
        {

            SqlCommand comm = new SqlCommand();
            comm.Connection = Banco.abrir();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_insereCliente";
            comm.Parameters.Add("@nome_cliente", SqlDbType.VarChar).Value = nome;
            comm.Parameters.Add("@cpf_cliente", SqlDbType.Char).Value = cpf;
            comm.Parameters.Add("@data_nascimento", SqlDbType.VarChar).Value = datanasc;
            comm.Parameters.Add("@telefone_cliente", SqlDbType.VarChar).Value = telefone;
            comm.Parameters.Add("@email_cliente", SqlDbType.VarChar).Value = email;
            comm.Parameters.Add("@cep", SqlDbType.Char).Value = cep;
            comm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
            comm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
            comm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
            comm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            comm.Parameters.Add("@estado", SqlDbType.Char).Value = uf;
            comm.Parameters.Add("@numero_end", SqlDbType.VarChar).Value = num;
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
            comm.CommandText = "select nome_cliente, cpf, data_nascimento, telefone_cliente, email, cep, endereco, bairro, complemento,cidade ,estado, numero_end from CLIENTE where id_cliente =" + _id;
            SqlDataReader dr = comm.ExecuteReader();
            bool verifica = false;
            while (dr.Read())
            {
                nome = dr.GetString(0);
                cpf = dr.GetString(1);
                datanasc = dr.GetString(2);
                telefone = dr.GetString(3);
                email = dr.GetString(4);
                cep = dr.GetString(5);
                endereco = dr.GetString(6);
                bairro = dr.GetString(7);
                complemento = dr.GetString(8);
                cidade = dr.GetString(9);
                uf = dr.GetString(10);
                num = dr.GetString(11);

                verifica = true;
            }
            comm.Connection.Close();
            return verifica;


        }

        }
    }

