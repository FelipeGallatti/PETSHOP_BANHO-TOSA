using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippieDog_BanhoTosa.User_Control
{
    public partial class UC_Cadastrar_Pet : UserControl
    {

        NEGOCIOS.NEG_CADASTRAR_PET ObjNeg_CadastrarPet = new NEGOCIOS.NEG_CADASTRAR_PET();

        public UC_Cadastrar_Pet()
        {
            InitializeComponent();
        }



        private void CarregarComboRaca()
        {
            cbRaca.ValueMember = "ID_RACA";
            cbRaca.DisplayMember = "NOME";
            cbRaca.SelectedIndex = -1;

        }

        private void chkPequena_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkPequena.Checked)
                {
                    cbRaca.DataSource = ObjNeg_CadastrarPet.ListarRacasPequenas();
                    CarregarComboRaca();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void chkMedio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkMedio.Checked)
                {
                    cbRaca.DataSource = ObjNeg_CadastrarPet.ListarRacasMedia();
                    CarregarComboRaca();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void chkGrande_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkGrande.Checked)
                {
                    cbRaca.DataSource = ObjNeg_CadastrarPet.ListarRacasGrande();
                    CarregarComboRaca();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }

}
