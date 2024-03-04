using HippieDog_BanhoTosa.Classes;
using HippieDog_BanhoTosa.User_Control;
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

    public partial class FormLogin : Form
    {

        NEGOCIOS.NEG_LOGIN ObjNeg_Login = new NEGOCIOS.NEG_LOGIN();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ArredondarBordas()
        {
            try
            {
                Borda_Botao borderBotao = new Borda_Botao();
                borderBotao.AdicionarBotaoArredondado(btnEntrar, 10);
                borderBotao.AdicionarBotaoArredondado(btnSair, 10);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private bool validarCampos()
        {
            try
            {
                bool validar = false;

                if (tbxUsuario.Text == string.Empty) { MessageBox.Show("Preencha o campo (Usuário)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (tbxSenha.Text.Equals(string.Empty)) { MessageBox.Show("Preencha o campo (Senha)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                {
                    validar = true;
                }
                return validar;

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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (ObjNeg_Login.VerificarLogin(tbxUsuario.Text, tbxSenha.Text))
                    {
                        Menu form = new Menu();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally { this.Cursor = Cursors.Default;}

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                ArredondarBordas();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
