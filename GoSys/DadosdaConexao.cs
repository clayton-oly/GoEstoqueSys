using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSys
{
    class DadosdaConexao
    {
        public static String servidor = @"DESKTOP-PBG1AVM";
        public static String banco = "goDB";
        public static String usuario = "sa";
        public static String senha = "D@silva1996@";
        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }
        }
    }
}
