namespace HippieDog_BanhoTosa
{
    partial class FormContasPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContasPagar));
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblHistoricoBanhos = new System.Windows.Forms.Label();
            this.dgvContasPagar = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnContasPagas = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasPagar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(43, 161);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataVencimento.TabIndex = 44;
            this.lblDataVencimento.Text = "Data de Vencimento";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(46, 220);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(119, 20);
            this.tbxValor.TabIndex = 40;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(43, 204);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 39;
            this.lblValor.Text = "Valor";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(46, 88);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(241, 20);
            this.tbxDescricao.TabIndex = 38;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(43, 72);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 37;
            this.lblDescricao.Text = "Descrição";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Água",
            "Luz",
            "Eletricidade",
            "Fornecedor",
            "Outros"});
            this.cbCategoria.Location = new System.Drawing.Point(46, 132);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(241, 21);
            this.cbCategoria.TabIndex = 36;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(43, 116);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 35;
            this.lblCategoria.Text = "Categoria";
            // 
            // dtVencimento
            // 
            this.dtVencimento.Location = new System.Drawing.Point(46, 176);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(241, 20);
            this.dtVencimento.TabIndex = 45;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pendente",
            "Paga",
            "Atrasada"});
            this.cbStatus.Location = new System.Drawing.Point(168, 219);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(119, 21);
            this.cbStatus.TabIndex = 46;
            // 
            // lblHistoricoBanhos
            // 
            this.lblHistoricoBanhos.AutoSize = true;
            this.lblHistoricoBanhos.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.lblHistoricoBanhos.Location = new System.Drawing.Point(420, 58);
            this.lblHistoricoBanhos.Name = "lblHistoricoBanhos";
            this.lblHistoricoBanhos.Size = new System.Drawing.Size(138, 28);
            this.lblHistoricoBanhos.TabIndex = 48;
            this.lblHistoricoBanhos.Text = "Contas a Pagar";
            // 
            // dgvContasPagar
            // 
            this.dgvContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasPagar.Location = new System.Drawing.Point(311, 88);
            this.dgvContasPagar.Name = "dgvContasPagar";
            this.dgvContasPagar.Size = new System.Drawing.Size(362, 262);
            this.dgvContasPagar.TabIndex = 47;
            this.dgvContasPagar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContasPagar_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnContasPagas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnContasPagas
            // 
            this.btnContasPagas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnContasPagas.Image = ((System.Drawing.Image)(resources.GetObject("btnContasPagas.Image")));
            this.btnContasPagas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContasPagas.Name = "btnContasPagas";
            this.btnContasPagas.Size = new System.Drawing.Size(82, 22);
            this.btnContasPagas.Text = "Contas Pagas";
            this.btnContasPagas.ToolTipText = "toolStripButn1";
            this.btnContasPagas.Click += new System.EventHandler(this.btnContasPagas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 50;
            this.button1.Text = "Adicionar Conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(168, 268);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(119, 47);
            this.btnPagar.TabIndex = 51;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(165, 204);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 52;
            this.lblStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "label1";
            // 
            // FormContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblHistoricoBanhos);
            this.Controls.Add(this.dgvContasPagar);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dtVencimento);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Name = "FormContasPagar";
            this.Text = "FormContasPagar";
            this.Load += new System.EventHandler(this.FormContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasPagar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblHistoricoBanhos;
        private System.Windows.Forms.DataGridView dgvContasPagar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnContasPagas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
    }
}