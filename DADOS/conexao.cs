using Microsoft.Extensions.Options;
using System.Data.Linq;
using System.Data.SqlClient;

namespace DADOS
{
    public class conexao : DataContext
    {
        private static string _connectionString = @"Data Source=DESKTOP-ECFLCP7;Initial Catalog=HippeDog;Integrated Security=True";

        private SqlConnection cn;

        public conexao() : base(_connectionString)
        {
            cn = new SqlConnection(_connectionString);
        }



    }
}
