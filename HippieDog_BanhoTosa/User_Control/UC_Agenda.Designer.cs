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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnBanhoRealizado = new Telerik.WinControls.UI.RadButton();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblraca = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblDono = new System.Windows.Forms.Label();
            this.btnFaltou = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnAdicionar = new Telerik.WinControls.UI.RadButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemover = new Telerik.WinControls.UI.RadButton();
            this.rgvContasPagas = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBanhoRealizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaltou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagas.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
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
            this.radPanel1.Location = new System.Drawing.Point(1, 1);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(613, 44);
            this.radPanel1.TabIndex = 42;
            // 
            // btnBanhoRealizado
            // 
            this.btnBanhoRealizado.BackColor = System.Drawing.Color.Green;
            this.btnBanhoRealizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanhoRealizado.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBanhoRealizado.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnBanhoRealizado.ForeColor = System.Drawing.Color.White;
            this.btnBanhoRealizado.Location = new System.Drawing.Point(393, 0);
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
            this.lblHora.Visible = false;
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
            this.lblraca.Visible = false;
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
            this.lblPet.Visible = false;
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
            this.lblDono.Visible = false;
            // 
            // btnFaltou
            // 
            this.btnFaltou.BackColor = System.Drawing.Color.DarkRed;
            this.btnFaltou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaltou.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFaltou.ForeColor = System.Drawing.Color.White;
            this.btnFaltou.Location = new System.Drawing.Point(503, 0);
            this.btnFaltou.Name = "btnFaltou";
            this.btnFaltou.Size = new System.Drawing.Size(110, 44);
            this.btnFaltou.TabIndex = 0;
            this.btnFaltou.Text = "Faltou";
            this.btnFaltou.Click += new System.EventHandler(this.btnFaltou_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.btnAdicionar);
            this.radPanel2.Controls.Add(this.label7);
            this.radPanel2.Controls.Add(this.btnRemover);
            this.radPanel2.Location = new System.Drawing.Point(1, 1);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(613, 44);
            this.radPanel2.TabIndex = 44;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Green;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdicionar.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(393, 0);
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
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemover.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(503, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(110, 44);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // rgvContasPagas
            // 
            this.rgvContasPagas.Location = new System.Drawing.Point(1, 1);
            // 
            // 
            // 
            this.rgvContasPagas.MasterTemplate.AllowAddNewRow = false;
            this.rgvContasPagas.MasterTemplate.AllowDeleteRow = false;
            this.rgvContasPagas.MasterTemplate.AllowEditRow = false;
            this.rgvContasPagas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvContasPagas.MasterTemplate.EnableGrouping = false;
            this.rgvContasPagas.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvContasPagas.Name = "rgvContasPagas";
            this.rgvContasPagas.Size = new System.Drawing.Size(613, 268);
            this.rgvContasPagas.TabIndex = 45;
            this.rgvContasPagas.ThemeName = "VisualStudio2012Light";
            this.rgvContasPagas.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgvAgenda_CellFormatting);
            this.rgvContasPagas.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvAgenda_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.rgvContasPagas);
            this.panel1.Location = new System.Drawing.Point(18, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 272);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.radPanel1);
            this.panel2.Location = new System.Drawing.Point(18, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 46);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.radPanel2);
            this.panel3.Location = new System.Drawing.Point(18, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 46);
            this.panel3.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BackgroundImage = global::HippieDog_BanhoTosa.Properties.Resources.gradient__4_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radLabel1);
            this.panel4.Location = new System.Drawing.Point(18, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 34);
            this.panel4.TabIndex = 44;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.radLabel1.Location = new System.Drawing.Point(199, 1);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(201, 30);
            this.radLabel1.TabIndex = 52;
            this.radLabel1.Text = "AGENDA DE BANHOS";
            // 
            // UC_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Agenda";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBanhoRealizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaltou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblraca;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblDono;
        private Telerik.WinControls.UI.RadButton btnFaltou;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton btnAdicionar;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadButton btnRemover;
        private Telerik.WinControls.UI.RadGridView rgvContasPagas;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadButton btnBanhoRealizado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
