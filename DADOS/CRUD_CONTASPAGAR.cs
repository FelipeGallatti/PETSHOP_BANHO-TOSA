using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_CONTASPAGAR
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7;Initial Catalog=HippeDog;Integrated Security=True";


        public List<object> ListarContas_Pendentes()
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    var ListarContas = (from tbl in DB.GetTable<ENTIDADES.TBL_CONTASPAGAR>()
                                        where tbl.Pagamento == false
                                        select new
                                        {
                                            ID_CP = tbl.ID_CP,
                                            Descricao = tbl.Descricao,
                                            Categoria = tbl.Categoria,
                                            Data_Vencimento = tbl.Data_Vencimento,
                                            Pagamento = tbl.Pagamento,
											Valor = tbl.Valor
										}).ToList();

                    // Agora, formate o valor para ter duas casas decimais no lado do cliente
                    var ListaFormatada = ListarContas.Select(item => new
                    {
                        item.ID_CP,
                        item.Descricao,
                        item.Categoria,
                        Data_vencimento = item.Data_Vencimento.ToShortDateString(),
                        item.Pagamento,
						Valor = item.Valor.ToString("N2")
					}).ToList<object>();


                    return ListaFormatada;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public List<object>ListarContas_Pagas()
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					var listarContasPagar = (from tbl in DB.GetTable<ENTIDADES.TBL_CONTASPAGAR>()
                                             where tbl.Pagamento == true
                                             select new
											 {
                                                 ID_CP = tbl.ID_CP,
                                                 Descricao = tbl.Descricao,
                                                 Categoria = tbl.Categoria,
                                                 Data_Vencimento = tbl.Data_Vencimento,
                                                 Pagamento = tbl.Pagamento,
                                                 Valor = tbl.Valor
                                             }).ToList();

                    // Agora, formate o valor para ter duas casas decimais no lado do cliente
                    var ListaFormatada = listarContasPagar.Select(item => new
                    {
                        item.ID_CP,
                        item.Descricao,
                        item.Categoria,
                        Data_Vencimento =  item.Data_Vencimento.ToShortDateString(),
                        item.Pagamento,
                        VALOR = item.Valor.ToString("N2")
                    }).ToList<object>();

                    return ListaFormatada;

                }
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

		public List<ENTIDADES.TBL_CONTASPAGAR_SERV> ListarCategoriaServicos()
		{
			try
			{
				using (var db = new conexao(connectionString))
				{
					List<ENTIDADES.TBL_CONTASPAGAR_SERV> lista = (from tblcp in db.GetTable<ENTIDADES.TBL_CONTASPAGAR_SERV>()
																  select tblcp).ToList();

					return lista;
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

		public ENTIDADES.TBL_CONTASPAGAR PagarConta(int idCP)
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					ENTIDADES.TBL_CONTASPAGAR listaAtualizar = (from tbl in DB.GetTable<ENTIDADES.TBL_CONTASPAGAR>()
																	  where tbl.ID_CP == idCP
																	  select  tbl).FirstOrDefault();

					if (listaAtualizar != null)
					{
						listaAtualizar.Pagamento = true;
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

        public decimal GanhosTotal()
        {
            try
            {
                using (var db = new conexao(connectionString))
                {
                    var lista = (from tbl in db.GetTable<ENTIDADES.TBL_AGENDA>()
                                 where tbl.FALTOU == false
                                 select tbl).ToList();

                    decimal total = 0;

                    foreach (var item in lista)
                    {
                        total += item.VALOR;
                    }

                    return total;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
