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

        public void AgendarBanho()
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja agendar o banho?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                        TimeSpan selectedTime = new TimeSpan(dtHora.Value.Hour, dtHora.Value.Minute, 0);

                        if (tbxValor.Text == string.Empty)
                        {
                            tbxValor.Text = "0";
                        }



                    ObjNeg.AgendarBanho(tbxDono.Text, tbxTelefone.Text, cbServico.Text, tbxPet.Text, tbxDetalhes.Text, dtData.Value, selectedTime.ToString(),Convert.ToDecimal(tbxValor.Text),Convert.ToInt32(cbRaca.SelectedValue));
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
            cbRaca.DataSource = ObjNeg.ListarRacas();
            cbRaca.ValueMember = "ID_RACA";
            cbRaca.DisplayMember = "NOME";
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            AgendarBanho();
        }
    }
}
