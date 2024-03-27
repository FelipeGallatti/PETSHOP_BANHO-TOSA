using HippieDog_BanhoTosa.Classes;
using HippieDog_BanhoTosa.Properties;
using HippieDog_BanhoTosa.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace HippieDog_BanhoTosa
{
    public partial class Menu : Form
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

        private void ArredondarCantosBotoes()
        {
            try
            {
                AdicionarBotaoArredondado(btnAgendaFaltas, 10);
                AdicionarBotaoArredondado(btnAgenda, 10);
                AdicionarBotaoArredondado(btnHisBanho, 10);
                AdicionarBotaoArredondado(btnFornecedores, 10);
                AdicionarBotaoArredondado(btnContasPagar, 10);
                AdicionarBotaoArredondado(btnPetsCadastrados, 10);
                AdicionarBotaoArredondado(btnCadastrarPet, 10);
                AdicionarBotaoArredondado(btnAdm, 10);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        } 

        public Menu()
        {
            InitializeComponent();
            ArredondarCantosBotoes();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                this.Text = ENTIDADES.ENT_APOIO.InfoUsuario._nome;

                if (ENTIDADES.ENT_APOIO.InfoUsuario._permissao == 3)
                {
                    btnAdm.Visible = true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        private void MarcarBotaoSelecionadoAgenda()
        {
            try
            {
                Color novaCor = Color.FromArgb(44, 110, 167);
                btnAgenda.BackgroundImage = null;
                btnAgenda.ForeColor = Color.White;
                btnAgenda.BackColor = novaCor;

                btnAgendaFaltas.BackgroundImage = Resources.gradient__4_;
                btnAgendaFaltas.ForeColor = Color.Black;

                btnHisBanho.BackgroundImage = Resources.gradient__4_;
                btnHisBanho.ForeColor = Color.Black;

                btnFornecedores.BackgroundImage = Resources.gradient__4_;
                btnFornecedores.ForeColor = Color.Black;

                btnContasPagar.BackgroundImage = Resources.gradient__4_;
                btnContasPagar.ForeColor = Color.Black;

                btnPetsCadastrados.BackgroundImage = Resources.gradient__4_;
                btnPetsCadastrados.ForeColor = Color.Black;

                btnCadastrarPet.BackgroundImage = Resources.gradient__4_;
                btnCadastrarPet.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void MarcarBotaoSelecionadoAgendaFaltas()
        {
            try
            {
                Color novaCor = Color.FromArgb(44, 110, 167);
                btnAgendaFaltas.BackgroundImage = null;
                btnAgendaFaltas.ForeColor = Color.White;
                btnAgendaFaltas.BackColor = novaCor;

                btnAgenda.BackgroundImage = Resources.gradient__4_;
                btnAgenda.ForeColor = Color.Black;

                btnHisBanho.BackgroundImage = Resources.gradient__4_;
                btnHisBanho.ForeColor = Color.Black;

                btnFornecedores.BackgroundImage = Resources.gradient__4_;
                btnFornecedores.ForeColor = Color.Black;

                btnContasPagar.BackgroundImage = Resources.gradient__4_;
                btnContasPagar.ForeColor = Color.Black;

                btnPetsCadastrados.BackgroundImage = Resources.gradient__4_;
                btnPetsCadastrados.ForeColor = Color.Black;

                btnCadastrarPet.BackgroundImage = Resources.gradient__4_;
                btnCadastrarPet.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void MarcarBotaoSelecionadoHistorico()
        {
            try
            {
                Color novaCor = Color.FromArgb(44, 110, 167);
                btnHisBanho.BackgroundImage = null;
                btnHisBanho.ForeColor = Color.White;
                btnHisBanho.BackColor = novaCor;

                btnAgenda.BackgroundImage = Resources.gradient__4_;
                btnAgenda.ForeColor = Color.Black;

                btnAgendaFaltas.BackgroundImage = Resources.gradient__4_;
                btnAgendaFaltas.ForeColor = Color.Black;

                btnFornecedores.BackgroundImage = Resources.gradient__4_;
                btnFornecedores.ForeColor = Color.Black;

                btnContasPagar.BackgroundImage = Resources.gradient__4_;
                btnContasPagar.ForeColor = Color.Black;

                btnPetsCadastrados.BackgroundImage = Resources.gradient__4_;
                btnPetsCadastrados.ForeColor = Color.Black;

                btnCadastrarPet.BackgroundImage = Resources.gradient__4_;
                btnCadastrarPet.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void MarcarBotaoSelecionadoFornecedores()
        {
            try
            {
                Color novaCor = Color.FromArgb(44, 110, 167);
                btnFornecedores.BackgroundImage = null;
                btnFornecedores.ForeColor = Color.White;
                btnFornecedores.BackColor = novaCor;

                btnAgenda.BackgroundImage = Resources.gradient__4_;
                btnAgenda.ForeColor = Color.Black;

                btnAgendaFaltas.BackgroundImage = Resources.gradient__4_;
                btnAgendaFaltas.ForeColor = Color.Black;

                btnHisBanho.BackgroundImage = Resources.gradient__4_;
                btnHisBanho.ForeColor = Color.Black;

                btnContasPagar.BackgroundImage = Resources.gradient__4_;
                btnContasPagar.ForeColor = Color.Black;

                btnPetsCadastrados.BackgroundImage = Resources.gradient__4_;
                btnPetsCadastrados.ForeColor = Color.Black;

                btnCadastrarPet.BackgroundImage = Resources.gradient__4_;
                btnCadastrarPet.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void MarcarBotaoSelecionadoContasPagar()
        {
            try
            {
                Color novaCor = Color.FromArgb(44, 110, 167);
                btnContasPagar.BackgroundImage = null;
                btnContasPagar.ForeColor = Color.White;
                btnContasPagar.BackColor = novaCor;

                btnAgenda.BackgroundImage = Resources.gradient__4_;
                btnAgenda.ForeColor = Color.Black;

                btnAgendaFaltas.BackgroundImage = Resources.gradient__4_;
                btnAgendaFaltas.ForeColor = Color.Black;

                btnHisBanho.BackgroundImage = Resources.gradient__4_;
                btnHisBanho.ForeColor = Color.Black;

                btnFornecedores.BackgroundImage = Resources.gradient__4_;
                btnFornecedores .ForeColor = Color.Black;

                btnPetsCadastrados.BackgroundImage = Resources.gradient__4_;
                btnPetsCadastrados.ForeColor = Color.Black;

                btnCadastrarPet.BackgroundImage = Resources.gradient__4_;
                btnCadastrarPet.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void MarcarBotaoSelecionadoPetsCadastrados()
        {
            try
            {
                Color novaCor = Color.FromArgb(44, 110, 167);
                btnPetsCadastrados.BackgroundImage = null;
                btnPetsCadastrados.ForeColor = Color.White;
                btnPetsCadastrados.BackColor = novaCor;

                btnAgenda.BackgroundImage = Resources.gradient__4_;
                btnAgenda.ForeColor = Color.Black;

                btnAgendaFaltas.BackgroundImage = Resources.gradient__4_;
                btnAgendaFaltas.ForeColor = Color.Black;

                btnHisBanho.BackgroundImage = Resources.gradient__4_;
                btnHisBanho.ForeColor = Color.Black;

                btnFornecedores.BackgroundImage = Resources.gradient__4_;
                btnFornecedores.ForeColor = Color.Black;

                btnContasPagar.BackgroundImage = Resources.gradient__4_;
                btnContasPagar.ForeColor = Color.Black;

                btnCadastrarPet.BackgroundImage = Resources.gradient__4_;
                btnCadastrarPet.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void MarcarBotaoSelecionadoCadastrarPet()
        {
            try
            {
                Color novaCor = Color.FromArgb(44, 110, 167);
                btnCadastrarPet.BackgroundImage = null;
                btnCadastrarPet.ForeColor = Color.White;
                btnCadastrarPet.BackColor = novaCor;

                btnAgenda.BackgroundImage = Resources.gradient__4_;
                btnAgenda.ForeColor = Color.Black;

                btnAgendaFaltas.BackgroundImage = Resources.gradient__4_;
                btnAgendaFaltas.ForeColor = Color.Black;

                btnHisBanho.BackgroundImage = Resources.gradient__4_;
                btnHisBanho.ForeColor = Color.Black;

                btnFornecedores.BackgroundImage = Resources.gradient__4_;
                btnFornecedores.ForeColor = Color.Black;

                btnContasPagar.BackgroundImage = Resources.gradient__4_;
                btnContasPagar.ForeColor = Color.Black;

                btnPetsCadastrados.BackgroundImage = Resources.gradient__4_;
                btnPetsCadastrados.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        private void AdicionarBotaoArredondado(Button botao, int raio)
        {
            RectangleF rect = new RectangleF(0, 0, botao.Width, botao.Height);
            GraphicsPath graphPath = GetRoundPath(rect, raio);
            botao.Region = new Region(graphPath);

            botao.Paint += (sender, e) =>
            {
                using (Pen pen = new Pen(Color.Gray, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, graphPath);
                }
            };
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            try
            {
                UC_Agenda ucAgenda = new UC_Agenda();
                MarcarBotaoSelecionadoAgenda();
                this.Cursor = Cursors.WaitCursor;

                // Remove o UserControl atual, se houver algum
                if (panelFormulario.Controls.Count > 0)
                {
                    panelFormulario.Controls[0].Dispose();
                }

                panelFormulario.Controls.Add(ucAgenda);
                ucAgenda.Dock = DockStyle.Fill;
                ucAgenda.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally { this.Cursor = Cursors.Default;}

        }





        private void btnContasPagar_Click(object sender, EventArgs e)
        {

            try
            {
                MarcarBotaoSelecionadoContasPagar();
                UC_ContasPagar ucContasPagar = new UC_ContasPagar();

                this.Cursor = Cursors.WaitCursor;

                // Remove o UserControl atual, se houver algum
                if (panelFormulario.Controls.Count > 0)
                {
                    panelFormulario.Controls[0].Dispose();
                }

                panelFormulario.Controls.Add(ucContasPagar);
                ucContasPagar.Dock = DockStyle.Fill;
                ucContasPagar.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally { this.Cursor = Cursors.Default;}           
        }

        private void btnPetsCadastrados_Click(object sender, EventArgs e)
        {
            try
            {
                MarcarBotaoSelecionadoPetsCadastrados();
                tbxRaca ucPetsCadastrados = new tbxRaca();

                this.Cursor = Cursors.WaitCursor;

                // Remove o UserControl atual, se houver algum
                if (panelFormulario.Controls.Count > 0)
                {
                    panelFormulario.Controls[0].Dispose();
                }

                panelFormulario.Controls.Add(ucPetsCadastrados);
                ucPetsCadastrados.Dock = DockStyle.Fill;
                ucPetsCadastrados.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally { this.Cursor = Cursors.Default;}         
        }

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            try
            {
                MarcarBotaoSelecionadoCadastrarPet();
                UC_Cadastrar_Pet ucCadastrarPet = new UC_Cadastrar_Pet();

                this.Cursor = Cursors.WaitCursor;

                // Remove o UserControl atual, se houver algum
                if (panelFormulario.Controls.Count > 0)
                {
                    panelFormulario.Controls[0].Dispose();
                }

                panelFormulario.Controls.Add(ucCadastrarPet);
                ucCadastrarPet.Dock = DockStyle.Fill;
                ucCadastrarPet.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally { this.Cursor = Cursors.Default;}

        }

        private void btnAgendaFaltas_Click(object sender, EventArgs e)
        {
            try
            {
                MarcarBotaoSelecionadoAgendaFaltas();
                UC_AgendaFaltas ucAgendaFaltas = new UC_AgendaFaltas();
                this.Cursor = Cursors.WaitCursor;
                // Remove o UserControl atual, se houver algum
                if (panelFormulario.Controls.Count > 0)
                {
                    panelFormulario.Controls[0].Dispose();
                }

                panelFormulario.Controls.Add(ucAgendaFaltas);
                ucAgendaFaltas.Dock = DockStyle.Fill;
                ucAgendaFaltas.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally { this.Cursor = Cursors.Default;}
        }

        private void btnHisBanho_Click(object sender, EventArgs e)
        {
            try
            {
                MarcarBotaoSelecionadoHistorico();
                UC_HistBanho ucHistoricoBanhos = new UC_HistBanho();

                this.Cursor = Cursors.WaitCursor;

                // Remove o UserControl atual, se houver algum
                if (panelFormulario.Controls.Count > 0)
                {
                    panelFormulario.Controls[0].Dispose();
                }

                panelFormulario.Controls.Add(ucHistoricoBanhos);
                ucHistoricoBanhos.Dock = DockStyle.Fill;
                ucHistoricoBanhos.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally { this.Cursor = Cursors.Default;}

        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                MarcarBotaoSelecionadoFornecedores();
                UC_Fornecedores ucFornecedores = new UC_Fornecedores();

                this.Cursor = Cursors.WaitCursor;

                // Remove o UserControl atual, se houver algum
                if (panelFormulario.Controls.Count > 0)
                {
                    panelFormulario.Controls[0].Dispose();
                }

                panelFormulario.Controls.Add(ucFornecedores);
                ucFornecedores.Dock = DockStyle.Fill;
                ucFornecedores.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            finally { this.Cursor = Cursors.Default;}

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdministrador formAdm = new FormAdministrador();
                formAdm.ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
