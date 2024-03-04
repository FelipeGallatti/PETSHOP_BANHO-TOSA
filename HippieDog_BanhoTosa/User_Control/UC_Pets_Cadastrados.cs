using ENTIDADES;
using HippieDog_BanhoTosa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HippieDog_BanhoTosa.User_Control
{
    public partial class tbxRaca : UserControl
    {
        private List<ENTIDADES.TBL_CADASTRAR_PET> listaPets;
        private int indiceAtual;

        NEGOCIOS.NEG_CADASTRAR_PET objNeg_CadastrarPet = new NEGOCIOS.NEG_CADASTRAR_PET();
        NEGOCIOS.NEG_BANHOETOSA ObjNeg_BanhoTosa = new NEGOCIOS.NEG_BANHOETOSA();


        byte[] bytesDaImagem;
        string caminhoDaImagem;

        int idPet;

        public tbxRaca()
        {
            InitializeComponent();
        }
        private void ArredondarBordas()
        {
            try
            {
                Borda_Botao borderBotao = new Borda_Botao();
                borderBotao.AdicionarBotaoArredondado(btnAvancar, 10);
                borderBotao.AdicionarBotaoArredondado(btnRetroceder, 10);
                borderBotao.AdicionarBotaoArredondado(btnAlterar, 10);


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

        }



        private Image DeBytePraImagem(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            Image imagem = Image.FromStream(ms);
            return imagem;
        }

        private void ExibirPetAtual()
        {
            listaPets = objNeg_CadastrarPet.ListarPetsCadastrados();

            if (listaPets.Count > 0 && indiceAtual >= 0 && indiceAtual < listaPets.Count)
            {
                ENTIDADES.TBL_CADASTRAR_PET petAtual = listaPets[indiceAtual];
                idPet = petAtual.ID;
                tbxDono.Text = petAtual.DONO.ToString();
                tbxEndereco.Text = petAtual.ENDERECO;
                tbxPet.Text = petAtual.PET;
                tbxTelefone.Text = petAtual.TELEFONE;
                cbRaca.SelectedValue = petAtual.RACA;
                dtCadastro.Value = petAtual.DATA_CADASTRO;
                // Exibir a imagem no PictureBox
                if (petAtual.FOTO != null && petAtual.FOTO.Length > 0)
                {
                    Image imagem = DeBytePraImagem(petAtual.FOTO);
                    pictureBox1.Image = imagem;
                }
                else
                {
                    // Caso a coluna de FOTO esteja vazia, você pode definir uma imagem padrão ou limpar o PictureBox
                    pictureBox1.Image = null;
                }
            }
        }

        private void UC_Pets_Cadastrados_Load(object sender, EventArgs e)
        {
            listaPets = objNeg_CadastrarPet.ListarPetsCadastrados();
            CarregarComboRaca();
            ExibirPetAtual();
            ArredondarBordas();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (indiceAtual > 0)
                {
                    indiceAtual--;
                    ExibirPetAtual();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                if (indiceAtual < listaPets.Count - 1)
                {
                    indiceAtual++;
                    ExibirPetAtual();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
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

        private void btnAtualizarFoto_Click(object sender, EventArgs e)
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
                objNeg_CadastrarPet.AtualizarFoto(idPet, bytesDaImagem);
                MessageBox.Show("Foto Atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                

                    ENTIDADES.TBL_CADASTRAR_PET buscaPet = new TBL_CADASTRAR_PET();
                    buscaPet = objNeg_CadastrarPet.BuscarPetCadastrado(tbxBuscar.Text);

                    if (listaPets.Count > 0 && indiceAtual >= 0 && indiceAtual < listaPets.Count)
                    {
                        idPet = buscaPet.ID;
                        tbxDono.Text = buscaPet.DONO.ToString();
                        tbxEndereco.Text = buscaPet.ENDERECO;
                        tbxPet.Text = buscaPet.PET;
                        tbxTelefone.Text = buscaPet.TELEFONE;
                        cbRaca.SelectedValue = buscaPet.RACA;
                        dtCadastro.Value = buscaPet.DATA_CADASTRO;
                        // Exibir a imagem no PictureBox
                        if (buscaPet.FOTO != null && buscaPet.FOTO.Length > 0)
                        {
                            Image imagem = DeBytePraImagem(buscaPet.FOTO);
                            pictureBox1.Image = imagem;
                        }
                        else
                        {
                            // Caso a coluna de FOTO esteja vazia, você pode definir uma imagem padrão ou limpar o PictureBox
                            pictureBox1.Image = null;
                        }
                    }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
