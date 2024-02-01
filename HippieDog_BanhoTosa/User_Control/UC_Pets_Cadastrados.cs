using ENTIDADES;
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

namespace HippieDog_BanhoTosa.User_Control
{
    public partial class tbxRaca : UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        private List<ENTIDADES.TBL_CADASTRAR_PET> listaPets;
        private int indiceAtual;

        NEGOCIOS.NEG_CADASTRAR_PET objNeg_CadastrarPet = new NEGOCIOS.NEG_CADASTRAR_PET();
        NEGOCIOS.NEG_BANHOETOSA ObjNeg_BanhoTosa = new NEGOCIOS.NEG_BANHOETOSA();
        public tbxRaca()
        {
            InitializeComponent();


        }

        private void CarregarComboRaca()
        {
            cbRaca.DataSource = ObjNeg_BanhoTosa.ListarRacas();
            cbRaca.ValueMember = "ID_RACA";
            cbRaca.DisplayMember = "NOME";
            cbRaca.SelectedIndex = -1;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            btnTeste.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTeste.Width, btnTeste.Height, 10, 10));

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
    }
}
