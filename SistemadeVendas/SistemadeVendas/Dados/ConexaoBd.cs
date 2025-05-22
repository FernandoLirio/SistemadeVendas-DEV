using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace SistemadeVendas.Dados
{
    internal class ConexaoBd
    {
        private static string dsn = "PostgresDev";

        public static OdbcConnection ObterConexao()
        {
            string connectionString = $"DSN={dsn};";
            return new OdbcConnection(connectionString);
        }
    }
}