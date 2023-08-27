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
    public partial class FormFinanceiro : Form
    {

        NEGOCIOS.NEG_BANHOETOSA ObjNeg = new NEGOCIOS.NEG_BANHOETOSA();
        NEGOCIOS.NEG_CONTASPAGAR Objneg_contas = new NEGOCIOS.NEG_CONTASPAGAR();    
        public FormFinanceiro()
        {
            InitializeComponent();
        }

        private void FormFinanceiro_Load(object sender, EventArgs e)
        {
            // Suponha que a semana desejada seja de segunda-feira a domingo
            // Get the current date and time.
            DateTime now = DateTime.Now;

            // Get the start of the week.
            DateTime dataInicioSemana = now.AddDays(now.DayOfWeek - DayOfWeek.Sunday);

            // Get the end of the week.
            DateTime dataFimSemana = dataInicioSemana.AddDays(6);

            DateTime dataInicioMes = new DateTime(2023, 7, 1);
            DateTime dataFimMes = new DateTime(2023, 7, 30);


            dgvHistBanhos.DataSource = ObjNeg.ListarHistorico();
            textBox1.Text = ObjNeg.GanhosDiarios().ToString(); 
            tbxRendaSemanal.Text = ObjNeg.GanhosSemanais(dataInicioSemana, dataFimSemana).ToString();
            tbxRendaMensal.Text = ObjNeg.GanhosMensal(dataInicioMes, dataFimMes).ToString();
            tbxBanhosSemanais.Text = ObjNeg.BanhosSemanais(dataInicioSemana, dataFimSemana).ToString();
            tbxBanhosMensais.Text = ObjNeg.BanhosMensais(dataInicioMes, dataFimMes).ToString();

            lblTotal.Text = Objneg_contas.GanhosTotal().ToString();
         

        }
    }
}
