namespace HippieDog_BanhoTosa.User_Control
{
    partial class UC_Fornecedores
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rgvFornecedores = new Telerik.WinControls.UI.RadGridView();
            this.btnFaltou = new Telerik.WinControls.UI.RadButton();
            this.btnBanhoRealizado = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaltou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBanhoRealizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(257, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(138, 26);
            this.radLabel1.TabIndex = 51;
            this.radLabel1.Text = "Fornecedores";
            // 
            // rgvFornecedores
            // 
            this.rgvFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvFornecedores.Location = new System.Drawing.Point(18, 54);
            // 
            // 
            // 
            this.rgvFornecedores.MasterTemplate.AllowAddNewRow = false;
            this.rgvFornecedores.MasterTemplate.AllowDeleteRow = false;
            this.rgvFornecedores.MasterTemplate.AllowEditRow = false;
            this.rgvFornecedores.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvFornecedores.MasterTemplate.EnableGrouping = false;
            this.rgvFornecedores.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvFornecedores.Name = "rgvFornecedores";
            this.rgvFornecedores.Size = new System.Drawing.Size(615, 322);
            this.rgvFornecedores.TabIndex = 47;
            this.rgvFornecedores.ThemeName = "VisualStudio2012Light";
            this.rgvFornecedores.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvFornecedores_CellDoubleClick);
            // 
            // btnFaltou
            // 
            this.btnFaltou.BackColor = System.Drawing.Color.DarkRed;
            this.btnFaltou.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFaltou.ForeColor = System.Drawing.Color.White;
            this.btnFaltou.Location = new System.Drawing.Point(505, 0);
            this.btnFaltou.Name = "btnFaltou";
            this.btnFaltou.Size = new System.Drawing.Size(110, 44);
            this.btnFaltou.TabIndex = 0;
            this.btnFaltou.Text = "Remover";
            // 
            // btnBanhoRealizado
            // 
            this.btnBanhoRealizado.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBanhoRealizado.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBanhoRealizado.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnBanhoRealizado.ForeColor = System.Drawing.Color.White;
            this.btnBanhoRealizado.Location = new System.Drawing.Point(108, 0);
            this.btnBanhoRealizado.Name = "btnBanhoRealizado";
            this.btnBanhoRealizado.Size = new System.Drawing.Size(397, 44);
            this.btnBanhoRealizado.TabIndex = 7;
            this.btnBanhoRealizado.Text = "Adicionar novo fornecedor";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Green;
            this.radButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radButton1.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.radButton1.ForeColor = System.Drawing.Color.White;
            this.radButton1.Location = new System.Drawing.Point(-2, 0);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 44);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Alterar";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Controls.Add(this.btnBanhoRealizado);
            this.radPanel1.Controls.Add(this.btnFaltou);
            this.radPanel1.Location = new System.Drawing.Point(18, 382);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(615, 44);
            this.radPanel1.TabIndex = 46;
            // 
            // UC_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgvFornecedores);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radPanel1);
            this.Name = "UC_Fornecedores";
            this.Size = new System.Drawing.Size(650, 450);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaltou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBanhoRealizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView rgvFornecedores;
        private Telerik.WinControls.UI.RadButton btnFaltou;
        private Telerik.WinControls.UI.RadButton btnBanhoRealizado;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
    }
}
