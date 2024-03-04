using ENTIDADES;
using HippieDog_BanhoTosa.Classes;
using HippieDog_BanhoTosa.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace HippieDog_BanhoTosa.User_Control
{
    public partial class UC_Cadastrar_Pet : UserControl
    {

        NEGOCIOS.NEG_CADASTRAR_PET ObjNeg_CadastrarPet = new NEGOCIOS.NEG_CADASTRAR_PET();
        NEGOCIOS.NEG_BANHOETOSA ObjNeg_BanhoTosa = new NEGOCIOS.NEG_BANHOETOSA();

        byte[] bytesDaImagem;
        string caminhoDaImagem;

        public UC_Cadastrar_Pet()
        {
            InitializeComponent();
        }

        private void ArredondarBordas()
        {
            try
            {
                Borda_Botao borderBotao = new Borda_Botao();
                borderBotao.AdicionarBotaoArredondado(btnAdicionar, 10);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        private void CarregarComboRaca()
        {
            cbRaca.DataSource = ObjNeg_BanhoTosa.ListarRacas();
            cbRaca.ValueMember = "ID_RACA";
            cbRaca.DisplayMember = "NOME";
            cbRaca.SelectedIndex = -1;


            
            chkGrande.Checked = false;
            chkMedio.Checked = false;
            chkPequena.Checked = false;

        }

        private bool validarCampos()
        {
            try
            {
                bool validar = false;

                if (tbxDono.Text == string.Empty) { MessageBox.Show("Preencha o campo (Dono)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (tbxEndereco.Text == string.Empty) { MessageBox.Show("Preencha o campo (Endereço)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (tbxPet.Text == string.Empty) { MessageBox.Show("Preencha o campo (Pet)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (tbxTelefone.Text == string.Empty) { MessageBox.Show("Preencha o campo (Telefone)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (cbRaca.SelectedIndex.Equals(-1)) { MessageBox.Show("Preencha o campo (Raça)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                {
                    validar = true;
                }
                return validar;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void LimparCampos()
        {
            try
            {
                tbxDono.Text = string.Empty; 
                tbxPet.Text = string.Empty;
                tbxEndereco.Text = string.Empty;
                tbxTelefone.Text = string.Empty;
                radRichTextEditor1.Text = string.Empty;
                cbRaca.SelectedIndex = -1;
                pictureBox1.Image = Resources.dogface;
                    
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    DialogResult result = MessageBox.Show($"Você deseja cadastrar o {tbxPet.Text}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ObjNeg_CadastrarPet.CadastrarPet(tbxDono.Text, tbxPet.Text, tbxEndereco.Text, tbxTelefone.Text, cbRaca.SelectedIndex, bytesDaImagem, dtCadastro.Value);
                        MessageBox.Show($"{tbxPet.Text} cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void UC_Cadastrar_Pet_Load(object sender, EventArgs e)
        {
            CarregarComboRaca();
            ArredondarBordas();
        }

        private void cbRaca_SelectedIndexChanged(object sender, EventArgs e)
         {
            if (cbRaca.SelectedItem != null)
            {
                int porteSelecionado = ((TBL_RACAS)cbRaca.SelectedItem).PORTE;

                // Desmarque todos os RadioButtons
                chkPequena.Checked = false;
                chkMedio.Checked = false;
                chkGrande.Checked = false;

                // Marque o RadioButton correspondente ao porte da raça selecionada
                switch (porteSelecionado)
                {
                    case 1:
                        chkPequena.Checked = true;
                        break;
                    case 2:
                        chkMedio.Checked = true;
                        break;
                    case 3:
                        chkGrande.Checked = true;
                        break;
                    default:

                        break;
                }
            }
        }

        private void btnAlterarImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";
                openFileDialog.Title = "Selecione uma imagem para o pet";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoDaImagem = openFileDialog.FileName;

                    // Carregar a imagem para um objeto Image
                    Image imagemDoPet = Image.FromFile(caminhoDaImagem);

                    // Converter a imagem para um array de bytes
                    
                    using (MemoryStream stream = new MemoryStream())
                    {
                        imagemDoPet.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytesDaImagem = stream.ToArray();
                    }

                    pictureBox1.Image = imagemDoPet;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

       
        

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";
                openFileDialog.Title = "Selecione uma imagem para o pet";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoDaImagem = openFileDialog.FileName;

                    // Carregar a imagem para um objeto Image
                    Image imagemDoPet = Image.FromFile(caminhoDaImagem);

                    // Converter a imagem para um array de bytes

                    using (MemoryStream stream = new MemoryStream())
                    {
                        imagemDoPet.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytesDaImagem = stream.ToArray();
                    }

                    pictureBox1.Image = imagemDoPet;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                btnAddFoto.Visible = false;
            }
        }
    }

}
