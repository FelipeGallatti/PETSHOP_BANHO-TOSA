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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnAgendarBanho = new System.Windows.Forms.ToolStripButton();
            this.btnFinanceiro = new System.Windows.Forms.ToolStripButton();
            this.btnContasPagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnAgendarBanho,
            this.btnFinanceiro,
            this.toolStripButton2,
            this.btnContasPagar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(150, 450);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(148, 20);
            this.toolStripButton1.Text = "AGENDA";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.btnAgendarBanho.Click += new System.EventHandler(this.toolStripButton3_Click);
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
            this.btnFinanceiro.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.btnContasPagar.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(148, 20);
            this.toolStripButton2.Text = "FORNECEDORES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnFinanceiro;
        private System.Windows.Forms.ToolStripButton btnAgendarBanho;
        private System.Windows.Forms.ToolStripButton btnContasPagar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

