using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_CONTASPAGAR
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7\SQLEXPRESS;integrated security=SSPI;Initial Catalog=HippeDog";


		public List<ENTIDADES.TBL_CONTASPAGAR> ListarContas_Pendentes()
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					List<ENTIDADES.TBL_CONTASPAGAR> ListarContas = (from tbl in DB.GetTable<ENTIDADES.TBL_CONTASPAGAR>()
																	where tbl.Pagamento == false
																	select tbl).ToList();

					return ListarContas;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

		public List<ENTIDADES.TBL_CONTASPAGAR>ListarContas_Pagas()
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					List<ENTIDADES.TBL_CONTASPAGAR> listarContaSPagas = (from tbl in DB.GetTable<ENTIDADES.TBL_CONTASPAGAR>()
																		 where tbl.Pagamento == true 
																		 select tbl).ToList();

					return listarContaSPagas;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

        public void IncluirConta(ENTIDADES.TBL_CONTASPAGAR ent)
        {
			try
			{
				using (var DB = new conexao(connectionString))
				{
					DB.GetTable<ENTIDADES.TBL_CONTASPAGAR>().InsertOnSubmit(ent);
					DB.SubmitChanges();
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
        }

		public ENTIDADES.TBL_CONTASPAGAR PagarConta(ENTIDADES.TBL_CONTASPAGAR Ent)
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					ENTIDADES.TBL_CONTASPAGAR listaAtualizar = (from tbl in DB.GetTable<ENTIDADES.TBL_CONTASPAGAR>()
																	  where tbl.ID_CP == Ent.ID_CP
																	  select  tbl).FirstOrDefault();

					if (listaAtualizar != null)
					{
						listaAtualizar.Pagamento = Ent.Pagamento;
					}

					DB.SubmitChanges();

					return listaAtualizar;

					

				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

    }
}
