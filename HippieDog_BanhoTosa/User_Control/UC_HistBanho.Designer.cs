namespace HippieDog_BanhoTosa.User_Control
{
    partial class UC_HistBanho
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
            this.lblValorRMensal = new System.Windows.Forms.Label();
            this.lblRendaM = new System.Windows.Forms.Label();
            this.rgvHistBanhos = new Telerik.WinControls.UI.RadGridView();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radMes = new Telerik.WinControls.UI.RadRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.radSemana = new Telerik.WinControls.UI.RadRadioButton();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.lblRendaS = new System.Windows.Forms.Label();
            this.lblValorRSemanal = new System.Windows.Forms.Label();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.lblQtMes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radPanel6 = new Telerik.WinControls.UI.RadPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQtSemana = new System.Windows.Forms.Label();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistBanhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistBanhos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel6)).BeginInit();
            this.radPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lblValorRMensal);
            this.radPanel1.Controls.Add(this.lblRendaM);
            this.radPanel1.Location = new System.Drawing.Point(506, 339);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(127, 44);
            this.radPanel1.TabIndex = 54;
            // 
            // lblValorRMensal
            // 
            this.lblValorRMensal.AutoSize = true;
            this.lblValorRMensal.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblValorRMensal.Location = new System.Drawing.Point(50, 23);
            this.lblValorRMensal.Name = "lblValorRMensal";
            this.lblValorRMensal.Size = new System.Drawing.Size(16, 19);
            this.lblValorRMensal.TabIndex = 10;
            this.lblValorRMensal.Text = "0";
            // 
            // lblRendaM
            // 
            this.lblRendaM.AutoSize = true;
            this.lblRendaM.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblRendaM.Location = new System.Drawing.Point(17, 4);
            this.lblRendaM.Name = "lblRendaM";
            this.lblRendaM.Size = new System.Drawing.Size(87, 19);
            this.lblRendaM.TabIndex = 9;
            this.lblRendaM.Text = "Renda Mensal";
            // 
            // rgvHistBanhos
            // 
            this.rgvHistBanhos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvHistBanhos.Location = new System.Drawing.Point(18, 77);
            // 
            // 
            // 
            this.rgvHistBanhos.MasterTemplate.AllowAddNewRow = false;
            this.rgvHistBanhos.MasterTemplate.AllowDeleteRow = false;
            this.rgvHistBanhos.MasterTemplate.AllowEditRow = false;
            this.rgvHistBanhos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvHistBanhos.MasterTemplate.EnableGrouping = false;
            this.rgvHistBanhos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvHistBanhos.Name = "rgvHistBanhos";
            this.rgvHistBanhos.Size = new System.Drawing.Size(615, 256);
            this.rgvHistBanhos.TabIndex = 53;
            this.rgvHistBanhos.ThemeName = "VisualStudio2012Light";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(224, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 26);
            this.lblTitulo.TabIndex = 51;
            this.lblTitulo.Text = "Historico de Banhos";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.radMes);
            this.radPanel4.Controls.Add(this.label7);
            this.radPanel4.Location = new System.Drawing.Point(18, 339);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(349, 44);
            this.radPanel4.TabIndex = 55;
            // 
            // radMes
            // 
            this.radMes.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMes.Location = new System.Drawing.Point(19, 13);
            this.radMes.Name = "radMes";
            this.radMes.Size = new System.Drawing.Size(16, 18);
            this.radMes.TabIndex = 9;
            this.radMes.TabStop = false;
            this.radMes.CheckStateChanging += new Telerik.WinControls.UI.CheckStateChangingEventHandler(this.radMes_CheckStateChanging);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.Location = new System.Drawing.Point(41, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = " Banhos Realizados durante o mês";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.label1);
            this.radPanel2.Controls.Add(this.radSemana);
            this.radPanel2.Location = new System.Drawing.Point(18, 389);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(349, 44);
            this.radPanel2.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = " Banhos Realizados durante a semana";
            // 
            // radSemana
            // 
            this.radSemana.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSemana.Location = new System.Drawing.Point(19, 13);
            this.radSemana.Name = "radSemana";
            this.radSemana.Size = new System.Drawing.Size(16, 18);
            this.radSemana.TabIndex = 10;
            this.radSemana.CheckStateChanging += new Telerik.WinControls.UI.CheckStateChangingEventHandler(this.radSemana_CheckStateChanging);
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.lblRendaS);
            this.radPanel3.Controls.Add(this.lblValorRSemanal);
            this.radPanel3.Location = new System.Drawing.Point(506, 389);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(127, 44);
            this.radPanel3.TabIndex = 56;
            // 
            // lblRendaS
            // 
            this.lblRendaS.AutoSize = true;
            this.lblRendaS.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblRendaS.Location = new System.Drawing.Point(17, 5);
            this.lblRendaS.Name = "lblRendaS";
            this.lblRendaS.Size = new System.Drawing.Size(96, 19);
            this.lblRendaS.TabIndex = 11;
            this.lblRendaS.Text = "Renda Semanal";
            // 
            // lblValorRSemanal
            // 
            this.lblValorRSemanal.AutoSize = true;
            this.lblValorRSemanal.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblValorRSemanal.Location = new System.Drawing.Point(50, 23);
            this.lblValorRSemanal.Name = "lblValorRSemanal";
            this.lblValorRSemanal.Size = new System.Drawing.Size(16, 19);
            this.lblValorRSemanal.TabIndex = 10;
            this.lblValorRSemanal.Text = "0";
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.lblQtMes);
            this.radPanel5.Controls.Add(this.label3);
            this.radPanel5.Location = new System.Drawing.Point(373, 339);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(127, 44);
            this.radPanel5.TabIndex = 58;
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
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade Banhos";
            // 
            // radPanel6
            // 
            this.radPanel6.Controls.Add(this.label5);
            this.radPanel6.Controls.Add(this.lblQtSemana);
            this.radPanel6.Location = new System.Drawing.Point(373, 389);
            this.radPanel6.Name = "radPanel6";
            this.radPanel6.Size = new System.Drawing.Size(127, 44);
            this.radPanel6.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade Banhos";
            // 
            // lblQtSemana
            // 
            this.lblQtSemana.AutoSize = true;
            this.lblQtSemana.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblQtSemana.Location = new System.Drawing.Point(50, 23);
            this.lblQtSemana.Name = "lblQtSemana";
            this.lblQtSemana.Size = new System.Drawing.Size(16, 19);
            this.lblQtSemana.TabIndex = 10;
            this.lblQtSemana.Text = "0";
            // 
            // UC_HistBanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel6);
            this.Controls.Add(this.radPanel5);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.rgvHistBanhos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_HistBanho";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_HistBanho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistBanhos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistBanhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            this.radPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            this.radPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel6)).EndInit();
            this.radPanel6.ResumeLayout(false);
            this.radPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblValorRMensal;
        private System.Windows.Forms.Label lblRendaM;
        private Telerik.WinControls.UI.RadGridView rgvHistBanhos;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private System.Windows.Forms.Label lblValorRSemanal;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private System.Windows.Forms.Label lblQtMes;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadPanel radPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQtSemana;
        private System.Windows.Forms.Label lblRendaS;
        private Telerik.WinControls.UI.RadRadioButton radMes;
        private Telerik.WinControls.UI.RadRadioButton radSemana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}
