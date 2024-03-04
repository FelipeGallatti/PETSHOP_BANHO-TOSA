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
