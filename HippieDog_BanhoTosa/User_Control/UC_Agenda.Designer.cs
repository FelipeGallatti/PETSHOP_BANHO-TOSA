namespace HippieDog_BanhoTosa.User_Control
{
    partial class UC_Agenda
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnBanhoRealizado = new Telerik.WinControls.UI.RadButton();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblraca = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblDono = new System.Windows.Forms.Label();
            this.btnFaltou = new Telerik.WinControls.UI.RadButton();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnAdicionar = new Telerik.WinControls.UI.RadButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemover = new Telerik.WinControls.UI.RadButton();
            this.rgvAgenda = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBanhoRealizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaltou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAgenda.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnBanhoRealizado);
            this.radPanel1.Controls.Add(this.lblHora);
            this.radPanel1.Controls.Add(this.lblraca);
            this.radPanel1.Controls.Add(this.lblPet);
            this.radPanel1.Controls.Add(this.lblDono);
            this.radPanel1.Controls.Add(this.btnFaltou);
            this.radPanel1.Location = new System.Drawing.Point(18, 326);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(615, 44);
            this.radPanel1.TabIndex = 42;
            // 
            // btnBanhoRealizado
            // 
            this.btnBanhoRealizado.BackColor = System.Drawing.Color.Green;
            this.btnBanhoRealizado.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBanhoRealizado.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnBanhoRealizado.ForeColor = System.Drawing.Color.White;
            this.btnBanhoRealizado.Location = new System.Drawing.Point(395, 0);
            this.btnBanhoRealizado.Name = "btnBanhoRealizado";
            this.btnBanhoRealizado.Size = new System.Drawing.Size(110, 44);
            this.btnBanhoRealizado.TabIndex = 7;
            this.btnBanhoRealizado.Text = "Banho Realizado";
            this.btnBanhoRealizado.Click += new System.EventHandler(this.btnBanhoRealizado_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblHora.Location = new System.Drawing.Point(309, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 19);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora";
            // 
            // lblraca
            // 
            this.lblraca.AutoSize = true;
            this.lblraca.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblraca.Location = new System.Drawing.Point(175, 13);
            this.lblraca.Name = "lblraca";
            this.lblraca.Size = new System.Drawing.Size(37, 19);
            this.lblraca.TabIndex = 3;
            this.lblraca.Text = "Raça";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblPet.Location = new System.Drawing.Point(102, 13);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(27, 19);
            this.lblPet.TabIndex = 2;
            this.lblPet.Text = "Pet";
            // 
            // lblDono
            // 
            this.lblDono.AutoSize = true;
            this.lblDono.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblDono.Location = new System.Drawing.Point(20, 13);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(38, 19);
            this.lblDono.TabIndex = 1;
            this.lblDono.Text = "Dono";
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
            this.btnFaltou.Text = "Faltou";
            this.btnFaltou.Click += new System.EventHandler(this.btnFaltou_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(224, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 26);
            this.lblTitulo.TabIndex = 43;
            this.lblTitulo.Text = "Agenda de banhos";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.btnAdicionar);
            this.radPanel2.Controls.Add(this.label7);
            this.radPanel2.Controls.Add(this.btnRemover);
            this.radPanel2.Location = new System.Drawing.Point(18, 376);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(615, 44);
            this.radPanel2.TabIndex = 44;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Green;
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdicionar.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(395, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 44);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label7.Location = new System.Drawing.Point(57, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Deseja Adicionar um novo banho?";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemover.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(505, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(110, 44);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "Remover";
            // 
            // rgvAgenda
            // 
            this.rgvAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvAgenda.Location = new System.Drawing.Point(18, 54);
            // 
            // 
            // 
            this.rgvAgenda.MasterTemplate.AllowAddNewRow = false;
            this.rgvAgenda.MasterTemplate.AllowDeleteRow = false;
            this.rgvAgenda.MasterTemplate.AllowEditRow = false;
            this.rgvAgenda.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvAgenda.MasterTemplate.EnableGrouping = false;
            this.rgvAgenda.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvAgenda.Name = "rgvAgenda";
            this.rgvAgenda.Size = new System.Drawing.Size(615, 259);
            this.rgvAgenda.TabIndex = 45;
            this.rgvAgenda.ThemeName = "VisualStudio2012Light";
            this.rgvAgenda.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgvAgenda_CellFormatting);
            this.rgvAgenda.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvAgenda_CellClick);
            // 
            // UC_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgvAgenda);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.radPanel1);
            this.Name = "UC_Agenda";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBanhoRealizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaltou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAgenda.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblraca;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblDono;
        private Telerik.WinControls.UI.RadButton btnFaltou;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton btnAdicionar;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadButton btnRemover;
        private Telerik.WinControls.UI.RadGridView rgvAgenda;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadButton btnBanhoRealizado;
    }
}
