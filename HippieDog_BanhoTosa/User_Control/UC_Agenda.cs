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
using Telerik.WinControls.UI;

namespace HippieDog_BanhoTosa.User_Control
{
    public partial class UC_Agenda : UserControl
    {
        NEGOCIOS.NEG_BANHOETOSA ObjNeg = new NEGOCIOS.NEG_BANHOETOSA();
        int idAgenda;
        public UC_Agenda()
        {
            InitializeComponent();
        }

        private void LAYOUT_GRID_AGENDA()
        {
            try
            {
                rgvAgenda.DataSource = ObjNeg.ListaAgenda();
                //rgvAgenda.Columns["ID_Agenda"].IsVisible = false;
                //rgvAgenda.Columns["Telefone"].IsVisible = false;
                //rgvAgenda.Columns["Detalhes"].IsVisible = false;
                //rgvAgenda.Columns["Data"].IsVisible = false;
                //rgvAgenda.Columns["Hora"].IsVisible = false;
                rgvAgenda.Columns["SERVICO"].IsVisible = false;
                rgvAgenda.Columns["PRESENCA"].IsVisible = false;
                rgvAgenda.Columns["ID_AGENDA"].IsVisible = false;


                rgvAgenda.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvAgenda.Columns["Dono"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvAgenda.Columns["Pet"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvAgenda.Columns["Data"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvAgenda.Columns["Hora"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                //rgvAgenda.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void UC_Agenda_Load(object sender, EventArgs e)
        {
            LAYOUT_GRID_AGENDA();
        }

        private void rgvAgenda_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha a linha selecionada
                var row = rgvAgenda.Rows[e.RowIndex];

                //txtNomeTarefa.Text = row.Cells["Nome_Tarefa"].Value.ToString();
                lblDono.Text = row.Cells["DONO"].Value.ToString();
                lblPet.Text = row.Cells["PET"].Value.ToString();
                lblraca.Text = row.Cells["RACA"].Value.ToString();
                lblHora.Text = Convert.ToDateTime(row.Cells["HORA"].Value).ToString("HH:mm");
                lblValor.Text = row.Cells["VALOR"].Value.ToString();
                idAgenda = Convert.ToInt32(row.Cells["ID_AGENDA"].Value);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormAgendar_Banho formAgendarBanho = new FormAgendar_Banho();
            formAgendarBanho.Show();
        }

        private void btnFaltou_Click(object sender, EventArgs e)
        {
            if (idAgenda == null) MessageBox.Show("Antes de Incluir a falta, precisa clicar em um cliente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult result = MessageBox.Show($"Você tem certeza que deseja incluir falta no {lblPet.Text} ? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) { return; }
            bool falta = true;
            ObjNeg.AdicionarFalta(falta, idAgenda);
            MessageBox.Show("Falta adicionada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYOUT_GRID_AGENDA();
        }

        private void rgvAgenda_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            try
            {
                if (e.CellElement is GridDataCellElement)
                {
                    if (e.Column is GridViewDataColumn)
                    {
                        GridViewDataColumn dataColumn = e.Column as GridViewDataColumn;

                        // Verifique se a coluna contém valores de data e hora.
                        if (dataColumn.DataType == typeof(DateTime))
                        {
                            if (e.Row.Cells[dataColumn.Name].Value != null && e.Row.Cells[dataColumn.Name].Value != DBNull.Value)
                            {
                                DateTime dataOriginal = (DateTime)e.Row.Cells[dataColumn.Name].Value;
                                e.CellElement.Text = dataOriginal.ToString("dd/MM/yyyy");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
