using Microsoft.EntityFrameworkCore;
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
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7;Initial Catalog=HippeDog;Integrated Security=True";


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

        //public void CadastrarFornecedor(ENTIDADES.TBL_FORNECEDORES ent)
        //{
        //    try
        //    {
        //        using (var DB = new conexao(connectionString))
        //        {
        //            DB.GetTable<ENTIDADES.TBL_FORNECEDORES>().InsertOnSubmit(ent);
        //            DB.SubmitChanges();

        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        public void CadastrarFornecedor(ENTIDADES.TBL_FORNECEDORES ent, string nomeFornecedor, string emailFornecedor, string enderecoFornecedor, string telefoneFornecedor, string telefoneOpcional, string Produto)
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {

                    ent.Nome = nomeFornecedor;
                    ent.Email = emailFornecedor;
                    ent.Endereco = enderecoFornecedor;
                    ent.Telefone = telefoneFornecedor;
                    ent.TelefoneOpcional = telefoneOpcional;
                    ent.Produto = Produto;


                    DB.GetTable<ENTIDADES.TBL_FORNECEDORES>().InsertOnSubmit(ent);
                    DB.SubmitChanges();

                }

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
                using (var db = new conexao(connectionString))
                {
                    ENTIDADES.TBL_FORNECEDORES updateList = (from tbl in db.GetTable<ENTIDADES.TBL_FORNECEDORES>()
                                                             where tbl.Id_Fornecedor == idFornecedor
                                                             select tbl).FirstOrDefault();

                    if (updateList != null)
                    {
                        updateList.Nome = nomeFornecedor;
                        updateList.Email = emailFornecedor;
                        updateList.Endereco = enderecoFornecedor;
                        updateList.Telefone = telefoneFornecedor;
                        updateList.TelefoneOpcional = telefoneOpcional;
                        updateList.Produto = Produto;

                        db.SubmitChanges(); // Salva as alterações no banco de dados
                    }
                }
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
                using (var DB = new conexao(connectionString))
                {
                   
                    ENTIDADES.TBL_FORNECEDORES listaDeletar = (from tbl in DB.GetTable<ENTIDADES.TBL_FORNECEDORES>()
                                                               where tbl.Id_Fornecedor == idFornecedor
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

        

    }
}
