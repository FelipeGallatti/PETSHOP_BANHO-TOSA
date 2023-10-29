using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

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

        private void PreenchercamposDgv(GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha a linha selecionada
                var row = rgvAgenda.Rows[e.RowIndex];

                //txtNomeTarefa.Text = row.Cells["Nome_Tarefa"].Value.ToString();
                lblDono.Text = row.Cells["DONO"].Value.ToString();
                lblServico.Text = row.Cells["SERVICO"].Value.ToString();
                lblPet.Text = row.Cells["PET"].Value.ToString();
                lblData.Text = Convert.ToDateTime(row.Cells["DATA"].Value).ToString("dd/MM/yyyy");
                lblHora.Text = Convert.ToDateTime(row.Cells["HORA"].Value).ToString("f");
                lblValor.Text = row.Cells["VALOR"].Value.ToString();
            }
        }
        //private void rgvAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //        PreenchercamposDgv(e);
        //}


        private void LAYOUT_GRID_AGENDA()
        {
            try
            {
                rgvAgenda.Columns["ID_Agenda"].IsVisible = false;
                rgvAgenda.Columns["Telefone"].IsVisible = false;
                rgvAgenda.Columns["Detalhes"].IsVisible = false;
                rgvAgenda.Columns["Data"].IsVisible = false;
                rgvAgenda.Columns["Hora"].IsVisible = false;
                rgvAgenda.Columns["Faltou"].IsVisible = false;

                rgvAgenda.Columns["Servico"].Width = 150;
                rgvAgenda.Columns["Dono"].Width = 150;
                rgvAgenda.Columns["Pet"].Width = 150;
                rgvAgenda.Columns["Valor"].Width = 70;

                rgvAgenda.Columns["Servico"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvAgenda.Columns["Dono"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvAgenda.Columns["Pet"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvAgenda.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                rgvAgenda.AutoSize = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

       


        private void FormAgenda_Load(object sender, EventArgs e)
        {
            try
            {

                LAYOUT_GRID_AGENDA();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //ENTIDADES.TBL_AGENDA ent = new ENTIDADES.TBL_AGENDA();
                //if (Convert.ToInt32(lblID.Text) > 0)
                //{
                //    ent.ID_AGENDA = Convert.ToInt32(lblID.Text);
                //    ent.FALTOU = true;
                //    ObjNeg.AtualizarFalta(ent);
                //}
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }



        private void rgvAgenda_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            PreenchercamposDgv(e);
        }
    }
}
