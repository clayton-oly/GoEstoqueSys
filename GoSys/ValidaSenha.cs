using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EncrypSenha
{
   public static class ValidaSenha
    {
        public static string validCryptographyPass(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public  static bool ValidarUsuarioSenha(string nome, string senha)
        {
            string senhaComparar = validCryptographyPass(senha);
            string loginBanco = "";
            string senhaBanco = "";
           SqlCommand cmd = new SqlCommand();
            cmd.Connection = Banco.abrir();
            cmd.CommandText = @"SELECT nome_usuario, senha FROM usuario WHERE nome_usuario = '"+nome+"'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                loginBanco = dr["nome_usuario"].ToString();
                senhaBanco = dr["senha"].ToString();
            }
            cmd.Connection.Close();
            if ((nome != "") && (senha != ""))
            {
                if ((nome == loginBanco) && (senhaComparar == senhaBanco))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
           
        }
    }
}
