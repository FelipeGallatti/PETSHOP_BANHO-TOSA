using DADOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{
    public class NEG_FORNECEDORES
    {
        DADOS.CRUD_FORNECEDORES Objdad_fornecedores = new CRUD_FORNECEDORES();
        public void CadastrarFornecedor(ENTIDADES.TBL_FORNECEDORES ent)
        {
            try
            {
                Objdad_fornecedores.CadastrarFornecedor(ent);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public List<ENTIDADES.TBL_FORNECEDORES> ListarFornecedores()
        {
            try
            {
               return Objdad_fornecedores.ListarFornecedores();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void AlterarFornecedor(ENTIDADES.TBL_FORNECEDORES ent)
        {
            try
            {
                Objdad_fornecedores.AlterarFornecedor(ent);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void ExcluirFornecedor(ENTIDADES.TBL_FORNECEDORES ent)
        {
            try
            {
                Objdad_fornecedores.ExcluirFornecedor(ent);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
