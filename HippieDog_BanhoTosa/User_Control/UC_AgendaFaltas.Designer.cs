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
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.lblQtMes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.lblPet = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblValorFalta = new System.Windows.Forms.Label();
            this.lblRendaM = new System.Windows.Forms.Label();
            this.rgvHistFaltas = new Telerik.WinControls.UI.RadGridView();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistFaltas.MasterTemplate)).BeginInit();
            this.SuspendLayout();
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
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.lblQtMes);
            this.radPanel5.Controls.Add(this.label3);
            this.radPanel5.Location = new System.Drawing.Point(373, 389);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(127, 44);
            this.radPanel5.TabIndex = 62;
            // 
            // lblQtMes
            // 
            this.lblQtMes.AutoSize = true;
            this.lblQtMes.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblQtMes.Location = new System.Drawing.Point(50, 23);
            this.lblQtMes.Name = "lblQtMes";
            this.lblQtMes.Size = new System.Drawing.Size(16, 19);
            this.lblQtMes.TabIndex = 10;
            this.lblQtMes.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade Faltas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.lblValor);
            this.radPanel4.Controls.Add(this.lblRaca);
            this.radPanel4.Controls.Add(this.lblPet);
            this.radPanel4.Location = new System.Drawing.Point(18, 389);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(349, 44);
            this.radPanel4.TabIndex = 61;
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPet.Location = new System.Drawing.Point(16, 13);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(30, 18);
            this.lblPet.TabIndex = 0;
            this.lblPet.Text = "Pet";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lblValorFalta);
            this.radPanel1.Controls.Add(this.lblRendaM);
            this.radPanel1.Location = new System.Drawing.Point(506, 389);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(127, 44);
            this.radPanel1.TabIndex = 60;
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
            // lblRendaM
            // 
            this.lblRendaM.AutoSize = true;
            this.lblRendaM.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblRendaM.Location = new System.Drawing.Point(15, 4);
            this.lblRendaM.Name = "lblRendaM";
            this.lblRendaM.Size = new System.Drawing.Size(97, 19);
            this.lblRendaM.TabIndex = 9;
            this.lblRendaM.Text = "Valor das Faltas";
            this.lblRendaM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rgvHistFaltas
            // 
            this.rgvHistFaltas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvHistFaltas.Location = new System.Drawing.Point(18, 72);
            // 
            // 
            // 
            this.rgvHistFaltas.MasterTemplate.AllowAddNewRow = false;
            this.rgvHistFaltas.MasterTemplate.AllowDeleteRow = false;
            this.rgvHistFaltas.MasterTemplate.AllowEditRow = false;
            this.rgvHistFaltas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvHistFaltas.MasterTemplate.EnableGrouping = false;
            this.rgvHistFaltas.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvHistFaltas.Name = "rgvHistFaltas";
            this.rgvHistFaltas.Size = new System.Drawing.Size(615, 311);
            this.rgvHistFaltas.TabIndex = 59;
            this.rgvHistFaltas.ThemeName = "VisualStudio2012Light";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRaca.Location = new System.Drawing.Point(152, 13);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(41, 18);
            this.lblRaca.TabIndex = 1;
            this.lblRaca.Text = "Raça";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblValor.Location = new System.Drawing.Point(265, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(44, 18);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // UC_AgendaFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel5);
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.rgvHistFaltas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_AgendaFaltas";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_AgendaFaltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            this.radPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            this.radPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistFaltas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistFaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private System.Windows.Forms.Label lblQtMes;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private System.Windows.Forms.Label lblPet;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblValorFalta;
        private System.Windows.Forms.Label lblRendaM;
        private Telerik.WinControls.UI.RadGridView rgvHistFaltas;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblValor;
    }
}
