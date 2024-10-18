using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GoSys
{
    public class Usuarios
    {
        //atributos
        private int id;
        private string nome;
        private string login;
        private string senha;
        private string nivel;
        private string email;


        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Login { get { return login; } set { login = value; } }
        public string Senha { get { return senha; } set { senha = value; } }
        public string Nivel { get { return nivel; } set { nivel = value; } }
        public string Email { get { return email; } set { email = value; } }


        //construtores
        public Usuarios()
        {

        }
        public Usuarios(int _id, string _nome, string _login, string _senha, string _nivel, string _email)
        {
            id = _id;
            nome = _nome;
            login = _login;
            senha = _senha;
            nivel = _nivel;
            email = _email;

        }


        public void inserir()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = Banco.abrir();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_insereUsuario";
            comm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = nome;
            comm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            comm.Parameters.Add("@NivelAcesso", SqlDbType.VarChar).Value = nivel;
            comm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
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
            comm.CommandText = "select nome_usuario,senha from USUARIO where id_usuario =" + _id;
            SqlDataReader dr = comm.ExecuteReader();
            bool verifica = false;
            while (dr.Read())
            {
                nome = dr.GetString(0);
                senha = dr.GetString(1);

                verifica = true;
            }
            comm.Connection.Close();
            return verifica;


        }
    }
}

