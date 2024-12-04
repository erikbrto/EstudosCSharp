using EstudosAdoNet.Models;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace EstudosAdoNet.DAO
{
    public class ContatoDAO
    {
        public DataTable GetContatos()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);

            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Contatos;";

            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable dataTable = new DataTable();

            dataTable.Load(reader);

            return dataTable;
        }

        public int AdicionarContato(Contato contato)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);

            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Contatos VALUES (@Nome, @Email, @Telefone);";
            comando.Parameters.Add(new SqlParameter("@Nome", contato.Nome));
            comando.Parameters.Add(new SqlParameter("@Email", contato.Email));
            comando.Parameters.Add(new SqlParameter("@Telefone", contato.Telefone));

            return comando.ExecuteNonQuery();
        }

        public int AlterarContato(Contato contato)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);

            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Contatos SET Nome = @Nome, Email = @Email, Telefone = @Telefone WHERE ID = @Id;";
            comando.Parameters.Add(new SqlParameter("@Nome", contato.Nome));
            comando.Parameters.Add(new SqlParameter("@Email", contato.Email));
            comando.Parameters.Add(new SqlParameter("@Telefone", contato.Telefone));
            comando.Parameters.Add(new SqlParameter("@Id", contato.Id));

            return comando.ExecuteNonQuery();
        }

        public int ExcluirContato(int id)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);

            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Contatos WHERE ID = @Id;";
            comando.Parameters.Add(new SqlParameter("@Id", id));

            return comando.ExecuteNonQuery();
        }
    }
}
