using DADOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{
    public class NEG_BANHOETOSA
    {
        DADOS.CRUD_BANHOETOSA objdad_Agenda = new DADOS.CRUD_BANHOETOSA();


        public List<TBL_RACAS> ListarRacas()
        {
            try
            {
                return objdad_Agenda.ListarRacas();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public List<object> ListaAgenda()
        {
            try
            {

                return objdad_Agenda.ListaAgenda();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void RemoverBanho(int idBanho)
        {
            try
            {
                objdad_Agenda.RemoverBanho(idBanho);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        public List<object> ListarHistoricoFalta()
        {
            try
            {
                return objdad_Agenda.ListarHistoricoFalta();
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
                return objdad_Agenda.ListarServicos();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void AgendarBanho(string dono, string telefone, string servico, string pet, string detalhes, DateTime data, string hora, decimal valor, int raca)
        {
            try
            {
                objdad_Agenda.AgendarBanho(dono, telefone, servico, pet, detalhes, data, hora, valor, raca);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void ConfirmarBanho(int idAgenda)
        {
            try
            {
                objdad_Agenda.ConfirmarBanho(idAgenda);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public double CalcularValorServico(int idservico, int porteraca)
        {
            try
            {
                return objdad_Agenda.CalcularValorServico(idservico, porteraca);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void AdicionarFalta(bool falta, int idAgenda)
        {
            try
            {
                objdad_Agenda.AdicionarFalta(falta, idAgenda);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void RemoverFalta(bool falta, int idAgenda)
        {
            try
            {
                objdad_Agenda.RemoverFalta(falta, idAgenda);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public object ValorTotalFaltas()
        {
            try
            {
                return objdad_Agenda.ValorTotalFaltas();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public List<object> ListarHistorico()
        {
            return objdad_Agenda.ListarHistorico();
        }

        public List<object> ListarHistoricoMensal()
        {
            return objdad_Agenda.ListarHistoricoMensal();
        }

        public decimal RetornarValorMensal()
        {
           return objdad_Agenda.RetornarValorMensal();
        }

        public List<object> ListarHistoricoSemanal()
        {
            return objdad_Agenda.ListarHistoricoSemanal();
        }

        public decimal RetornarValorSemanal()
        {
           return objdad_Agenda.RetornarValorSemanal();
        }

        public decimal BanhosDiarios()
        {
            try
            {
                return objdad_Agenda.BanhosDiarios();
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
                return objdad_Agenda.GanhosDiarios();
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
                return objdad_Agenda.GanhosSemanais(dataInicio, DataFinal);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public decimal BanhosSemanais(DateTime dataInicio, DateTime DataFinal)
        {
            try
            {
                return objdad_Agenda.BanhosSemanais(dataInicio, DataFinal);
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
                return objdad_Agenda.BanhosMensais(dataInicio, dataFinal);
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
                return objdad_Agenda.GanhosMensal(dataInicio, DataFinal);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
