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

namespace HippieDog_BanhoTosa.User_Control
{
    public partial class UC_Fornecedores : UserControl
    {
        NEGOCIOS.NEG_FORNECEDORES ObjNegFornecedores = new NEGOCIOS.NEG_FORNECEDORES();
        public UC_Fornecedores()
        {
            InitializeComponent();
            rgvFornecedores.DataSource = ObjNegFornecedores.ListarFornecedores();
            LAYOUT_GRID();
        }



        public void LAYOUT_GRID()
        {
            try
            {
                rgvFornecedores.Columns["Id_Fornecedor"].IsVisible = false;
                rgvFornecedores.Columns["Telefone"].IsVisible = false;
                rgvFornecedores.Columns["TelefoneOpcional"].IsVisible = false;
                rgvFornecedores.Columns["Endereco"].IsVisible = false;
                rgvFornecedores.Columns["Email"].IsVisible = false;
                rgvFornecedores.Columns["Nome"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvFornecedores.Columns["Nome"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvFornecedores.Columns["Produto"].TextAlignment = ContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void rgvFornecedores_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var clickedRow = rgvFornecedores.Rows[e.RowIndex];

                    // Obtém as informações da linha clicada que deseja passar para o novo formulário
                    string informacaoLinha = clickedRow.Cells[0].Value.ToString(); // Supondo que a informação está na primeira coluna

                    int idFornecedor = Convert.ToInt32(clickedRow.Cells["Id_Fornecedor"].Value);
                    string nomeFornecedor = clickedRow.Cells["Nome"].Value.ToString();
                    string emailFornecedor = clickedRow.Cells["Email"].Value.ToString();
                    string telefoneFornecedor = clickedRow.Cells["Telefone"].Value.ToString();
                    string telefoneOpcional = clickedRow.Cells["TelefoneOpcional"].Value.ToString();
                    string Produto = clickedRow.Cells["Produto"].Value.ToString();
                    string Endereco = clickedRow.Cells["Endereco"].Value.ToString();
                    //// Abre um novo formulário passando as informações da linha
                    FormInfoFornecedores formInfoFornecedores = new FormInfoFornecedores(idFornecedor, nomeFornecedor, emailFornecedor, telefoneFornecedor, telefoneOpcional, Produto, Endereco);
                    formInfoFornecedores.Show();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
