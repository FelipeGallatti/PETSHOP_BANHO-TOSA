using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippieDog_BanhoTosa
{
    public partial class FormAgendar_Banho : Form
    {
        ENTIDADES.TBL_AGENDA ObjEnt = new ENTIDADES.TBL_AGENDA();
        NEGOCIOS.NEG_BANHOETOSA ObjNeg = new NEGOCIOS.NEG_BANHOETOSA();
        public FormAgendar_Banho()
        {
            InitializeComponent();
        }
        public void MontarEntidades()
        {
            TimeSpan selectedTime = new TimeSpan(dtHora.Value.Hour, dtHora.Value.Minute, 0);
            ObjEnt.DATA = dtData.Value;
            ObjEnt.HORA = selectedTime.ToString();
            ObjEnt.DETALHES = tbxDetalhes.Text;
            ObjEnt.PET = tbxPet.Text;
            ObjEnt.DONO = tbxDono.Text;
            ObjEnt.TELEFONE = tbxTelefone.Text;
            ObjEnt.SERVICO = cbServico.Text;
            ObjEnt.TELEFONE = tbxTelefone.Text;
            ObjEnt.VALOR = Convert.ToInt32(tbxValor.Text);
            
        }
        public void AgendarBanho()
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja agendar o banho?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.TBL_AGENDA ent = new ENTIDADES.TBL_AGENDA();
                    MontarEntidades();
                    ent.DATA = ObjEnt.DATA;
                    ent.HORA = ObjEnt.HORA;
                    ent.DETALHES = ObjEnt.DETALHES;
                    ent.PET = ObjEnt.PET;
                    ent.DONO = ObjEnt.DONO;
                    ent.TELEFONE = ObjEnt.TELEFONE;
                    ent.SERVICO = ObjEnt.SERVICO;
                    ent.TELEFONE = ObjEnt.TELEFONE;
                    ent.VALOR = Convert.ToInt32(tbxValor.Text);    
                 

                    ObjNeg.AgendarBanho(ent);
                    MessageBox.Show("O banho foi agendado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                catch (Exception ex)
                {

                    throw new Exception(ex.Message.ToString());
                }
            }
            else
            {
                return;
            }
        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void FormAgendar_Banho_Load(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            AgendarBanho();
        }
    }
}
