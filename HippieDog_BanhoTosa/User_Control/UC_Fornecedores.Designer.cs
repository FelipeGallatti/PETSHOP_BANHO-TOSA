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
            this.btnAdicionarFornecedor = new Telerik.WinControls.UI.RadButton();
            this.btnAlterar = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.rgvFornecedores = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme2 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarFornecedor
            // 
            this.btnAdicionarFornecedor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdicionarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarFornecedor.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAdicionarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarFornecedor.Location = new System.Drawing.Point(18, 384);
            this.btnAdicionarFornecedor.Name = "btnAdicionarFornecedor";
            this.btnAdicionarFornecedor.Size = new System.Drawing.Size(304, 44);
            this.btnAdicionarFornecedor.TabIndex = 7;
            this.btnAdicionarFornecedor.Text = "Adicionar novo fornecedor";
            this.btnAdicionarFornecedor.Click += new System.EventHandler(this.btnAdicionarFornecedor_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(322, 384);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(311, 44);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // rgvFornecedores
            // 
            this.rgvFornecedores.Location = new System.Drawing.Point(1, 1);
            // 
            // 
            // 
            this.rgvFornecedores.MasterTemplate.AllowAddNewRow = false;
            gridViewCheckBoxColumn1.HeaderText = "";
            gridViewCheckBoxColumn1.Name = "chk";
            this.rgvFornecedores.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1});
            this.rgvFornecedores.MasterTemplate.EnableGrouping = false;
            this.rgvFornecedores.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvFornecedores.Name = "rgvFornecedores";
            this.rgvFornecedores.Size = new System.Drawing.Size(613, 321);
            this.rgvFornecedores.TabIndex = 52;
            this.rgvFornecedores.ThemeName = "VisualStudio2012Light";
            this.rgvFornecedores.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.rgvFornecedores);
            this.panel1.Location = new System.Drawing.Point(18, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 323);
            this.panel1.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BackgroundImage = global::HippieDog_BanhoTosa.Properties.Resources.gradient__4_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radLabel1);
            this.panel4.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.panel4.Location = new System.Drawing.Point(18, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 34);
            this.panel4.TabIndex = 53;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.radLabel1.Location = new System.Drawing.Point(222, 2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(157, 30);
            this.radLabel1.TabIndex = 51;
            this.radLabel1.Text = "FORNECEDORES";
            // 
            // UC_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionarFornecedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "UC_Fornecedores";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvFornecedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnAdicionarFornecedor;
        private Telerik.WinControls.UI.RadButton btnAlterar;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGridView rgvFornecedores;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}
