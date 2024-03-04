using HippieDog_BanhoTosa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public void AtualizarDataGridView()
        {
            rgvContasPagas.DataSource = ObjNeg.ListarHistorico();
        }

        //GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        //{
        //    float r2 = radius / 2f;
        //    GraphicsPath GraphPath = new GraphicsPath();
        //    GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
        //    GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
        //    GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
        //    GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
        //    GraphPath.AddArc(Rect.X + Rect.Width - radius,
        //                     Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
        //    GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
        //    GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
        //    GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
        //    GraphPath.CloseFigure();
        //    return GraphPath;
        //}



        //private void AdicionarBotaoArredondado(RadButton botao, int raio)
        //{
        //    RectangleF rect = new RectangleF(0, 0, botao.Width, botao.Height);
        //    GraphicsPath graphPath = GetRoundPath(rect, raio);
        //    botao.Region = new Region(graphPath);

        //    botao.Paint += (sender, e) =>
        //    {
        //        using (Pen pen = new Pen(Color.LightGray, 1.75f))
        //        {
        //            pen.Alignment = PenAlignment.Inset;
        //            e.Graphics.DrawPath(pen, graphPath);
        //        }
        //    };
        //}

        private void LAYOUT_GRID_AGENDA()
        {
            try
            {
                rgvContasPagas.DataSource = ObjNeg.ListaAgenda();
                //rgvAgenda.Columns["ID_Agenda"].IsVisible = false;
                //rgvAgenda.Columns["Telefone"].IsVisible = false;
                //rgvAgenda.Columns["Detalhes"].IsVisible = false;
                //rgvAgenda.Columns["Data"].IsVisible = false;
                //rgvAgenda.Columns["Hora"].IsVisible = false;
                rgvContasPagas.Columns["SERVICO"].IsVisible = false;
                rgvContasPagas.Columns["PRESENCA"].IsVisible = false;
                rgvContasPagas.Columns["ID_AGENDA"].IsVisible = false;


                rgvContasPagas.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvContasPagas.Columns["Dono"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvContasPagas.Columns["Pet"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvContasPagas.Columns["Data"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                rgvContasPagas.Columns["Hora"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                //rgvAgenda.Columns["Valor"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void ArredondarBordas()
        {
            try
            {
                Borda_Botao borderBotao = new Borda_Botao();
                borderBotao.AdicionarBotaoArredondado(btnAdicionar, 10);
                borderBotao.AdicionarBotaoArredondado(btnBanhoRealizado, 10);
                borderBotao.AdicionarBotaoArredondado(btnFaltou, 10);
                borderBotao.AdicionarBotaoArredondado(btnRemover, 10);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void UC_Agenda_Load(object sender, EventArgs e)
        {
            LAYOUT_GRID_AGENDA();
            ArredondarBordas();
        }

        private void rgvAgenda_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha a linha selecionada
                var row = rgvContasPagas.Rows[e.RowIndex];

                //txtNomeTarefa.Text = row.Cells["Nome_Tarefa"].Value.ToString();
                lblDono.Text = row.Cells["DONO"].Value.ToString();
                lblPet.Text = row.Cells["PET"].Value.ToString();
                lblraca.Text = row.Cells["RACA"].Value.ToString();
                lblHora.Text = Convert.ToDateTime(row.Cells["HORA"].Value).ToString("HH:mm");
                //lblValor.Text = row.Cells["VALOR"].Value.ToString();
                idAgenda = Convert.ToInt32(row.Cells["ID_AGENDA"].Value);

                lblDono.Visible = true;
                lblPet.Visible = true;
                lblraca.Visible = true;
                lblHora.Visible = true;
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

        private void btnBanhoRealizado_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAgenda == null) MessageBox.Show("Antes de Incluir a falta, precisa clicar em um cliente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult result = MessageBox.Show($"Deseja registrar o banho? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) { return; }
                ObjNeg.ConfirmarBanho(idAgenda);
                MessageBox.Show("Banho realizado..", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LAYOUT_GRID_AGENDA();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAgenda == null) MessageBox.Show("Antes de remover um banho, você precisa selecionar um cliente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult result = MessageBox.Show($"Deseja remover o banho? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) { return; }
                ObjNeg.RemoverBanho(idAgenda);
                MessageBox.Show("Banho removido.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LAYOUT_GRID_AGENDA();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
