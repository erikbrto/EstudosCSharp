using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace EstudosAdoNet.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            string server = ConfigurationManager.AppSettings["server"].ToString();
            string database = ConfigurationManager.AppSettings["database"].ToString();
            string user = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            string connString = $"Server={server};Database={database};User Id={user};Password={password};";
            DbConnection conexao = new SqlConnection(connString);

            conexao.Open();
            return conexao;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();

            return comando;
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
