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
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvContasPagar = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnAdicionar = new Telerik.WinControls.UI.RadButton();
            this.btnRemover = new Telerik.WinControls.UI.RadButton();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagar.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvContasPagar
            // 
            this.rgvContasPagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvContasPagar.Location = new System.Drawing.Point(18, 61);
            // 
            // 
            // 
            this.rgvContasPagar.MasterTemplate.AllowAddNewRow = false;
            this.rgvContasPagar.MasterTemplate.AllowDeleteRow = false;
            this.rgvContasPagar.MasterTemplate.AllowEditRow = false;
            this.rgvContasPagar.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewImageColumn1.FieldName = "<?xml version=\"1.0\" encoding=\"utf-16\"?>";
            gridViewImageColumn1.HeaderText = "column1";
            gridViewImageColumn1.Name = "colPagar";
            gridViewImageColumn1.Width = 596;
            this.rgvContasPagar.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewImageColumn1});
            this.rgvContasPagar.MasterTemplate.EnableGrouping = false;
            this.rgvContasPagar.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvContasPagar.Name = "rgvContasPagar";
            this.rgvContasPagar.Size = new System.Drawing.Size(615, 304);
            this.rgvContasPagar.TabIndex = 49;
            this.rgvContasPagar.ThemeName = "VisualStudio2012Light";
            this.rgvContasPagar.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvContasPagar_CommandCellClick);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.btnAdicionar);
            this.radPanel2.Controls.Add(this.btnRemover);
            this.radPanel2.Location = new System.Drawing.Point(18, 383);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(615, 44);
            this.radPanel2.TabIndex = 48;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Green;
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionar.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(308, 44);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemover.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(308, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(307, 44);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "Remover";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(255, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 26);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "Contas a Pagar";
            // 
            // UC_ContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgvContasPagar);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_ContasPagar";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_ContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagar.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvContasPagar;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton btnAdicionar;
        private Telerik.WinControls.UI.RadButton btnRemover;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
    }
}
