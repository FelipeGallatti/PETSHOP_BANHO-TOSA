using System;
using System.Windows.Forms;

namespace HippieDog_BanhoTosa.User_Control
{
    public partial class UC_AgendaFaltas : UserControl
    {
        NEGOCIOS.NEG_BANHOETOSA ObjNeg_BanhoTosa = new NEGOCIOS.NEG_BANHOETOSA();
        int idAgenda;
        bool falta;
        public UC_AgendaFaltas()
        {
            InitializeComponent();
        }

        private void LAYOUT_GRID_AGENDA()
        {
            try
            {

                rgvHistFaltas.DataSource = ObjNeg_BanhoTosa.ListarHistoricoFalta();
                lblQtFalta.Text = ObjNeg_BanhoTosa.ListarHistoricoFalta().Count.ToString();
                //rgvAgenda.Columns["ID_Agenda"].IsVisible = false;
                //rgvAgenda.Columns["Telefone"].IsVisible = false;
                //rgvAgenda.Columns["Detalhes"].IsVisible = false;
                //rgvAgenda.Columns["Data"].IsVisible = false;
                //rgvAgenda.Columns["Hora"].IsVisible = false;
                //rgvHistFaltas.Columns["SERVICO"].IsVisible = false;
                rgvHistFaltas.Columns["PRESENCA"].IsVisible = false;
                rgvHistFaltas.Columns["ID_AGENDA"].IsVisible = false;

                rgvHistFaltas.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvHistFaltas.Columns["Dono"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvHistFaltas.Columns["Pet"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvHistFaltas.Columns["Data"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvHistFaltas.Columns["Hora"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        private void UC_AgendaFaltas_Load(object sender, EventArgs e)
        {
            lblValorFalta.Text = "R$" + ObjNeg_BanhoTosa.ValorTotalFaltas().ToString() + ",00"; ;
            LAYOUT_GRID_AGENDA();
        }

        private void rgvHistFaltas_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha a linha selecionada
                var row = rgvHistFaltas.Rows[e.RowIndex];

                lblPet.Text = row.Cells["Pet"].Value.ToString();
                lblRaca.Text = row.Cells["Pet"].Value.ToString();
                lblValor.Text = row.Cells["Valor"].Value.ToString();
                idAgenda = Convert.ToInt32(row.Cells["ID_AGENDA"].Value);
            }
        }

        private void btnRemoverFalta_Click(object sender, EventArgs e)
        {
            try
            {
                falta = false;

                ObjNeg_BanhoTosa.RemoverFalta(falta, idAgenda);
                MessageBox.Show("Falta removida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LAYOUT_GRID_AGENDA();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void rgvHistFaltas_CellClick_1(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtenha a linha selecionada
                    var row = rgvHistFaltas.Rows[e.RowIndex];

                    lblPet.Visible = true;
                    lblRaca.Visible = true;
                    lblValor.Visible = true;

                    //txtNomeTarefa.Text = row.Cells["Nome_Tarefa"].Value.ToString();
                    lblPet.Text = row.Cells["PET"].Value.ToString();
                    lblRaca.Text = row.Cells["RACA"].Value.ToString();
                    lblValor.Text = row.Cells["VALOR"].Value.ToString();
                    idAgenda = Convert.ToInt32(row.Cells["ID_AGENDA"].Value);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
