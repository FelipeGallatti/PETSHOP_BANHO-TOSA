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
    public partial class FormPacotes : Form
    {
        NEGOCIOS.NEG_CADASTRAR_PET Objneg_Cadastrar = new NEGOCIOS.NEG_CADASTRAR_PET();
        public FormPacotes()
        {
            InitializeComponent();
        }

        private void CarregarComboBox()
        {
            //cboRacasPequenas.DataSource = Objneg_Cadastrar.ListarRacasPequenas();
            //cboRacasMedia.DataSource = Objneg_Cadastrar.ListarRacasMedia();
            //cboRacasGrande.DataSource = Objneg_Cadastrar.ListarRacasGrandes();

            ////Combo raças pequenas
            //cboRacasPequenas.ValueMember = "ID_RACA";
            //cboRacasPequenas.DisplayMember = "NOME";
            //cboRacasPequenas.SelectedIndex = -1;

            ////Combo raças pequenas
            //cboRacasMedia.ValueMember = "ID_RACA";
            //cboRacasMedia.DisplayMember = "NOME";
            //cboRacasMedia.SelectedIndex = -1;

            ////Combo raças pequenas
            //cboRacasGrande.ValueMember = "ID_RACA";
            //cboRacasGrande.DisplayMember = "NOME";
            //cboRacasGrande.SelectedIndex = -1;
        }

        private void CalcularValorPacote_Pequeno()
        {
            try
            {
                // Lógica para calcular o valor com base nas seleções
                double valorBase = 0;

                // Defina os valores base para diferentes raças (exemplo)




                if (cboRacasPequenas.SelectedIndex > -1)
                {
                    valorBase = 30;
                }
                if (cbQtBanhoPq.SelectedIndex == 0)
                {
                    valorBase = 3 * valorBase;
                }
                if (cbQtBanhoPq.SelectedIndex == 1)
                {
                    valorBase = 6 * valorBase;
                }
                if (cbQtBanhoPq.SelectedIndex == 2)
                {
                    valorBase = 9 * valorBase;
                }
                // Acrescente um valor para entrega, se selecionada
                if (cbLevaTrazPq.SelectedIndex == 0)
                {
                    valorBase += 10;
                }


                // Modifique o valor exibido no ComboBox de valor
                cbValorPq.Items.Clear();
                cbValorPq.Items.Add($"R$ {valorBase:F2}");
                cbValorPq.SelectedIndex = 0; // Seleciona o único item adicionado

                // Você também pode armazenar esse valorBase em uma variável global para uso posterior, como cálculos de pagamento, etc.

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
           
        }

        private void CalcularValorPacote_Medio()
        {
            try
            {
                double valorbase = 45;

                if (cboRacasMedia.SelectedIndex > -1)
                {
                    
                }
                if (cbQtBanhoMed.SelectedIndex.Equals(0))
                {
                    valorbase = 3 * valorbase;
                }
                if (cbLevaTrazMed.SelectedIndex.Equals(0))
                {
                    valorbase += 15;
                }

                cbValorMed.Items.Clear();
                cbValorMed.Items.Add($"RS$ {valorbase:F2}");
                cbValorMed.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void FormPacotes_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
        }

        private void levaTrazPq_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboRacasPequenas.DataSource == Objneg_Cadastrar.ListarRacasPequenas())
            //{
            //    MessageBox.Show("certo", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularValorPacote_Pequeno();
        }

        private void btnCalcularMedio_Click(object sender, EventArgs e)
        {
            CalcularValorPacote_Medio();
        }
    }
}
