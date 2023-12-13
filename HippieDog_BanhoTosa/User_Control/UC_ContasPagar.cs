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
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
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

        private void UC_ContasPagar_Load(object sender, EventArgs e)
        {
            try
            {
                rgvContasPagar.DataSource = ObjNeg_ContasPagar.ListarContas_Pendentes();
                LAYOUT_GRID();


                //// Carregando a imagem
                //Image image = Image.FromFile("C:\\Users\\Felip\\source\\repos\\PETSHOP_BANHO-TOSA\\HippieDog_BanhoTosa\\Images\\cash.svg");

                //// Adicionando a imagem a uma célula específica
                //GridViewRowInfo row = rgvContasPagar.Rows[0]; // Supondo que você está adicionando uma imagem na primeira linha
                //row.Cells["colPagar"].Value = image;




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
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Column.Name == "CustomColumn")
                {
                    // Verifica se a célula clicada é a célula do botão personalizado
                    // Faça o que for necessário quando o botão é clicado
                    MessageBox.Show("Botão clicado na linha: " + e.RowIndex.ToString());
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
