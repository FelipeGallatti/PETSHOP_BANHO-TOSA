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
        



		public void InserirPet(TBL_CADASTRAR_PET ent)
		{
			try
			{
				using (var DB = new conexao())
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

		public void AtualizarFoto(int id, byte[] caminhoImg)
		{
			try
			{
				using (var db = new conexao())
				{
					ENTIDADES.TBL_CADASTRAR_PET TBL_CAD = (from tbl in db.GetTable<ENTIDADES.TBL_CADASTRAR_PET>()
														   where tbl.ID == id
														   select tbl).FirstOrDefault();

					if (TBL_CAD != null)
					{
						TBL_CAD.FOTO = caminhoImg;
					}
					db.GetTable<ENTIDADES.TBL_CADASTRAR_PET>().Context.SubmitChanges();
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

		public void CadastrarPet (string dono, string pet, string endereco, string telefone, int raca, byte[] caminhoDaImagem, DateTime dtCadastro)
		{
			try
			{
				ENTIDADES.TBL_CADASTRAR_PET ent = new ENTIDADES.TBL_CADASTRAR_PET();
				ent.DONO = dono;
				ent.PET = pet;
				ent.ENDERECO = endereco;
				ent.TELEFONE = telefone;
				ent.RACA = raca;
				ent.FOTO = caminhoDaImagem;
				ent.DATA_CADASTRO = dtCadastro;

				using (var db = new conexao())
				{
					db.GetTable<TBL_CADASTRAR_PET>().InsertOnSubmit(ent);
					db.SubmitChanges();
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

        public List<ENTIDADES.TBL_CADASTRAR_PET> ListarPetsCadastrados()
        {
            try
            {

                using (var DB = new conexao())
                {
                    string query = string.Format(Queries.Query.ListarPetsCadastrados);
                    List<ENTIDADES.TBL_CADASTRAR_PET> mov = new conexao().ExecuteQuery<ENTIDADES.TBL_CADASTRAR_PET>(query).ToList();


                    return mov;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public List<ENTIDADES.TBL_CADASTRAR_PET> ListarPetsCadastrados1()
        {
            try
            {
                using (var DB = new conexao())
                {
                    var resultados = (from tbl in DB.GetTable<ENTIDADES.TBL_CADASTRAR_PET>()
                                      select new
                                      {
                                          tbl.ID,
                                          tbl.DONO,
                                          tbl.ENDERECO,
                                          tbl.TELEFONE,
                                          tbl.PET,
                                          tbl.RACA,
                                          tbl.OBSERVACOES,
                                          tbl.FOTO,
                                          tbl.DATA_CADASTRO
                                      }).ToList();

                    // Mapear os resultados para a entidade desejada
                    var lista = resultados.Select(resultado => new ENTIDADES.TBL_CADASTRAR_PET
                    {
                        ID = resultado.ID,
                        DONO = resultado.DONO,
                        ENDERECO = resultado.ENDERECO,
                        TELEFONE = resultado.TELEFONE,
                        PET = resultado.PET,
                        RACA = resultado.RACA,
                        OBSERVACOES = resultado.OBSERVACOES,
                        FOTO = resultado.FOTO,
                        DATA_CADASTRO = resultado.DATA_CADASTRO
                    }).ToList();

                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


		public ENTIDADES.TBL_CADASTRAR_PET BuscarPetCadastrado(string busca)
		{
			try
			{
				using (var db = new conexao())
				{
					var lista = (from tbl in db.GetTable<ENTIDADES.TBL_CADASTRAR_PET>()
								 where tbl.PET.Contains($"{busca}")
								 select tbl).FirstOrDefault();

					return lista;
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
				using (var db = new conexao())
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
				using (conexao db = new conexao())
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
				using (conexao db = new conexao())
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
