using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippieDog_BanhoTosa
{
    public partial class FormInfoFornecedores : Form
    {
        public FormInfoFornecedores(int idFornecedor, string nomeFornecedor, string emailFornecedor, string telefoneFornecedor, string telefoneOpcional, string Produto, string Endereco)
        {
            InitializeComponent();

            CarregarInformacoesForm(idFornecedor, nomeFornecedor, emailFornecedor, telefoneFornecedor, telefoneOpcional, Produto, Endereco);

        }


        public void CarregarInformacoesForm(int idFornecedor, string nomeFornecedor, string emailFornecedor, string telefoneFornecedor, string telefoneOpcional, string Produto, string Endereco)
        {
            try
            {
                lblIdFornecedor.Text = idFornecedor.ToString();
                lblNomeFornecedor.Text = nomeFornecedor;
                lblEmailFornecedor.Text = emailFornecedor;
                lblTelefoneFornecedor.Text = telefoneFornecedor;
                lblTelefoneOpcional.Text = telefoneOpcional;
                lblProduto.Text = Produto;
                lblEndereco.Text = Endereco;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
