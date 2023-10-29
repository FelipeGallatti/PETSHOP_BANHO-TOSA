namespace HippieDog_BanhoTosa.User_Control
{
    partial class UC_AgendaFaltas
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
            this.rgvHistFaltas = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnRemoverFalta = new Telerik.WinControls.UI.RadButton();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorFalta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistFaltas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoverFalta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgvHistFaltas
            // 
            this.rgvHistFaltas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvHistFaltas.Location = new System.Drawing.Point(18, 44);
            // 
            // 
            // 
            this.rgvHistFaltas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvHistFaltas.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvHistFaltas.Name = "rgvHistFaltas";
            this.rgvHistFaltas.Size = new System.Drawing.Size(615, 333);
            this.rgvHistFaltas.TabIndex = 49;
            this.rgvHistFaltas.ThemeName = "VisualStudio2012Light";
            this.rgvHistFaltas.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvHistFaltas_CellClick);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.lblHora);
            this.radPanel2.Controls.Add(this.lblValor);
            this.radPanel2.Controls.Add(this.lblRaca);
            this.radPanel2.Controls.Add(this.lblPet);
            this.radPanel2.Controls.Add(this.btnRemoverFalta);
            this.radPanel2.Location = new System.Drawing.Point(151, 383);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(482, 44);
            this.radPanel2.TabIndex = 48;
            // 
            // btnRemoverFalta
            // 
            this.btnRemoverFalta.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoverFalta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoverFalta.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnRemoverFalta.ForeColor = System.Drawing.Color.White;
            this.btnRemoverFalta.Location = new System.Drawing.Point(372, 0);
            this.btnRemoverFalta.Name = "btnRemoverFalta";
            this.btnRemoverFalta.Size = new System.Drawing.Size(110, 44);
            this.btnRemoverFalta.TabIndex = 0;
            this.btnRemoverFalta.Text = "Remover Falta";
            this.btnRemoverFalta.Click += new System.EventHandler(this.btnRemoverFalta_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(224, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 26);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "Historico de Faltas";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblHora.Location = new System.Drawing.Point(229, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 19);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblValor.Location = new System.Drawing.Point(323, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(38, 19);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblRaca.Location = new System.Drawing.Point(95, 13);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(37, 19);
            this.lblRaca.TabIndex = 9;
            this.lblRaca.Text = "Raça";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblPet.Location = new System.Drawing.Point(16, 13);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(27, 19);
            this.lblPet.TabIndex = 8;
            this.lblPet.Text = "Pet";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lblValorFalta);
            this.radPanel1.Controls.Add(this.lblValorTotal);
            this.radPanel1.Location = new System.Drawing.Point(18, 383);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(127, 44);
            this.radPanel1.TabIndex = 50;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblValorTotal.Location = new System.Drawing.Point(17, 5);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(93, 19);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "Valor em faltas";
            // 
            // lblValorFalta
            // 
            this.lblValorFalta.AutoSize = true;
            this.lblValorFalta.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblValorFalta.Location = new System.Drawing.Point(50, 23);
            this.lblValorFalta.Name = "lblValorFalta";
            this.lblValorFalta.Size = new System.Drawing.Size(16, 19);
            this.lblValorFalta.TabIndex = 10;
            this.lblValorFalta.Text = "0";
            // 
            // UC_AgendaFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.rgvHistFaltas);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_AgendaFaltas";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_AgendaFaltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistFaltas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistFaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoverFalta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvHistFaltas;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblPet;
        private Telerik.WinControls.UI.RadButton btnRemoverFalta;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblValorFalta;
        private System.Windows.Forms.Label lblValorTotal;
    }
}
