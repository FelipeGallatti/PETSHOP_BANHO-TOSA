namespace HippieDog_BanhoTosa
{
    partial class FormAlterarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarFornecedor));
            this.lblIdFornecedor = new System.Windows.Forms.Label();
            this.btnAlterar = new Telerik.WinControls.UI.RadButton();
            this.btnSair = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxTelefoneOpcional = new System.Windows.Forms.MaskedTextBox();
            this.tbxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbxNome = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProduto = new Telerik.WinControls.UI.RadTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.tbxEmail = new Telerik.WinControls.UI.RadTextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefoneOpc = new System.Windows.Forms.Label();
            this.tbxEndereco = new Telerik.WinControls.UI.RadTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxEndereco)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdFornecedor
            // 
            this.lblIdFornecedor.AutoSize = true;
            this.lblIdFornecedor.Location = new System.Drawing.Point(39, 164);
            this.lblIdFornecedor.Name = "lblIdFornecedor";
            this.lblIdFornecedor.Size = new System.Drawing.Size(16, 13);
            this.lblIdFornecedor.TabIndex = 45;
            this.lblIdFornecedor.Text = "Id";
            this.lblIdFornecedor.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Green;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Location = new System.Drawing.Point(12, 319);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(150, 44);
            this.btnAlterar.TabIndex = 47;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(171, 319);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 44);
            this.btnSair.TabIndex = 48;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbxTelefoneOpcional);
            this.panel1.Controls.Add(this.tbxTelefone);
            this.panel1.Controls.Add(this.tbxNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxProduto);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Controls.Add(this.tbxEmail);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.lblTelefoneOpc);
            this.panel1.Controls.Add(this.tbxEndereco);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 254);
            this.panel1.TabIndex = 49;
            // 
            // tbxTelefoneOpcional
            // 
            this.tbxTelefoneOpcional.Location = new System.Drawing.Point(113, 167);
            this.tbxTelefoneOpcional.Mask = "(00) 00000-0000";
            this.tbxTelefoneOpcional.Name = "tbxTelefoneOpcional";
            this.tbxTelefoneOpcional.Size = new System.Drawing.Size(90, 20);
            this.tbxTelefoneOpcional.TabIndex = 4;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(10, 167);
            this.tbxTelefone.Mask = "(00) 00000-0000";
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(90, 20);
            this.tbxTelefone.TabIndex = 3;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(10, 31);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(289, 24);
            this.tbxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F);
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome";
            // 
            // tbxProduto
            // 
            this.tbxProduto.Location = new System.Drawing.Point(10, 210);
            this.tbxProduto.Name = "tbxProduto";
            this.tbxProduto.Size = new System.Drawing.Size(289, 24);
            this.tbxProduto.TabIndex = 40;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblEmail.Location = new System.Drawing.Point(10, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 14);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblProduto.Location = new System.Drawing.Point(10, 195);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(51, 14);
            this.lblProduto.TabIndex = 39;
            this.lblProduto.Text = "Produto";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(10, 75);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(289, 24);
            this.tbxEmail.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblEndereco.Location = new System.Drawing.Point(10, 104);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(57, 14);
            this.lblEndereco.TabIndex = 33;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblTelefoneOpc
            // 
            this.lblTelefoneOpc.AutoSize = true;
            this.lblTelefoneOpc.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblTelefoneOpc.Location = new System.Drawing.Point(110, 150);
            this.lblTelefoneOpc.Name = "lblTelefoneOpc";
            this.lblTelefoneOpc.Size = new System.Drawing.Size(55, 14);
            this.lblTelefoneOpc.TabIndex = 37;
            this.lblTelefoneOpc.Text = "Opcional";
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(10, 119);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(289, 24);
            this.tbxEndereco.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblTelefone.Location = new System.Drawing.Point(10, 148);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 14);
            this.lblTelefone.TabIndex = 35;
            this.lblTelefone.Text = "Telefone";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 259);
            this.panel2.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BackgroundImage = global::HippieDog_BanhoTosa.Properties.Resources.gradient__4_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radLabel1);
            this.panel4.Location = new System.Drawing.Point(12, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 34);
            this.panel4.TabIndex = 76;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.radLabel1.Location = new System.Drawing.Point(42, 1);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(221, 30);
            this.radLabel1.TabIndex = 52;
            this.radLabel1.Text = "ALTERAR FORNECEDOR";
            // 
            // FormAlterarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(332, 376);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblIdFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Fornecedor";
            this.Load += new System.EventHandler(this.FormAlterarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxEndereco)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdFornecedor;
        private Telerik.WinControls.UI.RadButton btnAlterar;
        private Telerik.WinControls.UI.RadButton btnSair;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadTextBox tbxNome;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox tbxProduto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProduto;
        private Telerik.WinControls.UI.RadTextBox tbxEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefoneOpc;
        private Telerik.WinControls.UI.RadTextBox tbxEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox tbxTelefoneOpcional;
        private System.Windows.Forms.MaskedTextBox tbxTelefone;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}