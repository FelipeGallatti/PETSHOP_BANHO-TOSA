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
    public partial class FormFornecedores : Form
    {
        ENTIDADES.TBL_FORNECEDORES Objent = new ENTIDADES.TBL_FORNECEDORES();
        NEGOCIOS.NEG_FORNECEDORES ObjNeg_Fornecedores = new NEGOCIOS.NEG_FORNECEDORES();
        public FormFornecedores()
        {
            InitializeComponent();
            dgvFornecedores.DataSource = ObjNeg_Fornecedores.ListarFornecedores();
        }

        public void MontarEntidades()
        {
            Objent.Id_Fornecedor = Convert.ToInt32(lblID.Text);
            Objent.Nome = tbxNome.Text;
            Objent.Email = tbxEmail.Text;
            Objent.Endereco = tbxEndereco.Text;
            Objent.Telefone = tbxTelefone.Text;
            Objent.TelefoneOpcional = tbxTelefoneOpcional.Text;
            Objent.Produto = tbxProduto.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    try
                    {
                        //ENTIDADES.TBL_FORNECEDORES ent = new ENTIDADES.TBL_FORNECEDORES();
                        //MontarEntidades();
                        //ent.Nome = Objent.Nome = Objent.Nome;
                        //ent.Email = Objent.Email = Objent.Email;
                        //ent.Endereco = Objent.Endereco;
                        //ent.Telefone = Objent.Telefone;
                        //ent.TelefoneOpcional = Objent.TelefoneOpcional;
                        //ent.Produto = Objent.Produto;
                        //ObjNeg_Fornecedores.CadastrarFornecedor(ent);
                        //MessageBox.Show("Fornecedor Inserido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //dgvFornecedores.DataSource = null;
                        //dgvFornecedores.DataSource = ObjNeg_Fornecedores.ListarFornecedores();

                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message.ToString());
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //if (e.RowIndex >= 0)
                //{
                //    try
                //    {
                //        DataGridViewRow row = dgvFornecedores.Rows[e.RowIndex];
                //        lblID.Text = row.Cells["Id_Fornecedor"].Value.ToString();
                //        tbxNome.Text = row.Cells["Nome"].Value.ToString();
                //        tbxEmail.Text = row.Cells["Email"].Value.ToString();
                //        tbxEndereco.Text = row.Cells["Endereco"].Value.ToString();
                //        tbxTelefone.Text = row.Cells["Telefone"].Value.ToString();
                //        tbxTelefoneOpcional.Text = row.Cells["TelefoneOpcional"].Value.ToString();
                //        tbxProduto.Text = row.Cells["Produto"].Value.ToString();
                //    }
                //    catch (Exception ex)
                //    {

                //        throw new Exception(ex.Message.ToString());
                //    }
                //}
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (tbxNome.Text == string.Empty)
        //    {
        //        MessageBox.Show("Preencha o campo Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        tbxNome.Focus();
        //    }
        //    else if (tbxEmail.Text == string.Empty)
        //    {
        //        MessageBox.Show("Preencha o campo Email", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        tbxEmail.Focus();
        //    }
        //    else if (tbxEndereco.Text == string.Empty)
        //    {
        //        MessageBox.Show("Preencha o campo Endereço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        tbxEndereco.Focus();
        //    }
        //    else if (tbxTelefone.Text == string.Empty)
        //    {
        //        MessageBox.Show("Preencha o campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        tbxTelefone.Focus();
        //    }
        //    else if (tbxTelefoneOpcional.Text == string.Empty)
        //    {
        //        MessageBox.Show("Preencha o campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        tbxTelefoneOpcional.Focus();
        //    }
        //    else if (tbxProduto.Text == string.Empty)
        //    {
        //        MessageBox.Show("Preencha o campo Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        tbxProduto.Focus();
        //    }
        //    else
        //    {
        //        try
        //        {
        //            ENTIDADES.TBL_FORNECEDORES ent = new ENTIDADES.TBL_FORNECEDORES();
        //            MontarEntidades();
        //            ent.Id_Fornecedor = Objent.Id_Fornecedor;
        //            ent.Nome = Objent.Nome = Objent.Nome;
        //            ent.Email = Objent.Email = Objent.Email;
        //            ent.Endereco = Objent.Endereco;
        //            ent.Telefone = Objent.Telefone;
        //            ent.TelefoneOpcional = Objent.TelefoneOpcional;
        //            ent.Produto = Objent.Produto;
        //            ObjNeg_Fornecedores.ExcluirFornecedor(ent);
        //            MessageBox.Show("Fornecedor Excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            dgvFornecedores.DataSource = null;
        //            dgvFornecedores.DataSource = ObjNeg_Fornecedores.ListarFornecedores();

        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message.ToString());
        //        }
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
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
                        ENTIDADES.TBL_FORNECEDORES ent = new ENTIDADES.TBL_FORNECEDORES();
                        MontarEntidades();
                        ent.Id_Fornecedor = Objent.Id_Fornecedor;
                        ent.Nome = Objent.Nome;
                        ent.Email = Objent.Email;
                        ent.Endereco = Objent.Endereco;
                        ent.Telefone = Objent.Telefone;
                        ent.TelefoneOpcional = Objent.TelefoneOpcional;
                        ent.Produto = Objent.Produto;
                        ObjNeg_Fornecedores.AlterarFornecedor(ent);
                        MessageBox.Show("A alteração foi realizada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvFornecedores.DataSource = null;
                        dgvFornecedores.DataSource = ObjNeg_Fornecedores.ListarFornecedores();
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message.ToString());
                    }
                }

            }
        }
    }
}
