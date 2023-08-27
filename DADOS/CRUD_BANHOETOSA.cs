using ENTIDADES;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_BANHOETOSA
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7\SQLEXPRESS;integrated security=SSPI;Initial Catalog=HippeDog";

        public List<ENTIDADES.TBL_AGENDA> ListaAgenda()
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_AGENDA> lista = (from tbl_agenda in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                        select tbl_agenda).ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public List<ENTIDADES.TBL_AGENDA> ListarHistorico()
        {
            using (var DB = new conexao(connectionString))
            {
                List<ENTIDADES.TBL_AGENDA> historicoBanho = (from list_hist in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                             where list_hist.FALTOU == false
                                                             select list_hist).ToList();
                return historicoBanho;
            }
        }


        public void AgendarBanho(ENTIDADES.TBL_AGENDA ent)
        {
            try
            {
                ENTIDADES.TBL_FORNECEDORES tbl_fornecedores = new TBL_FORNECEDORES();
                using (var DB = new conexao(connectionString))
                {
                    DB.GetTable<TBL_AGENDA>().InsertOnSubmit(ent);
                    DB.SubmitChanges();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void AtualizarFalta(ENTIDADES.TBL_AGENDA ent)
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    var lista = (from tbl_agenda in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                 where tbl_agenda.ID_AGENDA == ent.ID_AGENDA
                                 select tbl_agenda).FirstOrDefault();
                    if (lista != null)
                    {
                        lista.FALTOU = ent.FALTOU;
                        DB.GetTable<ENTIDADES.TBL_AGENDA>().Context.SubmitChanges();
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        public decimal GanhosDiarios()
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_AGENDA> calcularGanho = (from ganhos in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                                where ganhos.DATA == DateTime.Today
                                                                select ganhos).ToList();
                    decimal somaTotal = 0;
                    foreach (var item in calcularGanho)
                    {
                        somaTotal += item.VALOR;
                    }

                    return somaTotal;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        public decimal BanhosDiarios()
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_AGENDA> calcularGanho = (from ganhos in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                                where ganhos.DATA == DateTime.Today && ganhos.FALTOU == false
                                                                select ganhos).ToList();

                    return calcularGanho.Count;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        public decimal GanhosSemanais(DateTime dataInicio, DateTime DataFinal)
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_AGENDA> calcularGanho = (from ganhos in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                                where ganhos.DATA >= dataInicio && ganhos.DATA <= DataFinal
                                                                select ganhos).ToList();
                    decimal somaTotal = 0;

                    foreach (var item in calcularGanho)
                    {
                        somaTotal += item.VALOR;
                    }

                    return somaTotal;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public decimal GanhosMensal(DateTime dataInicio, DateTime DataFinal)
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_AGENDA> calcularGanhos = (from tbl in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                                 where  tbl.DATA >= dataInicio && tbl.DATA <= DataFinal
                                                                 select tbl).ToList();

                    decimal somaTotal = 0;

                    foreach (var item in calcularGanhos)
                    {
                        somaTotal += item.VALOR;
                    }

                    return somaTotal;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        public int BanhosSemanais(DateTime dataInicio, DateTime DataFinal)
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_AGENDA> banhosSemanais = (from tbl in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                                where tbl.DATA >= dataInicio && tbl.DATA <= DataFinal
                                                                select tbl).ToList();


                    return banhosSemanais.Count;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public int BanhosMensais(DateTime dataInicio, DateTime dataFinal)
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_AGENDA> banhosMensais = (from tbl in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                          where tbl.DATA >= dataInicio && tbl.DATA <= dataFinal && tbl.FALTOU == false
                                                          select tbl).ToList();
                    return banhosMensais.Count;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
