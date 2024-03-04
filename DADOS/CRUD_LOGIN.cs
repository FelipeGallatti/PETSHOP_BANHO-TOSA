using ENTIDADES.ENT_APOIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_LOGIN
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7;Initial Catalog=HippeDog;Integrated Security=True";

        public bool VerificarLogin (string login, string senha)
        {
			try
			{
				bool verificarLogin = false;
				using (var db = new conexao(connectionString))
				{
                    ENTIDADES.TBL_LOGIN listaLogin = (from tbl in db.GetTable<ENTIDADES.TBL_LOGIN>()
										where tbl.USUARIO == login && tbl.SENHA == senha
										select tbl).FirstOrDefault();

					if (listaLogin != null)
					{
						verificarLogin = true;
					}

					return verificarLogin;

				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
        }
    }
}
