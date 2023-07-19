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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormFinanceiro formFinanceiro = new FormFinanceiro();
            formFinanceiro.MdiParent = this;
            formFinanceiro.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormAgenda formAgenda = new FormAgenda();
            formAgenda.MdiParent = this;
            formAgenda.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormAgendar_Banho formAgendar = new FormAgendar_Banho();
            formAgendar.MdiParent = this;
            formAgendar.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedores formFornecedores = new FormFornecedores();
            formFornecedores.MdiParent= this;
            formFornecedores.Show();
        }
    }
}
