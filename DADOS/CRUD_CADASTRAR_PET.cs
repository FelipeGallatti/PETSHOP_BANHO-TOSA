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
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7;Initial Catalog=HippeDog;Integrated Security=True";



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


		public List<TBL_RACAS> ListarRacasPequenas()
		{
			try
			{
				using (var db = new conexao(connectionString))
				{
					List<TBL_RACAS> listarPequena = (from tbl in db.GetTable<TBL_RACAS>()
													 where tbl.PORTE == 1
													 select tbl).ToList();

					return listarPequena;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}


		public List<TBL_RACAS> ListarRacasMedia()
		{
			try
			{
				using (conexao db = new conexao(connectionString))
				{
                    List<TBL_RACAS> listarMedia = (from tbl in db.GetTable<TBL_RACAS>()
												   where tbl.PORTE == 2
												   select tbl).ToList();

					return listarMedia;

                }
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

		public List<TBL_RACAS> ListarRacasGrande()
		{
			try
			{
				using (conexao db = new conexao(connectionString))
				{
					List<TBL_RACAS> listarMedia = (from tbl in db.GetTable<TBL_RACAS>()
												   where tbl.PORTE == 3
												   select tbl).ToList();


					return listarMedia;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}



    }
}
