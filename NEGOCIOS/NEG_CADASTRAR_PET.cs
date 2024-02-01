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

        public void CadastrarPet(string dono, string pet, string endereco, string telefone, int raca, byte[] caminhoDaImagem, DateTime dtCadastro)
        {
            try
            {
                objDad_CadastrarPet.CadastrarPet(dono, pet, endereco, telefone, raca, caminhoDaImagem, dtCadastro);
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
                return objDad_CadastrarPet.ListarPetsCadastrados1();
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
                return objDad_CadastrarPet.ListarRacasPequenas();
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
                return objDad_CadastrarPet.ListarRacasMedia();
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
                return objDad_CadastrarPet.ListarRacasGrande();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
