using DADOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{
    public class NEG_LOGIN
    {
        DADOS.CRUD_LOGIN ObjDad_Login = new CRUD_LOGIN();
        public ENTIDADES.TBL_LOGIN CapturarUsuario(string usuario)
        {
            try
            {
                return ObjDad_Login.CapturarUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        public List<ENTIDADES.TBL_LOGIN> ListarUsuariosCadastrados()
        {
            try
            {
               return ObjDad_Login.ListarUsuariosCadastrados();
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
                return ObjDad_Login.VerificarLogin(login, senha);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
