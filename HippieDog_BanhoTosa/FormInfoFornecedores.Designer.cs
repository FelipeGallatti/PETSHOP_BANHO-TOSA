namespace HippieDog_BanhoTosa
{
    partial class FormInfoFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoFornecedores));
            this.lblTelefoneFornecedor = new Telerik.WinControls.UI.RadLabel();
            this.lblEmailFornecedor = new Telerik.WinControls.UI.RadLabel();
            this.lblNomeFornecedor = new Telerik.WinControls.UI.RadLabel();
            this.lblTelefoneOpcional = new Telerik.WinControls.UI.RadLabel();
            this.lblProduto = new Telerik.WinControls.UI.RadLabel();
            this.lblEndereco = new Telerik.WinControls.UI.RadLabel();
            this.btnRemover = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefoneFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmailFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNomeFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefoneOpcional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTelefoneFornecedor
            // 
            this.lblTelefoneFornecedor.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneFornecedor.Location = new System.Drawing.Point(318, 64);
            this.lblTelefoneFornecedor.Name = "lblTelefoneFornecedor";
            this.lblTelefoneFornecedor.Size = new System.Drawing.Size(55, 18);
            this.lblTelefoneFornecedor.TabIndex = 1;
            this.lblTelefoneFornecedor.Text = "Telefone";
            // 
            // lblEmailFornecedor
            // 
            this.lblEmailFornecedor.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFornecedor.Location = new System.Drawing.Point(29, 88);
            this.lblEmailFornecedor.Name = "lblEmailFornecedor";
            this.lblEmailFornecedor.Size = new System.Drawing.Size(37, 18);
            this.lblEmailFornecedor.TabIndex = 2;
            this.lblEmailFornecedor.Text = "Email";
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFornecedor.Location = new System.Drawing.Point(29, 64);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(43, 18);
            this.lblNomeFornecedor.TabIndex = 3;
            this.lblNomeFornecedor.Text = "Nome ";
            // 
            // lblTelefoneOpcional
            // 
            this.lblTelefoneOpcional.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneOpcional.Location = new System.Drawing.Point(318, 88);
            this.lblTelefoneOpcional.Name = "lblTelefoneOpcional";
            this.lblTelefoneOpcional.Size = new System.Drawing.Size(107, 18);
            this.lblTelefoneOpcional.TabIndex = 4;
            this.lblTelefoneOpcional.Text = "Telefone Opcional";
            // 
            // lblProduto
            // 
            this.lblProduto.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.lblProduto.Location = new System.Drawing.Point(26, 16);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(85, 30);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "Produto";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(29, 112);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(58, 18);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(12, 171);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(469, 44);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Controls.Add(this.lblNomeFornecedor);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.lblEmailFornecedor);
            this.panel1.Controls.Add(this.lblTelefoneOpcional);
            this.panel1.Controls.Add(this.lblTelefoneFornecedor);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 148);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 151);
            this.panel2.TabIndex = 9;
            // 
            // FormInfoFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(497, 225);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRemover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfoFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informação do fornecedor";
            this.Load += new System.EventHandler(this.FormInfoFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefoneFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmailFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNomeFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefoneOpcional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel lblTelefoneOpcional;
        private Telerik.WinControls.UI.RadLabel lblTelefoneFornecedor;
        private Telerik.WinControls.UI.RadLabel lblEmailFornecedor;
        private Telerik.WinControls.UI.RadLabel lblNomeFornecedor;
        private Telerik.WinControls.UI.RadLabel lblProduto;
        private Telerik.WinControls.UI.RadLabel lblEndereco;
        private Telerik.WinControls.UI.RadButton btnRemover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}