using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HippieDog_BanhoTosa
{
    public partial class FormAgenda : Form
    {
        NEGOCIOS.NEG_BANHOETOSA ObjNeg = new NEGOCIOS.NEG_BANHOETOSA();
        ENTIDADES.TBL_AGENDA ObjEnt = new ENTIDADES.TBL_AGENDA();
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void PreenchercamposDgv(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha a linha selecionada
                DataGridViewRow row = dgvAgenda.Rows[e.RowIndex];

                //txtNomeTarefa.Text = row.Cells["Nome_Tarefa"].Value.ToString();
                tbxDono.Text = row.Cells["DONO"].Value.ToString();
                tbxTelefone.Text = row.Cells["TELEFONE"].Value.ToString();
                cbServico.Text = row.Cells["SERVICO"].Value.ToString();
                tbxPet.Text = row.Cells["PET"].Value.ToString();
                dtData.Value = Convert.ToDateTime(row.Cells["DATA"].Value);
                dtHora.Value = Convert.ToDateTime(row.Cells["HORA"].Value);
                tbxDetalhes.Text = row.Cells["DETALHES"].Value.ToString();
                tbxValor.Text = row.Cells["VALOR"].Value.ToString();
                lblID.Text = row.Cells["ID_AGENDA"].Value.ToString();
            }
        }
        private void dgvAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                PreenchercamposDgv(e);
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = ObjNeg.ListaAgenda();
            dgvAgenda.Columns["ID_Agenda"].Visible = false;
            dgvAgenda.Columns["Telefone"].Visible = false;
            dgvAgenda.Columns["Detalhes"].Visible = false;
            dgvAgenda.Columns["Data"].Visible = false;
            dgvAgenda.Columns["Hora"].Visible = false;
            dgvAgenda.Columns["Faltou"].Visible = false;
            dgvAgenda.AutoSize = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ENTIDADES.TBL_AGENDA ent = new ENTIDADES.TBL_AGENDA();
            if (Convert.ToInt32(lblID.Text) > 0)
            {
                ent.ID_AGENDA = Convert.ToInt32(lblID.Text);
                ent.FALTOU = true;
                ObjNeg.AtualizarFalta(ent);
            }
        }
    }
}
