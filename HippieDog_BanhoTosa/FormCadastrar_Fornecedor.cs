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

        // Evento para notificar o cadastro bem-sucedido
        public event EventHandler FornecedorCadastradoComSucesso;

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
                    ENTIDADES.TBL_FORNECEDORES ent = new ENTIDADES.TBL_FORNECEDORES();
                    ObjNegFornecedores.CadastrarFornecedor(ent, tbxNome.Text, tbxEmail.Text, tbxEndereco.Text, tbxTelefone.Text, tbxTelefoneOpcional.Text, tbxProduto.Text);
                    MessageBox.Show("Fornecedor Inserido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FornecedorCadastradoComSucesso?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message.ToString());
                }
            }
        }
    }
}
