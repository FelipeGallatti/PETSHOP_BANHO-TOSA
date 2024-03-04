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
    public partial class FormContasPagas : Form
    {

        NEGOCIOS.NEG_CONTASPAGAR ObjNeg_ContasPagar = new NEGOCIOS.NEG_CONTASPAGAR();
        public FormContasPagas()
        {
            InitializeComponent();
        }

        public void LAYOUT_GRID()
        {
            try
            {
                rgvContasPagas.DataSource = ObjNeg_ContasPagar.ListarContas_Pagas();
                rgvContasPagas.Columns["ID_CP"].IsVisible = false;
                rgvContasPagas.Columns["Pagamento"].IsVisible = false;
                rgvContasPagas.Columns["Data_Vencimento"].HeaderText = "Data de vencimento";

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void FormContasPagas_Load(object sender, EventArgs e)
        {
            try
            {
                LAYOUT_GRID();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString()) ;
            }
        }
    }
}
