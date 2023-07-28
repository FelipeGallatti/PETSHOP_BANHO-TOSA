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

        private void FormContasPagas_Load(object sender, EventArgs e)
        {
         dgvContasPagas.DataSource = ObjNeg_ContasPagar.ListarContas_Pagas();
        }
    }
}
