using HippieDog_BanhoTosa.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippieDog_BanhoTosa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            UC_Agenda ucAgenda = new UC_Agenda();

            // Remove o UserControl atual, se houver algum
            if (splitPanel1.Controls.Count > 0)
            {
                splitPanel1.Controls[0].Dispose();
            }

            splitPanel1.Controls.Add(ucAgenda);
            ucAgenda.Dock = DockStyle.Fill;
            ucAgenda.Show();
        }





        private void btnContasPagar_Click(object sender, EventArgs e)
        {

            try
            {
                UC_ContasPagar ucContasPagar = new UC_ContasPagar();
                // Remove o UserControl atual, se houver algum
                if (splitPanel1.Controls.Count > 0)
                {
                    splitPanel1.Controls[0].Dispose();
                }

                splitPanel1.Controls.Add(ucContasPagar);
                ucContasPagar.Dock = DockStyle.Fill;
                ucContasPagar.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            
        }

        private void btnPacotes_Click(object sender, EventArgs e)
        {
            UC_Pacotes ucPacotes = new UC_Pacotes();

            // Remove o UserControl atual, se houver algum
            if (splitPanel1.Controls.Count > 0)
            {
                splitPanel1.Controls[0].Dispose();
            }

            splitPanel1.Controls.Add(ucPacotes);
            ucPacotes.Dock = DockStyle.Fill;
            ucPacotes.Show();
        }

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            UC_Cadastrar_Pet ucCadastrarPet = new UC_Cadastrar_Pet();

            // Remove o UserControl atual, se houver algum
            if (splitPanel1.Controls.Count > 0)
            {
                splitPanel1.Controls[0].Dispose();
            }

            splitPanel1.Controls.Add(ucCadastrarPet);
            ucCadastrarPet.Dock = DockStyle.Fill;
            ucCadastrarPet.Show();
        }

        private void btnAgendaFaltas_Click(object sender, EventArgs e)
        {
            UC_AgendaFaltas ucAgendaFaltas = new UC_AgendaFaltas();

            // Remove o UserControl atual, se houver algum
            if (splitPanel1.Controls.Count > 0)
            {
                splitPanel1.Controls[0].Dispose();
            }

            splitPanel1.Controls.Add(ucAgendaFaltas);
            ucAgendaFaltas.Dock = DockStyle.Fill;
            ucAgendaFaltas.Show();
        }

        private void btnHisBanho_Click(object sender, EventArgs e)
        {
            UC_HistBanho ucHistoricoBanhos = new UC_HistBanho();

            // Remove o UserControl atual, se houver algum
            if (splitPanel1.Controls.Count > 0)
            {
                splitPanel1.Controls[0].Dispose();
            }

            splitPanel1.Controls.Add(ucHistoricoBanhos);
            ucHistoricoBanhos.Dock = DockStyle.Fill;
            ucHistoricoBanhos.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            UC_Fornecedores ucFornecedores = new UC_Fornecedores();

            // Remove o UserControl atual, se houver algum
            if (splitPanel1.Controls.Count > 0)
            {
                splitPanel1.Controls[0].Dispose();
            }

            splitPanel1.Controls.Add(ucFornecedores);
            ucFornecedores.Dock = DockStyle.Fill;
            ucFornecedores.Show();
        }
    }
}
