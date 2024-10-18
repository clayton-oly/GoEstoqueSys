using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GoSys
{
    public class Validacao
    {
        //Valida CPF
        public static bool Cpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string tempCpf, digito;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            else
            {
                tempCpf = cpf.Substring(0, 9);

                soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();
                tempCpf = tempCpf + digito;

                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }
        }

        //************************************************************************************

        //Valida CNPJ
        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string digito, tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");

            if (cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                tempCnpj = cnpj.Substring(0, 12);

                soma = 0;
                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();
                tempCnpj = tempCnpj + digito;

                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }

        }
         public static bool ValidaEmail(string email)
        {
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            return Regex.IsMatch(email, strRegex);
            Regex re = new Regex(strRegex);
            return re.IsMatch(email);

            
        }
        public static bool ValidaCep(string cep)
        {
            return Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }


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

        public static bool ValidarUsuarioSenha(string nome, string senha)
        {
            string senhaComparar =   validCryptographyPass (senha);
            string loginBanco = "";
            string senhaBanco = "";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Banco.abrir();
            cmd.CommandText = @"SELECT Usuario, Senha FROM LOGIN WHERE Usuario = '" + nome + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                loginBanco = dr["Usuario"].ToString();
                senhaBanco = dr["Senha"].ToString();
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

        public static bool ValidarAdmin(string nome, string senha)
        {
            string senhaComparar = validCryptographyPass(senha);
            string loginBanco = "";
            string senhaBanco = "";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Banco.abrir();
            cmd.CommandText = @"SELECT nome_admin, senha FROM admin WHERE nome_admin = '" + nome + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                loginBanco = dr["nome_admin"].ToString();
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


        public static bool verificaSenhaForte(string senha)
        {
            if (senha.Length <= 12)
                return false;
            if (!senha.Any(c => char.IsDigit(c)))
                return false;
            if (!senha.Any(c => char.IsUpper(c)))
                return false;
            if (!senha.Any(c => char.IsLower(c)))
                return false;
            if (!senha.Any(c => char.IsSymbol(c)))
                return false;


            return true;
        }

    }
}

