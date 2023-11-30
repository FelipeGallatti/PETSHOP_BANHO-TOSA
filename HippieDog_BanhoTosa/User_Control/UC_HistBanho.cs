using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippieDog_BanhoTosa.User_Control
{
    public partial class UC_HistBanho : UserControl
    {
        NEGOCIOS.NEG_BANHOETOSA ObjNeg_BanhoTosa = new NEGOCIOS.NEG_BANHOETOSA();
        public UC_HistBanho()
        {
            InitializeComponent();
        }

        private void LAYOUT_GRID_AGENDA()
        {
            try
            {
                rgvHistBanhos.DataSource = ObjNeg_BanhoTosa.ListarHistorico();
                //rgvAgenda.Columns["ID_Agenda"].IsVisible = false;
                //rgvAgenda.Columns["Telefone"].IsVisible = false;
                //rgvAgenda.Columns["Detalhes"].IsVisible = false;
                //rgvAgenda.Columns["Data"].IsVisible = false;
                //rgvAgenda.Columns["Hora"].IsVisible = false;
                rgvHistBanhos.Columns["ID_AGENDA"].IsVisible = false;
                



                rgvHistBanhos.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvHistBanhos.Columns["Dono"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvHistBanhos.Columns["Pet"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvHistBanhos.Columns["Data"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvHistBanhos.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                //rgvAgenda.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        private void UC_HistBanho_Load(object sender, EventArgs e)
        {
            LAYOUT_GRID_AGENDA();


            if (radMes.IsChecked == true)
            {
                radSemana.IsChecked = false;
            }
        }

        private void radMes_CheckStateChanging(object sender, Telerik.WinControls.UI.CheckStateChangingEventArgs args)
        {
            radSemana.IsChecked = false;
            rgvHistBanhos.DataSource = ObjNeg_BanhoTosa.ListarHistoricoMensal();
            lblQtMes.Text = ObjNeg_BanhoTosa.ListarHistoricoMensal().Count.ToString();
            lblValorRMensal.Text = ObjNeg_BanhoTosa.RetornarValorMensal().ToString();
            lblQtSemana.Text = string.Empty;
            lblValorRSemanal.Text = string.Empty;


        }



        private void radSemana_CheckStateChanging(object sender, Telerik.WinControls.UI.CheckStateChangingEventArgs args)
        {
            radMes.IsChecked = false;
            rgvHistBanhos.DataSource = ObjNeg_BanhoTosa.ListarHistoricoSemanal();
            lblQtSemana.Text = ObjNeg_BanhoTosa.ListarHistoricoSemanal().Count.ToString();
            lblValorRSemanal.Text = ObjNeg_BanhoTosa.RetornarValorSemanal().ToString();

            lblQtMes.Text = string.Empty;
            lblValorRMensal.Text = string.Empty;
        }
    }
}
