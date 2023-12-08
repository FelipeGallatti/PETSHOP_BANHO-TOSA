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
    public partial class FormAlterarFornecedor : Form
    {
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
    }
}
