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


        public List<ENTIDADES.TBL_LOGIN> ListarUsuariosCadastrados()
        {
            try
            {
                using (var db = new conexao())
                {
                    List<ENTIDADES.TBL_LOGIN> lista = (from tbl in db.GetTable<ENTIDADES.TBL_LOGIN>()
                                                       select tbl).ToList();

                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public bool VerificarLogin(string login, string senha)
        {
            try
            {
                bool verificarLogin = false;
                using (var db = new conexao())
                {
                    ENTIDADES.TBL_LOGIN listaLogin = (from tbl in db.GetTable<ENTIDADES.TBL_LOGIN>()
                                                      where tbl.USUARIO == login && tbl.SENHA == senha
                                                      select tbl).FirstOrDefault();

                    if (listaLogin != null)
                    {
                        verificarLogin = true;

                        ENTIDADES.ENT_APOIO.InfoUsuario._nome = listaLogin.NOME_USUARIO;
                        ENTIDADES.ENT_APOIO.InfoUsuario._usuario = listaLogin.USUARIO;
                        ENTIDADES.ENT_APOIO.InfoUsuario._idUsuario = listaLogin.ID_USUARIO;
                        ENTIDADES.ENT_APOIO.InfoUsuario._status = listaLogin.STATUS;
                        ENTIDADES.ENT_APOIO.InfoUsuario._permissao = listaLogin.PERMISSAO;
                    }

                    return verificarLogin;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        public ENTIDADES.TBL_LOGIN CapturarUsuario(string usuario)
		{
			try
			{
				using (var db = new conexao())
				{
					var lista = (from tbl in db.GetTable<ENTIDADES.TBL_LOGIN>()
								 where tbl.NOME_USUARIO == usuario
								 select tbl).FirstOrDefault();

					return lista;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}
    }
}
