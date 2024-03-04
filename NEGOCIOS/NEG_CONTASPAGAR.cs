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

        public List<object> ListarContas_Pendentes()
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

        public List<object> ListarContas_Pagas()
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

        public List<ENTIDADES.TBL_CONTASPAGAR_SERV> ListarCategoriaServicos()
        {
            try
            {
               return ObjDad_ContasPagar.ListarCategoriaServicos();
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

        public ENTIDADES.TBL_CONTASPAGAR PagarConta(int idCP)
        {
            try
            {
                return ObjDad_ContasPagar.PagarConta(idCP);
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
