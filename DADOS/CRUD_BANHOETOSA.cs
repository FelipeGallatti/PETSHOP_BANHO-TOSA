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

        public List<ENTIDADES.TBL_RACAS> ListarRacas()
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    var lista = (from tbl in DB.GetTable<TBL_RACAS>()
                                 select tbl).Distinct().ToList();

                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        public List<ENTIDADES.TBL_AGENDA> ListaAgenda()
        {
            try
            {
                using (var DB = new conexao(connectionString))
                {
                    List<ENTIDADES.TBL_AGENDA> lista = (from tbl in DB.GetTable<ENTIDADES.TBL_AGENDA>()
                                                        select tbl).ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public int CalcularValorServico(int idservico, int porteraca)
        {
            try
            {
                int valor = 0;

                if (idservico == 1 && porteraca == 1)
                {
                    valor = 20;
                }
                else if (idservico == 2 && porteraca == 1)
                {
                    valor = 25;
                }
                else if (idservico == 3 && porteraca == 1)
                {
                    valor = 60;
                }
                else if (idservico == 4 && porteraca == 1)
                {
                    valor = 40;
                }
                else if (idservico == 5 && porteraca == 1)
                {
                    valor = 40;
                }
                else if (idservico == 6 && porteraca == 1)
                {
                    valor = 35;
                }

                return valor;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        public List<ENTIDADES.TBL_SERVICOS> ListarServicos()
        {
            try
            {
                using (var db = new conexao(connectionString))
                {
                    var listaServicos = (from tbl in db.GetTable<ENTIDADES.TBL_SERVICOS>()
                                         select tbl).ToList();

                    return listaServicos;
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


        public void AgendarBanho(string dono, string telefone, string servico, string pet, string detalhes, DateTime data, string hora, decimal valor, int raca)
        {
            try
            {
                ENTIDADES.TBL_AGENDA ent = new TBL_AGENDA();
                using (var DB = new conexao(connectionString))
                {
                    ent.DONO = dono;
                    ent.TELEFONE = telefone;
                    ent.SERVICO = servico;
                    ent.PET = pet;
                    ent.DETALHES = detalhes;
                    ent.DATA = data;
                    ent.HORA = hora;
                    ent.VALOR = valor;
                    ent.RACA = raca;

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
