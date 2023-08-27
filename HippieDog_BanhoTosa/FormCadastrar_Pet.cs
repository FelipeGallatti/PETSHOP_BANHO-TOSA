using ENTIDADES;
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
    public partial class FormCadastrar_Pet : Form
    {
        NEGOCIOS.NEG_CADASTRAR_PET ObjNeg_CadastrarPet = new NEGOCIOS.NEG_CADASTRAR_PET();
        public FormCadastrar_Pet()
        {
            InitializeComponent();
        }


        private void CarregarComboRaca()
        {
            cbRaca.ValueMember = "ID_RACA";
            cbRaca.DisplayMember = "NOME";
            cbRaca.SelectedIndex = -1;
        }




        private void FormCadastrar_Pet_Load(object sender, EventArgs e)
        {
            chkMedio.Checked = true;
            
        }

        private void chkPequena_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkPequena.Checked) { cbRaca.DataSource = ObjNeg_CadastrarPet.ListarRacasPequenas();
                    CarregarComboRaca();
                }

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void chkMedio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkMedio.Checked) { cbRaca.DataSource = ObjNeg_CadastrarPet.ListarRacasMedia();
                    CarregarComboRaca();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }

        private void chkGrande_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkGrande.Checked) { cbRaca.DataSource = ObjNeg_CadastrarPet.ListarRacasGrandes();
                    CarregarComboRaca();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Você deseja cadastrar um novo pet?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) {  return; }

                TBL_CADASTRAR_PET ent = new TBL_CADASTRAR_PET();
                ent.DONO = tbxDono.Text; ent.PET = tbxPet.Text; ent.ENDERECO = tbxEndereco.Text; ent.RACA = Convert.ToInt32(cbRaca.SelectedValue); ent.TELEFONE = tbxTelefone.Text;

                ObjNeg_CadastrarPet.InserirPet(ent);

                MessageBox.Show("Pet Inserido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
