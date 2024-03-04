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
using System.Xml.Linq;

namespace HippieDog_BanhoTosa
{
    public partial class FormAlterarFornecedor : Form
    {
        NEGOCIOS.NEG_FORNECEDORES ObjNeg_Fornecedores = new NEGOCIOS.NEG_FORNECEDORES();
        public FormAlterarFornecedor(int idFornecedor, string nomeFornecedor, string emailFornecedor, string telefoneFornecedor, string telefoneOpcional, string Produto, string Endereco)
        {
            InitializeComponent();

            CarregarInformacoesForm(idFornecedor, nomeFornecedor, emailFornecedor, telefoneFornecedor, telefoneOpcional, Produto, Endereco);

        }

        private void ArredondarBordas()
        {
            try
            {
                Borda_Botao borderBotao = new Borda_Botao();
                borderBotao.AdicionarBotaoArredondado(btnSair, 10);
                borderBotao.AdicionarBotaoArredondado(btnAlterar, 10);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void CarregarInformacoesForm(int idFornecedor, string nomeFornecedor, string emailFornecedor, string telefoneFornecedor, string telefoneOpcional, string Produto, string Endereco)
        {
            try
            {
                lblIdFornecedor.Text = idFornecedor.ToString();
                tbxNome.Text = nomeFornecedor;
                tbxEmail.Text = emailFornecedor;
                tbxTelefone.Text = telefoneFornecedor;
                tbxTelefoneOpcional.Text = telefoneOpcional;
                tbxProduto.Text = Produto;
                tbxEndereco.Text = Endereco;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormAlterarFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                ArredondarBordas();
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

                    DialogResult = MessageBox.Show("Você tem certeza que deseja alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            ObjNeg_Fornecedores.AlterarFornecedor(Convert.ToInt32(lblIdFornecedor.Text), tbxNome.Text, tbxEmail.Text, tbxEndereco.Text, tbxTelefone.Text, tbxTelefoneOpcional.Text, tbxProduto.Text);
                            MessageBox.Show("Fornecedor cadastrado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            throw new Exception(ex.Message.ToString());
                        }
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
