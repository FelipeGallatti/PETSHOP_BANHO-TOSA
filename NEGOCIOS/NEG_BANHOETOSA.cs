using DADOS;
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

        public List<ENTIDADES.TBL_AGENDA> ListaAgenda()
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

        public void AgendarBanho(ENTIDADES.TBL_AGENDA ent)
        {
            try
            {
               objdad_Agenda.AgendarBanho(ent);
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
                objdad_Agenda.AtualizarFalta(ent);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public List<ENTIDADES.TBL_AGENDA> ListarHistorico()
        {
           return objdad_Agenda.ListarHistorico();
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
