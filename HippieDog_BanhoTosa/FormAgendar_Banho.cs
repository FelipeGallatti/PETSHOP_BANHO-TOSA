using ENTIDADES;
using HippieDog_BanhoTosa.Classes;
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
    public partial class FormAgendar_Banho : Form
    {
        ENTIDADES.TBL_AGENDA ObjEnt = new ENTIDADES.TBL_AGENDA();
        NEGOCIOS.NEG_BANHOETOSA ObjNeg = new NEGOCIOS.NEG_BANHOETOSA();


        int porteSelecionado = 0;

        public FormAgendar_Banho()
        {
            InitializeComponent();
        }

        private void CarregarComboRaca()
        {
            cbRaca.DisplayMember = "NOME";
            cbRaca.ValueMember = "ID_RACA";
            cbRaca.DataSource = ObjNeg.ListarRacas();
            cbRaca.SelectedIndex = -1;
        }

        private void ArredondarBordas()
        {
            try
            {
                Borda_Botao borderBotao = new Borda_Botao();
                borderBotao.AdicionarBotaoArredondado(btnAgendar, 10);
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
                dtData.Value = DateTime.Today;
                dtHora.Value = DateTime.Now;
                tbxDono.Text = string.Empty;
                tbxPet.Text = string.Empty;
                tbxTelefone.Text = string.Empty;
                tbxValor.Text = string.Empty;
                tbxDetalhes.Text = string.Empty;
                cbRaca.SelectedIndex = -1;
                cbServico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void CarregarComboServicos()
        {
            cbServico.DisplayMember = "NOME_SERVICO";
            cbServico.ValueMember = "ID_SERVICO";
            cbServico.DataSource = ObjNeg.ListarServicos();
            cbServico.SelectedIndex = -1;
        }

        public void AgendarBanho()
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja agendar o banho?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    TimeSpan selectedTime = new TimeSpan(dtHora.Value.Hour, dtHora.Value.Minute, 0);

                    if (tbxValor.Text == string.Empty)
                    {
                        tbxValor.Text = "0";
                    }



                    ObjNeg.AgendarBanho(tbxDono.Text, tbxTelefone.Text, cbServico.Text, tbxPet.Text, tbxDetalhes.Text, dtData.Value, selectedTime.ToString(), Convert.ToDecimal(tbxValor.Text), Convert.ToInt32(cbRaca.SelectedValue));
                    MessageBox.Show("O banho foi agendado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();

                }

                catch (Exception ex)
                {

                    throw new Exception(ex.Message.ToString());
                }
            }
            else
            {
                return;
            }
        }



        private void FormAgendar_Banho_Load(object sender, EventArgs e)
        {
            CarregarComboRaca();
            CarregarComboServicos();
            ArredondarBordas();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                AgendarBanho();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }


        }


        private void cbRaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbRaca.SelectedItem != null)
                {
                    // Obtém o índice selecionado na ComboBox
                    int indiceSelecionado = cbRaca.SelectedIndex;

                    // Verifica se o índice selecionado é válido
                    if (indiceSelecionado >= 0)
                    {
                        // Supondo que você tem uma lista de objetos Racas com propriedades ID_RACA, NOME_RACA e PORTE
                        List<TBL_RACAS> listaRacas = ObjNeg.ListarRacas(); // Função  para obter a lista de raças

                        // Obtém o porte correspondente ao índice selecionado na ComboBox
                        porteSelecionado = listaRacas[indiceSelecionado].PORTE;

                        // Faça o que deseja com o valor do porte selecionado
                        Console.WriteLine("Porte selecionado: " + porteSelecionado);
                    }
                }






                int idtiposervico = Convert.ToInt32(cbServico.SelectedValue); // Mantenha cbServico


                tbxValor.Text = Convert.ToString(ObjNeg.CalcularValorServico(idtiposervico, porteSelecionado));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void cbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idtiposervico = Convert.ToInt32(cbServico.SelectedValue); // Mantenha cbServico


            tbxValor.Text = Convert.ToString(ObjNeg.CalcularValorServico(idtiposervico, porteSelecionado).ToString("N2"));
        }
    }
}
