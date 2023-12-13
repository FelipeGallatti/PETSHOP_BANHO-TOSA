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

        }
        int idFornecedor;
        string nomeFornecedor = "";

        //private void CadastroFornecedor_FornecedorCadastradoComSucesso(object sender, EventArgs e)
        //{
        //    // Atualize o RadGridView após o cadastro do fornecedor
        //    AtualizarGridFornecedores();
        //}

        // Método para atualizar o RadGridView
        //private void AtualizarGridFornecedores()
        //{
        //    try
        //    {
        //        // Selecione a fonte de dados novamente após o cadastro bem-sucedido
        //        radGridView1.DataSource = ObjNegFornecedores.ListarFornecedores();
        //        LAYOUT_GRID(); // Aplique o layout se necessário


        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}



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
                rgvFornecedores.Columns["Nome"].Width = 148;
                rgvFornecedores.Columns["Produto"].Width = 400;

                foreach (GridViewColumn column in rgvFornecedores.Columns)
                {
                    // Verifica o nome das colunas e define ReadOnly conforme necessário (Para eu conseguir selecionar minha checkbox sem ter que editar o texto do radgridview).
                    if (column.Name == "Nome" || column.Name == "Produto")
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



        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                FormCadastrar_Fornecedor formCadastrar_Fornecedor = new FormCadastrar_Fornecedor();
                formCadastrar_Fornecedor.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void UC_Fornecedores_Load(object sender, EventArgs e)
        {
            //rgvFornecedores.DataSource = ObjNegFornecedores.ListarFornecedores();
            rgvFornecedores.DataSource = ObjNegFornecedores.ListarFornecedores();
            LAYOUT_GRID();
            //var cadastroFornecedor = new FormCadastrar_Fornecedor();
            //cadastroFornecedor.FornecedorCadastradoComSucesso += CadastroFornecedor_FornecedorCadastradoComSucesso;
        }

        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var clickedRow = rgvFornecedores.Rows[e.RowIndex];

                    // Obtém as informações da linha clicada que deseja passar para o novo formulário
                    string informacaoLinha = clickedRow.Cells[1].Value.ToString(); // Supondo que a informação está na primeira coluna

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var row in rgvFornecedores.Rows)
                {
                    Telerik.WinControls.UI.GridViewCellInfo chk = (GridViewCellInfo)row.Cells["chk"];

                    if ((bool)chk.Value)
                    {
                        int index = row.Index; // Índice da linha selecionada

                        int idFornecedor = Convert.ToInt32(row.Cells["Id_Fornecedor"].Value);
                        string nomeFornecedor = row.Cells["Nome"].Value.ToString();
                        string emailFornecedor = row.Cells["Email"].Value.ToString();
                        string telefoneFornecedor = row.Cells["Telefone"].Value.ToString();
                        string telefoneOpcional = row.Cells["TelefoneOpcional"].Value.ToString();
                        string produto = row.Cells["Produto"].Value.ToString();
                        string endereco = row.Cells["Endereco"].Value.ToString();

                        // Abra um novo formulário passando os dados para exibição
                        FormAlterarFornecedor formAlterarFornecedor = new FormAlterarFornecedor(idFornecedor, nomeFornecedor, emailFornecedor, telefoneFornecedor, telefoneOpcional, produto, endereco);
                        formAlterarFornecedor.Show();

                        // Pare o loop se encontrou a linha selecionada
                        break;
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
