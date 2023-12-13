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

        public void CadastrarFornecedor(ENTIDADES.TBL_FORNECEDORES ent, string nomeFornecedor, string emailFornecedor, string enderecoFornecedor, string telefoneFornecedor, string telefoneOpcional, string Produto)
        {
            try
            {
                Objdad_fornecedores.CadastrarFornecedor(ent, nomeFornecedor, emailFornecedor, enderecoFornecedor, telefoneFornecedor, telefoneOpcional, Produto);
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

        public void AlterarFornecedor(int idFornecedor, string nomeFornecedor, string emailFornecedor, string enderecoFornecedor, string telefoneFornecedor, string telefoneOpcional, string Produto)
        {
            try
            {
                Objdad_fornecedores.AlterarFornecedor(idFornecedor, nomeFornecedor, emailFornecedor, enderecoFornecedor, telefoneFornecedor, telefoneOpcional, Produto);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void ExcluirFornecedor(int idFornecedor)
        {
            try
            {
                Objdad_fornecedores.ExcluirFornecedor(idFornecedor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
