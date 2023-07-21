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
            this.tbxPet = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHistoricoBanhos = new System.Windows.Forms.Label();
            this.dgvHistBanhos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistBanhos)).BeginInit();
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
            // tbxPet
            // 
            this.tbxPet.Location = new System.Drawing.Point(46, 220);
            this.tbxPet.Name = "tbxPet";
            this.tbxPet.Size = new System.Drawing.Size(119, 20);
            this.tbxPet.TabIndex = 40;
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
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(46, 88);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(241, 20);
            this.tbxTelefone.TabIndex = 38;
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
            // cbServico
            // 
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Location = new System.Drawing.Point(46, 132);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(241, 21);
            this.cbServico.TabIndex = 36;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pendente",
            "Atrasada"});
            this.comboBox1.Location = new System.Drawing.Point(168, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 46;
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
            // dgvHistBanhos
            // 
            this.dgvHistBanhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistBanhos.Location = new System.Drawing.Point(311, 88);
            this.dgvHistBanhos.Name = "dgvHistBanhos";
            this.dgvHistBanhos.Size = new System.Drawing.Size(362, 262);
            this.dgvHistBanhos.TabIndex = 47;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton1.Text = "Contas Pagas";
            this.toolStripButton1.ToolTipText = "toolStripButn1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 50;
            this.button1.Text = "Adicionar Conta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 47);
            this.button2.TabIndex = 51;
            this.button2.Text = "Pagar";
            this.button2.UseVisualStyleBackColor = true;
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
            // FormContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblHistoricoBanhos);
            this.Controls.Add(this.dgvHistBanhos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.tbxPet);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cbServico);
            this.Controls.Add(this.lblCategoria);
            this.Name = "FormContasPagar";
            this.Text = "FormContasPagar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistBanhos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.TextBox tbxPet;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHistoricoBanhos;
        private System.Windows.Forms.DataGridView dgvHistBanhos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblStatus;
    }
}