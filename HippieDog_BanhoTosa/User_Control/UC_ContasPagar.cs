using HippieDog_BanhoTosa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.VirtualKeyboard;


namespace HippieDog_BanhoTosa.User_Control
{
    public partial class UC_ContasPagar : UserControl
    {
        NEGOCIOS.NEG_CONTASPAGAR ObjNeg_ContasPagar = new NEGOCIOS.NEG_CONTASPAGAR();
        public UC_ContasPagar()
        {
            InitializeComponent();
        }

        public void LAYOUT_GRID()
        {
            try
            {
                rgvContasPagar.Columns["ID_CP"].IsVisible = false;
                rgvContasPagar.Columns["Pagamento"].IsVisible = false;
                rgvContasPagar.Columns["Descricao"].HeaderText = "DESCRIÇÃO";
                rgvContasPagar.Columns["Categoria"].HeaderText = "CATEGORIA";
                rgvContasPagar.Columns["Valor"].HeaderText = "VALOR";
                rgvContasPagar.Columns["Data_Vencimento"].HeaderText = "DATA DE VENCIMENTO";


                rgvContasPagar.Columns["Descricao"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvContasPagar.Columns["Categoria"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvContasPagar.Columns["Data_Vencimento"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvContasPagar.Columns["VALOR"].TextAlignment = ContentAlignment.MiddleCenter;


                Check_PagarContas();
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
                borderBotao.AdicionarBotaoArredondado(btnAdicionarConta, 10);
                borderBotao.AdicionarBotaoArredondado(btnContasPagas, 10);
                borderBotao.AdicionarBotaoArredondado(btnRemoverConta, 10);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        public void Check_PagarContas()
        {
            try
            {
                GridViewCommandColumn commandColumn = new GridViewCommandColumn();
                commandColumn.Name = "Pagar";
                commandColumn.UseDefaultText = true;
                commandColumn.DefaultText = "PAGAR";
                commandColumn.TextAlignment = ContentAlignment.MiddleCenter;
                rgvContasPagar.Columns.Add(commandColumn);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        private void UC_ContasPagar_Load(object sender, EventArgs e)
        {
            try
            {
                rgvContasPagar.DataSource = ObjNeg_ContasPagar.ListarContas_Pendentes();
                LAYOUT_GRID();
                ArredondarBordas();

                foreach (GridViewColumn column in rgvContasPagar.Columns)
                {
                    // Verifica o nome das colunas e define ReadOnly conforme necessário (Para eu conseguir selecionar minha checkbox sem ter que editar o texto do radgridview).
                    if (column.Name == "Descricao" || column.Name == "Categoria" || column.Name == "Data_Vencimento" || column.Name == "Valor" || column.Name == "Status")
                    {
                        column.ReadOnly = true; // Define as colunas "Nome" e "Produto" como somente leitura
                    }
                    else
                    {
                        column.ReadOnly = false; // Deixa as outras colunas editáveis
                    }
                }




            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void rgvContasPagar_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                var commandCell = (GridCommandCellElement)sender;
                var row = commandCell.RowInfo;

                if (commandCell.ColumnInfo.Name == "Pagar")
                {
                    // Execute a lógica de pagamento aqui
                    int idcp = Convert.ToInt32(row.Cells["Id_Cp"].Value);
                    string descricao = row.Cells["Descricao"].Value.ToString();
                    string categoria = row.Cells["Categoria"].Value.ToString();
                    string dataVencimento = row.Cells["Data_Vencimento"].Value.ToString();
                    string valor = row.Cells["Valor"].Value.ToString();
                    DialogResult result = MessageBox.Show($"Deseja realizar o pagamento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ObjNeg_ContasPagar.PagarConta(idcp);
                        MessageBox.Show($"Pagamento no valor de {valor} realizado!");
                        rgvContasPagar.DataSource = ObjNeg_ContasPagar.ListarContas_Pendentes();
                    }
                    else
                    {
                        return;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdicionar_ContasPagar formAdc_ContasPagar = new FormAdicionar_ContasPagar();
                formAdc_ContasPagar.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnContasPagas_Click(object sender, EventArgs e)
        {
            try
            {
                FormContasPagas formContasPagar = new FormContasPagas();
                formContasPagar.ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
