using Microsoft.Extensions.Options;
using System.Data.Linq;
using System.Data.SqlClient;

namespace DADOS
{
    public class conexao : DataContext
    {
        string connectionString = @"Data Source=DESKTOP-ECFLCP7;Initial Catalog=HippeDog;Integrated Security=True";
        private SqlConnection cn;

        public conexao(string connectionString) : base(connectionString)
        {
            cn = new SqlConnection(connectionString);

        }

        public SqlConnection Conectar()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }

        public void Desconectar()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}
