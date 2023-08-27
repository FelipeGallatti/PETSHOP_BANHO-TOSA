using DADOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{
    public class NEG_CONTASPAGAR
    {
        DADOS.CRUD_CONTASPAGAR ObjDad_ContasPagar = new CRUD_CONTASPAGAR();

        public List<ENTIDADES.TBL_CONTASPAGAR> ListarContas_Pendentes()
        {
            try
            {
                return ObjDad_ContasPagar.ListarContas_Pendentes();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public List<ENTIDADES.TBL_CONTASPAGAR> ListarContas_Pagas()
        {
            try
            {
                return ObjDad_ContasPagar.ListarContas_Pagas();
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
                ObjDad_ContasPagar.IncluirConta(ent);
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
                return ObjDad_ContasPagar.PagarConta(Ent);
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
                return ObjDad_ContasPagar.GanhosTotal();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
