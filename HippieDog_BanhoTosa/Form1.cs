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
            FormAgenda formAgenda = new FormAgenda();
            formAgenda.MdiParent = this;
            formAgenda.Show();
        }

        private void btnAgendarBanho_Click(object sender, EventArgs e)
        {
            FormAgendar_Banho formAgendarBanho = new FormAgendar_Banho();
            formAgendarBanho.MdiParent = this;
            formAgendarBanho.Show();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            FormFinanceiro formFinanceiro = new FormFinanceiro();
            formFinanceiro.MdiParent = this;
            formFinanceiro.Show();
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            FormContasPagar formContasPagar = new FormContasPagar();
            formContasPagar.MdiParent = this;
            formContasPagar.Show();
            
        }

        private void btnPacotes_Click(object sender, EventArgs e)
        {
            FormPacotes formPacotes = new FormPacotes();
            formPacotes.MdiParent = this;
            formPacotes.Show();
        }

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            FormCadastrar_Pet formCadastrar = new FormCadastrar_Pet();
            formCadastrar.MdiParent = this;
            formCadastrar.Show();
        }
    }
}
