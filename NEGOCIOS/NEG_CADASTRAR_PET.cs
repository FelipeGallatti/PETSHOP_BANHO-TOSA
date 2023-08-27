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
        public List<TBL_RACA_PEQUENA> ListarRacasPequenas()
        {
            try
            {
               return objDad_CadastrarPet.ListarRacasPequenas();
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
              return objDad_CadastrarPet.ListarRacasMedia();
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
                return objDad_CadastrarPet.ListarRacasGrandes();
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
                objDad_CadastrarPet.InserirPet(ent);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
