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

        public void CarregarInformacoesForm(int idFornecedor, string nomeFornecedor, string emailFornecedor, string telefoneFornecedor, string telefoneOpcional, string Produto, string Endereco)
        {
            try
            {
                lblIdFornecedor.Text = idFornecedor.ToString();
                txtNomeFornecedor.Text = nomeFornecedor;
                txtEmail.Text = emailFornecedor;
                txtTelefone.Text = telefoneFornecedor;
                txtTelefoneOpc.Text = telefoneOpcional;
                txtProduto.Text = Produto;
                txtEndereco.Text = Endereco;

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

                if (txtNomeFornecedor.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeFornecedor.Focus();
                }
                else if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Email", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                }
                else if (txtEndereco.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Endereço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEndereco.Focus();
                }
                else if (txtTelefone.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefone.Focus();
                }
                else if (txtTelefoneOpc.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefoneOpc.Focus();
                }
                else if (txtProduto.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProduto.Focus();
                }
                else
                {

                    DialogResult = MessageBox.Show("Você tem certeza que deseja alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            ObjNeg_Fornecedores.AlterarFornecedor(Convert.ToInt32(lblIdFornecedor.Text), txtNomeFornecedor.Text, tbxEmailFornecedor.Text, txtEndereco.Text, txtTelefone.Text, txtTelefoneOpc.Text, txtProduto.Text);
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
