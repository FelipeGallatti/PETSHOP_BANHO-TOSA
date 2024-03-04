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

namespace HippieDog_BanhoTosa
{
    public partial class FormCadastrar_Fornecedor : Form
    {
        NEGOCIOS.NEG_FORNECEDORES ObjNegFornecedores = new NEGOCIOS.NEG_FORNECEDORES();
        public FormCadastrar_Fornecedor()
        {
            InitializeComponent();
        }
        private void ArredondarBordas()
        {
            try
            {
                Borda_Botao borderBotao = new Borda_Botao();
                borderBotao.AdicionarBotaoArredondado(btnCadastrar, 10);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        // Evento para notificar o cadastro bem-sucedido
        public event EventHandler FornecedorCadastradoComSucesso;


        private void LimparCampos()
        {
            try
            {
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxEndereco.Text = string.Empty;
                tbxTelefone.Text = string.Empty;
                tbxTelefoneOpcional.Text = string.Empty;
                tbxProduto.Text = string.Empty;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            if (tbxNome.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxNome.Focus();
            }
            else if (tbxEmail.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Email", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxEmail.Focus();
            }
            else if (tbxEndereco.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Endereço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxEndereco.Focus();
            }
            else if (tbxTelefone.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxTelefone.Focus();
            }
            else if (tbxTelefoneOpcional.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxTelefoneOpcional.Focus();
            }
            else if (tbxProduto.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxProduto.Focus();
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Você tem certeza que deseja cadastrar o fornecedor?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ENTIDADES.TBL_FORNECEDORES ent = new ENTIDADES.TBL_FORNECEDORES();
                        ObjNegFornecedores.CadastrarFornecedor(ent, tbxNome.Text, tbxEmail.Text, tbxEndereco.Text, tbxTelefone.Text, tbxTelefoneOpcional.Text, tbxProduto.Text);
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        FornecedorCadastradoComSucesso?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        private void tbxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void tbxTelefoneOpcional_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastrar_Fornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                ArredondarBordas();
                //ConfigurarOrdemDeFoco();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
