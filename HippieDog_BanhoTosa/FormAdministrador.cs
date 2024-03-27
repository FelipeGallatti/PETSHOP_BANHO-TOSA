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

namespace HippieDog_BanhoTosa
{
    public partial class FormAdministrador : Form
    {
        NEGOCIOS.NEG_LOGIN OBJNEG_LOGIN = new NEGOCIOS.NEG_LOGIN();
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            try
            {
                dgvFuncionariosCadastrados.DataSource = OBJNEG_LOGIN.ListarUsuariosCadastrados();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void dgvFuncionariosCadastrados_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica se a célula clicada está dentro dos limites da grade
                {
                    // Obtém o valor da célula clicada
                    string usuario = Convert.ToString(dgvFuncionariosCadastrados.Rows[e.RowIndex].Cells["USUARIO"].Value);
                    string nome = Convert.ToString(dgvFuncionariosCadastrados.Rows[e.RowIndex].Cells["NOME_USUARIO"].Value);
                    string status = Convert.ToString(dgvFuncionariosCadastrados.Rows[e.RowIndex].Cells["STATUS"].Value);
                    string permissao = Convert.ToString(dgvFuncionariosCadastrados.Rows[e.RowIndex].Cells["PERMISSAO"].Value);

                    // Exibe o valor em uma label
                    lblUsuario.Text = usuario;
                    lblNome.Text = nome;
                    lblStatus.Text = status;
                    lblPermissao.Text = permissao;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
