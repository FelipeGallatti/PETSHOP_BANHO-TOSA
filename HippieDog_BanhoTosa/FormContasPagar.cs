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
    public partial class FormContasPagar : Form
    {
        ENTIDADES.TBL_CONTASPAGAR ObjEnt_ContasPagar = new ENTIDADES.TBL_CONTASPAGAR();
        NEGOCIOS.NEG_CONTASPAGAR ObjNeg_ContasPagar = new NEGOCIOS.NEG_CONTASPAGAR();
        public FormContasPagar()
        {
            InitializeComponent();
        }

        public void MontarEntidade()
        {
            ObjEnt_ContasPagar.Descricao = tbxDescricao.Text;
            ObjEnt_ContasPagar.Categoria = cbCategoria.Text;
            ObjEnt_ContasPagar.Status = cbStatus.Text;
            ObjEnt_ContasPagar.Data_Vencimento = dtVencimento.Value;
            ObjEnt_ContasPagar.Valor = Convert.ToInt32(tbxValor.Text);
        }

        public void LimparCampos()
        {
            tbxDescricao.Text = string.Empty;
            tbxDescricao.Text = string.Empty;
            cbCategoria.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            tbxValor.Text = string.Empty;    
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbxDescricao.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Descrição", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Escolha no campo Categoria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbxValor.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Escolha no campo Status", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Você deseja adicionar uma nova conta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MontarEntidade();
                        ObjNeg_ContasPagar.IncluirConta(ObjEnt_ContasPagar);
                        LimparCampos();
                        MessageBox.Show("Conta Adicionada com Sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvContasPagar.DataSource = null;
                        dgvContasPagar.DataSource = ObjNeg_ContasPagar.ListarContas_Pendentes();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void FormContasPagar_Load(object sender, EventArgs e)
        {
            dgvContasPagar.DataSource = ObjNeg_ContasPagar.ListarContas_Pendentes();
        }

        private void dgvContasPagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0)
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvContasPagar.Rows[e.RowIndex];

                    label1.Text = row.Cells["Id_CP"].Value.ToString();
                }
            }
        }



        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                ENTIDADES.TBL_CONTASPAGAR ent = new ENTIDADES.TBL_CONTASPAGAR();
                if (dgvContasPagar.SelectedCells.Count > 0)
                {
                    int rowIndex = dgvContasPagar.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvContasPagar.Rows[rowIndex];

                    // Verifique o valor da coluna "Pagamento" na linha selecionada
                    if (!Convert.ToBoolean(row.Cells["Pagamento"].Value))
                    {
                        row.Cells["Pagamento"].Value = 1;
                        DialogResult result = MessageBox.Show("Você já pagou essa conta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ObjEnt_ContasPagar.ID_CP = Convert.ToInt32(label1.Text);
                            ObjEnt_ContasPagar.Pagamento =Convert.ToBoolean(row.Cells["Pagamento"].Value);
                            ent.ID_CP = ObjEnt_ContasPagar.ID_CP;
                            ent.Pagamento = ObjEnt_ContasPagar.Pagamento;



                            ObjNeg_ContasPagar.PagarConta(ent);
                            MessageBox.Show("A conta está paga", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            dgvContasPagar.DataSource = null;
                            dgvContasPagar.DataSource = ObjNeg_ContasPagar.ListarContas_Pendentes();
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("deu errado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContasPagas_Click(object sender, EventArgs e)
        {
            try
            {
                FormContasPagas frmContasPagas = new FormContasPagas();
                frmContasPagas.Show();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}