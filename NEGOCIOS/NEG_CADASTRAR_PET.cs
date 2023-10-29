using DADOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{
    public class NEG_CADASTRAR_PET
    {
        DADOS.CRUD_CADASTRAR_PET objDad_CadastrarPet = new CRUD_CADASTRAR_PET();

        public void InserirPet(TBL_CADASTRAR_PET ent)
        {
            try
            {
                objDad_CadastrarPet.InserirPet(ent);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
