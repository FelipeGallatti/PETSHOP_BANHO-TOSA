namespace HippieDog_BanhoTosa.User_Control
{
    partial class UC_ContasPagar
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvContasPagar = new Telerik.WinControls.UI.RadGridView();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContasPagas = new Telerik.WinControls.UI.RadButton();
            this.btnRemoverConta = new Telerik.WinControls.UI.RadButton();
            this.btnAdicionarConta = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagar.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnContasPagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoverConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarConta)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvContasPagar
            // 
            this.rgvContasPagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvContasPagar.Location = new System.Drawing.Point(1, 1);
            // 
            // 
            // 
            this.rgvContasPagar.MasterTemplate.AllowAddNewRow = false;
            this.rgvContasPagar.MasterTemplate.AllowDeleteRow = false;
            this.rgvContasPagar.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvContasPagar.MasterTemplate.EnableGrouping = false;
            this.rgvContasPagar.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvContasPagar.Name = "rgvContasPagar";
            this.rgvContasPagar.Size = new System.Drawing.Size(613, 316);
            this.rgvContasPagar.TabIndex = 49;
            this.rgvContasPagar.ThemeName = "VisualStudio2012Light";
            this.rgvContasPagar.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvContasPagar_CommandCellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(215, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 30);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "CONTAS A PAGAR";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BackgroundImage = global::HippieDog_BanhoTosa.Properties.Resources.gradient__4_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Location = new System.Drawing.Point(18, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 34);
            this.panel4.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.rgvContasPagar);
            this.panel1.Location = new System.Drawing.Point(19, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 318);
            this.panel1.TabIndex = 51;
            // 
            // btnContasPagas
            // 
            this.btnContasPagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnContasPagas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContasPagas.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnContasPagas.ForeColor = System.Drawing.Color.White;
            this.btnContasPagas.Location = new System.Drawing.Point(224, 383);
            this.btnContasPagas.Name = "btnContasPagas";
            this.btnContasPagas.Size = new System.Drawing.Size(205, 46);
            this.btnContasPagas.TabIndex = 2;
            this.btnContasPagas.Text = "Contas Pagas";
            this.btnContasPagas.Click += new System.EventHandler(this.btnContasPagas_Click);
            // 
            // btnRemoverConta
            // 
            this.btnRemoverConta.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoverConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverConta.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnRemoverConta.ForeColor = System.Drawing.Color.White;
            this.btnRemoverConta.Location = new System.Drawing.Point(429, 383);
            this.btnRemoverConta.Name = "btnRemoverConta";
            this.btnRemoverConta.Size = new System.Drawing.Size(205, 46);
            this.btnRemoverConta.TabIndex = 1;
            this.btnRemoverConta.Text = "Remover Conta";
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.BackColor = System.Drawing.Color.Green;
            this.btnAdicionarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarConta.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAdicionarConta.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarConta.Location = new System.Drawing.Point(19, 383);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(205, 46);
            this.btnAdicionarConta.TabIndex = 3;
            this.btnAdicionarConta.Text = "Adicionar Conta";
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // UC_ContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnContasPagas);
            this.Controls.Add(this.btnAdicionarConta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoverConta);
            this.Controls.Add(this.panel4);
            this.Name = "UC_ContasPagar";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_ContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagar.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnContasPagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoverConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvContasPagar;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton btnContasPagas;
        private Telerik.WinControls.UI.RadButton btnRemoverConta;
        private Telerik.WinControls.UI.RadButton btnAdicionarConta;
    }
}
