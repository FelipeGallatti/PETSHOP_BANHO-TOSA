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
            this.btnAgendarBanho = new System.Windows.Forms.ToolStripButton();
            this.btnFinanceiro = new System.Windows.Forms.ToolStripButton();
            this.btnFornecedores = new System.Windows.Forms.ToolStripButton();
            this.btnContasPagar = new System.Windows.Forms.ToolStripButton();
            this.btnPacotes = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgenda,
            this.btnAgendarBanho,
            this.btnFinanceiro,
            this.btnFornecedores,
            this.btnContasPagar,
            this.btnPacotes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(150, 450);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(148, 20);
            this.btnAgenda.Text = "AGENDA";
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnAgendarBanho
            // 
            this.btnAgendarBanho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgendarBanho.ForeColor = System.Drawing.Color.White;
            this.btnAgendarBanho.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendarBanho.Image")));
            this.btnAgendarBanho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgendarBanho.Name = "btnAgendarBanho";
            this.btnAgendarBanho.Size = new System.Drawing.Size(148, 20);
            this.btnAgendarBanho.Text = "AGENDAR BANHO";
            this.btnAgendarBanho.Click += new System.EventHandler(this.btnAgendarBanho_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinanceiro.ForeColor = System.Drawing.Color.White;
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(148, 20);
            this.btnFinanceiro.Text = "FINANCEIRO";
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFornecedores.ForeColor = System.Drawing.Color.White;
            this.btnFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.Image")));
            this.btnFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(148, 20);
            this.btnFornecedores.Text = "FORNECEDORES";
            // 
            // btnContasPagar
            // 
            this.btnContasPagar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContasPagar.ForeColor = System.Drawing.Color.White;
            this.btnContasPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnContasPagar.Image")));
            this.btnContasPagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContasPagar.Name = "btnContasPagar";
            this.btnContasPagar.Size = new System.Drawing.Size(148, 20);
            this.btnContasPagar.Text = "CONTAS A PAGAR";
            this.btnContasPagar.Click += new System.EventHandler(this.btnContasPagar_Click);
            // 
            // btnPacotes
            // 
            this.btnPacotes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPacotes.ForeColor = System.Drawing.Color.White;
            this.btnPacotes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacotes.Image")));
            this.btnPacotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPacotes.Name = "btnPacotes";
            this.btnPacotes.Size = new System.Drawing.Size(148, 20);
            this.btnPacotes.Text = "PACOTES BANHOS";
            this.btnPacotes.Click += new System.EventHandler(this.btnPacotes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgenda;
        private System.Windows.Forms.ToolStripButton btnFinanceiro;
        private System.Windows.Forms.ToolStripButton btnAgendarBanho;
        private System.Windows.Forms.ToolStripButton btnPacotes;
        private System.Windows.Forms.ToolStripButton btnFornecedores;
        private System.Windows.Forms.ToolStripButton btnContasPagar;
    }
}

