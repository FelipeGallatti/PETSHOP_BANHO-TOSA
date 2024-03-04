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

namespace HippieDog_BanhoTosa
{
    public partial class FormAdicionar_ContasPagar : Form
    {
        NEGOCIOS.NEG_CONTASPAGAR ObjNeg_ContaSPagar = new NEGOCIOS.NEG_CONTASPAGAR();
        public FormAdicionar_ContasPagar()
        {
            InitializeComponent();
        }
        private void ArredondarBordas()
        {
            try
            {
                Borda_Botao borderBotao = new Borda_Botao();
                borderBotao.AdicionarBotaoArredondado(btnSair, 10);
                borderBotao.AdicionarBotaoArredondado(btnAlterar, 10);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void FormAdicionar_ContasPagar_Load(object sender, EventArgs e)
        {
            try
            {

                cbCategoria.DisplayMember = "CATEGORIA_SERVICO";
                cbCategoria.ValueMember = "ID_SERVICO";
                cbCategoria.SelectedIndex = -1;

                cbCategoria.DataSource = ObjNeg_ContaSPagar.ListarCategoriaServicos();
                ArredondarBordas();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
