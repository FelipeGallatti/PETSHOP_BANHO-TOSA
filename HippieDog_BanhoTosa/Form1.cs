using HippieDog_BanhoTosa.Classes;
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

namespace HippieDog_BanhoTosa
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, btnAgenda.Width, btnAgenda.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 10))
            {
                btnAgenda.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }


        private void btnAgenda_Click(object sender, EventArgs e)
        {
            UC_Agenda ucAgenda = new UC_Agenda();

            // Remove o UserControl atual, se houver algum
            if (panelFormulario.Controls.Count > 0)
            {
                panelFormulario.Controls[0].Dispose();
            }

            panelFormulario.Controls.Add(ucAgenda);
            ucAgenda.Dock = DockStyle.Fill;
            ucAgenda.Show();
        }





        private void btnContasPagar_Click(object sender, EventArgs e)
        {

            try
            {
                UC_ContasPagar ucContasPagar = new UC_ContasPagar();
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
            
        }

        private void btnPetsCadastrados_Click(object sender, EventArgs e)
        {
            tbxRaca ucPetsCadastrados = new tbxRaca();

            // Remove o UserControl atual, se houver algum
            if (panelFormulario.Controls.Count > 0)
            {
                panelFormulario.Controls[0].Dispose();
            }

            panelFormulario.Controls.Add(ucPetsCadastrados);
            ucPetsCadastrados.Dock = DockStyle.Fill;
            ucPetsCadastrados.Show();
        }

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            UC_Cadastrar_Pet ucCadastrarPet = new UC_Cadastrar_Pet();

            // Remove o UserControl atual, se houver algum
            if (panelFormulario.Controls.Count > 0)
            {
                panelFormulario.Controls[0].Dispose();
            }

            panelFormulario.Controls.Add(ucCadastrarPet);
            ucCadastrarPet.Dock = DockStyle.Fill;
            ucCadastrarPet.Show();
        }

        private void btnAgendaFaltas_Click(object sender, EventArgs e)
        {
            UC_AgendaFaltas ucAgendaFaltas = new UC_AgendaFaltas();

            // Remove o UserControl atual, se houver algum
            if (panelFormulario.Controls.Count > 0)
            {
                panelFormulario.Controls[0].Dispose();
            }

            panelFormulario.Controls.Add(ucAgendaFaltas);
            ucAgendaFaltas.Dock = DockStyle.Fill;
            ucAgendaFaltas.Show();
        }

        private void btnHisBanho_Click(object sender, EventArgs e)
        {
            UC_HistBanho ucHistoricoBanhos = new UC_HistBanho();

            // Remove o UserControl atual, se houver algum
            if (panelFormulario.Controls.Count > 0)
            {
                panelFormulario.Controls[0].Dispose();
            }

            panelFormulario.Controls.Add(ucHistoricoBanhos);
            ucHistoricoBanhos.Dock = DockStyle.Fill;
            ucHistoricoBanhos.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            UC_Fornecedores ucFornecedores = new UC_Fornecedores();

            // Remove o UserControl atual, se houver algum
            if (panelFormulario.Controls.Count > 0)
            {
                panelFormulario.Controls[0].Dispose();
            }

            panelFormulario.Controls.Add(ucFornecedores);
            ucFornecedores.Dock = DockStyle.Fill;
            ucFornecedores.Show();
        }
    }
}
