using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_FORNECEDORES
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7\SQLEXPRESS;integrated security=SSPI;Initial Catalog=HippeDog";


        public List<ENTIDADES.TBL_FORNECEDORES> ListarFornecedores()
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_FORNECEDORES> listarTabela = (from tbl in DB.GetTable<ENTIDADES.TBL_FORNECEDORES>()
                                                                     select tbl).ToList();

                    return listarTabela;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void CadastrarFornecedor(ENTIDADES.TBL_FORNECEDORES ent)
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    DB.GetTable<ENTIDADES.TBL_FORNECEDORES>().InsertOnSubmit(ent);
                    DB.SubmitChanges();

                }

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
                using (var DB = new conexao(connectionString))
                {
                    ENTIDADES.TBL_FORNECEDORES listaDeletar = (from tbl in DB.GetTable<ENTIDADES.TBL_FORNECEDORES>()
                                                               where tbl.Id_Fornecedor == ent.Id_Fornecedor
                                                               select tbl).FirstOrDefault();
                    if (listaDeletar != null)
                    {
                        DB.GetTable<ENTIDADES.TBL_FORNECEDORES>().DeleteOnSubmit(listaDeletar);
                        DB.SubmitChanges();
                    }


                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void 

    }
}
