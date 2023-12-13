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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnAdicionarFornecedor = new Telerik.WinControls.UI.RadButton();
            this.btnAlterar = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.rgvFornecedores = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme2 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores.MasterTemplate)).BeginInit();
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
            // btnAdicionarFornecedor
            // 
            this.btnAdicionarFornecedor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdicionarFornecedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdicionarFornecedor.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAdicionarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarFornecedor.Location = new System.Drawing.Point(311, 0);
            this.btnAdicionarFornecedor.Name = "btnAdicionarFornecedor";
            this.btnAdicionarFornecedor.Size = new System.Drawing.Size(304, 44);
            this.btnAdicionarFornecedor.TabIndex = 7;
            this.btnAdicionarFornecedor.Text = "Adicionar novo fornecedor";
            this.btnAdicionarFornecedor.Click += new System.EventHandler(this.btnAdicionarFornecedor_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Green;
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlterar.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(0, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(311, 44);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnAlterar);
            this.radPanel1.Controls.Add(this.btnAdicionarFornecedor);
            this.radPanel1.Location = new System.Drawing.Point(18, 382);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(615, 44);
            this.radPanel1.TabIndex = 46;
            // 
            // rgvFornecedores
            // 
            this.rgvFornecedores.Location = new System.Drawing.Point(18, 66);
            // 
            // 
            // 
            gridViewCheckBoxColumn1.HeaderText = "Selecionar";
            gridViewCheckBoxColumn1.Name = "chk";
            this.rgvFornecedores.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1});
            this.rgvFornecedores.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvFornecedores.Name = "rgvFornecedores";
            this.rgvFornecedores.Size = new System.Drawing.Size(615, 310);
            this.rgvFornecedores.TabIndex = 52;
            this.rgvFornecedores.ThemeName = "VisualStudio2012Light";
            this.rgvFornecedores.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellDoubleClick);
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
            this.Load += new System.EventHandler(this.UC_Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnAdicionarFornecedor;
        private Telerik.WinControls.UI.RadButton btnAlterar;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGridView rgvFornecedores;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme2;
    }
}
