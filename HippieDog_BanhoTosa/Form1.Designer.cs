namespace HippieDog_BanhoTosa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgenda = new System.Windows.Forms.ToolStripButton();
            this.btnAgendaFaltas = new System.Windows.Forms.ToolStripButton();
            this.btnHisBanho = new System.Windows.Forms.ToolStripButton();
            this.btnFornecedores = new System.Windows.Forms.ToolStripButton();
            this.btnContasPagar = new System.Windows.Forms.ToolStripButton();
            this.btnPacotes = new System.Windows.Forms.ToolStripButton();
            this.btnCadastrarPet = new System.Windows.Forms.ToolStripButton();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgenda,
            this.btnAgendaFaltas,
            this.btnHisBanho,
            this.btnFornecedores,
            this.btnContasPagar,
            this.btnPacotes,
            this.btnCadastrarPet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(150, 450);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgenda
            // 
            this.btnAgenda.AutoSize = false;
            this.btnAgenda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(148, 50);
            this.btnAgenda.Text = "AGENDA";
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnAgendaFaltas
            // 
            this.btnAgendaFaltas.AutoSize = false;
            this.btnAgendaFaltas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgendaFaltas.ForeColor = System.Drawing.Color.White;
            this.btnAgendaFaltas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendaFaltas.Image")));
            this.btnAgendaFaltas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgendaFaltas.Name = "btnAgendaFaltas";
            this.btnAgendaFaltas.Size = new System.Drawing.Size(148, 50);
            this.btnAgendaFaltas.Text = "AGENDA DE FALTAS";
            this.btnAgendaFaltas.Click += new System.EventHandler(this.btnAgendaFaltas_Click);
            // 
            // btnHisBanho
            // 
            this.btnHisBanho.AutoSize = false;
            this.btnHisBanho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHisBanho.ForeColor = System.Drawing.Color.White;
            this.btnHisBanho.Image = ((System.Drawing.Image)(resources.GetObject("btnHisBanho.Image")));
            this.btnHisBanho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHisBanho.Name = "btnHisBanho";
            this.btnHisBanho.Size = new System.Drawing.Size(148, 50);
            this.btnHisBanho.Text = "HISTORICO BANHOS";
            this.btnHisBanho.Click += new System.EventHandler(this.btnHisBanho_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.AutoSize = false;
            this.btnFornecedores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFornecedores.ForeColor = System.Drawing.Color.White;
            this.btnFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.Image")));
            this.btnFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(148, 50);
            this.btnFornecedores.Text = "FORNECEDORES";
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnContasPagar
            // 
            this.btnContasPagar.AutoSize = false;
            this.btnContasPagar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContasPagar.ForeColor = System.Drawing.Color.White;
            this.btnContasPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnContasPagar.Image")));
            this.btnContasPagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContasPagar.Name = "btnContasPagar";
            this.btnContasPagar.Size = new System.Drawing.Size(148, 50);
            this.btnContasPagar.Text = "CONTAS A PAGAR";
            this.btnContasPagar.Click += new System.EventHandler(this.btnContasPagar_Click);
            // 
            // btnPacotes
            // 
            this.btnPacotes.AutoSize = false;
            this.btnPacotes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPacotes.ForeColor = System.Drawing.Color.White;
            this.btnPacotes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacotes.Image")));
            this.btnPacotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPacotes.Name = "btnPacotes";
            this.btnPacotes.Size = new System.Drawing.Size(148, 50);
            this.btnPacotes.Text = "PACOTES BANHOS";
            this.btnPacotes.Click += new System.EventHandler(this.btnPacotes_Click);
            // 
            // btnCadastrarPet
            // 
            this.btnCadastrarPet.AutoSize = false;
            this.btnCadastrarPet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarPet.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarPet.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarPet.Image")));
            this.btnCadastrarPet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarPet.Name = "btnCadastrarPet";
            this.btnCadastrarPet.Size = new System.Drawing.Size(148, 50);
            this.btnCadastrarPet.Text = "CADASTRAR PET";
            this.btnCadastrarPet.Click += new System.EventHandler(this.btnCadastrarPet_Click);
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(150, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(650, 450);
            this.radSplitContainer1.SplitterWidth = 8;
            this.radSplitContainer1.TabIndex = 1;
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(650, 450);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radSplitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgenda;
        private System.Windows.Forms.ToolStripButton btnHisBanho;
        private System.Windows.Forms.ToolStripButton btnAgendaFaltas;
        private System.Windows.Forms.ToolStripButton btnPacotes;
        private System.Windows.Forms.ToolStripButton btnFornecedores;
        private System.Windows.Forms.ToolStripButton btnContasPagar;
        private System.Windows.Forms.ToolStripButton btnCadastrarPet;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
    }
}

