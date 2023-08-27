using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_CADASTRAR_PET
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7\SQLEXPRESS;integrated security=SSPI;Initial Catalog=HippeDog";
        public List<TBL_RACA_PEQUENA> ListarRacasPequenas()
        {
			try
			{
				using (var DB = new conexao(connectionString))
				{
					var lista = (from tbl in DB.GetTable<TBL_RACA_PEQUENA>()
								 select tbl).Distinct().ToList();

					return lista;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
        }

		public List<TBL_RACA_MEDIA> ListarRacasMedia()
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					var lista = (from tbl in DB.GetTable<TBL_RACA_MEDIA>()
								 select tbl).ToList();

					return lista;
				}

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

		public List<TBL_RACA_GRANDE> ListarRacasGrandes()
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					var lista = (from tbl in DB.GetTable<TBL_RACA_GRANDE>()
								 select tbl).ToList();

					return lista;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

		public void InserirPet(TBL_CADASTRAR_PET ent)
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					DB.GetTable<TBL_CADASTRAR_PET>().InsertOnSubmit(ent);
					DB.SubmitChanges();
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

    }
}
