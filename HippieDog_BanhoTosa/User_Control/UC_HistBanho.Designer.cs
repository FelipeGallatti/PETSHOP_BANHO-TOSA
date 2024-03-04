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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblValorRMensal = new System.Windows.Forms.Label();
            this.lblRendaM = new System.Windows.Forms.Label();
            this.rgvHistBanhos = new Telerik.WinControls.UI.RadGridView();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radMes = new Telerik.WinControls.UI.RadRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radSemana = new Telerik.WinControls.UI.RadRadioButton();
            this.lblRendaS = new System.Windows.Forms.Label();
            this.lblValorRSemanal = new System.Windows.Forms.Label();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.lblQtMes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQtSemana = new System.Windows.Forms.Label();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radPanel7 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel8 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel9 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistBanhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistBanhos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel7)).BeginInit();
            this.radPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel8)).BeginInit();
            this.radPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel9)).BeginInit();
            this.radPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lblValorRMensal);
            this.radPanel1.Controls.Add(this.lblRendaM);
            this.radPanel1.Location = new System.Drawing.Point(483, 1);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(131, 44);
            this.radPanel1.TabIndex = 54;
            // 
            // lblValorRMensal
            // 
            this.lblValorRMensal.AutoSize = true;
            this.lblValorRMensal.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblValorRMensal.Location = new System.Drawing.Point(46, 23);
            this.lblValorRMensal.Name = "lblValorRMensal";
            this.lblValorRMensal.Size = new System.Drawing.Size(16, 19);
            this.lblValorRMensal.TabIndex = 10;
            this.lblValorRMensal.Text = "0";
            // 
            // lblRendaM
            // 
            this.lblRendaM.AutoSize = true;
            this.lblRendaM.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblRendaM.Location = new System.Drawing.Point(23, 4);
            this.lblRendaM.Name = "lblRendaM";
            this.lblRendaM.Size = new System.Drawing.Size(87, 19);
            this.lblRendaM.TabIndex = 9;
            this.lblRendaM.Text = "Renda Mensal";
            // 
            // rgvHistBanhos
            // 
            this.rgvHistBanhos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvHistBanhos.Location = new System.Drawing.Point(1, 1);
            // 
            // 
            // 
            this.rgvHistBanhos.MasterTemplate.AllowAddNewRow = false;
            this.rgvHistBanhos.MasterTemplate.AllowDeleteRow = false;
            this.rgvHistBanhos.MasterTemplate.AllowEditRow = false;
            this.rgvHistBanhos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvHistBanhos.MasterTemplate.EnableGrouping = false;
            this.rgvHistBanhos.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgvHistBanhos.Name = "rgvHistBanhos";
            this.rgvHistBanhos.Size = new System.Drawing.Size(613, 268);
            this.rgvHistBanhos.TabIndex = 53;
            this.rgvHistBanhos.ThemeName = "VisualStudio2012Light";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.radMes);
            this.radPanel4.Controls.Add(this.label7);
            this.radPanel4.Location = new System.Drawing.Point(1, 1);
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
            // lblRendaS
            // 
            this.lblRendaS.AutoSize = true;
            this.lblRendaS.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblRendaS.Location = new System.Drawing.Point(23, 4);
            this.lblRendaS.Name = "lblRendaS";
            this.lblRendaS.Size = new System.Drawing.Size(96, 19);
            this.lblRendaS.TabIndex = 11;
            this.lblRendaS.Text = "Renda Semanal";
            // 
            // lblValorRSemanal
            // 
            this.lblValorRSemanal.AutoSize = true;
            this.lblValorRSemanal.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblValorRSemanal.Location = new System.Drawing.Point(47, 22);
            this.lblValorRSemanal.Name = "lblValorRSemanal";
            this.lblValorRSemanal.Size = new System.Drawing.Size(16, 19);
            this.lblValorRSemanal.TabIndex = 10;
            this.lblValorRSemanal.Text = "0";
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.lblQtMes);
            this.radPanel5.Controls.Add(this.label3);
            this.radPanel5.Location = new System.Drawing.Point(351, 1);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(131, 44);
            this.radPanel5.TabIndex = 58;
            // 
            // lblQtMes
            // 
            this.lblQtMes.AutoSize = true;
            this.lblQtMes.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblQtMes.Location = new System.Drawing.Point(52, 23);
            this.lblQtMes.Name = "lblQtMes";
            this.lblQtMes.Size = new System.Drawing.Size(16, 19);
            this.lblQtMes.TabIndex = 10;
            this.lblQtMes.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade Banhos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade Banhos";
            // 
            // lblQtSemana
            // 
            this.lblQtSemana.AutoSize = true;
            this.lblQtSemana.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.lblQtSemana.Location = new System.Drawing.Point(52, 22);
            this.lblQtSemana.Name = "lblQtSemana";
            this.lblQtSemana.Size = new System.Drawing.Size(16, 19);
            this.lblQtSemana.TabIndex = 10;
            this.lblQtSemana.Text = "0";
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
            this.panel4.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.rgvHistBanhos);
            this.panel1.Location = new System.Drawing.Point(18, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 270);
            this.panel1.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.radPanel4);
            this.panel2.Controls.Add(this.radPanel1);
            this.panel2.Controls.Add(this.radPanel5);
            this.panel2.Location = new System.Drawing.Point(18, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 46);
            this.panel2.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.radPanel7);
            this.panel3.Controls.Add(this.radPanel8);
            this.panel3.Controls.Add(this.radPanel9);
            this.panel3.Location = new System.Drawing.Point(18, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 46);
            this.panel3.TabIndex = 63;
            // 
            // radPanel7
            // 
            this.radPanel7.Controls.Add(this.label1);
            this.radPanel7.Controls.Add(this.radSemana);
            this.radPanel7.Location = new System.Drawing.Point(1, 1);
            this.radPanel7.Name = "radPanel7";
            this.radPanel7.Size = new System.Drawing.Size(349, 44);
            this.radPanel7.TabIndex = 55;
            // 
            // radPanel8
            // 
            this.radPanel8.Controls.Add(this.lblRendaS);
            this.radPanel8.Controls.Add(this.lblValorRSemanal);
            this.radPanel8.Location = new System.Drawing.Point(483, 1);
            this.radPanel8.Name = "radPanel8";
            this.radPanel8.Size = new System.Drawing.Size(131, 44);
            this.radPanel8.TabIndex = 54;
            // 
            // radPanel9
            // 
            this.radPanel9.Controls.Add(this.label5);
            this.radPanel9.Controls.Add(this.lblQtSemana);
            this.radPanel9.Location = new System.Drawing.Point(351, 1);
            this.radPanel9.Name = "radPanel9";
            this.radPanel9.Size = new System.Drawing.Size(131, 44);
            this.radPanel9.TabIndex = 58;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.radLabel1.Location = new System.Drawing.Point(193, 1);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(225, 30);
            this.radLabel1.TabIndex = 52;
            this.radLabel1.Text = "HISTÓRICO DE BANHOS";
            // 
            // UC_HistBanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "UC_HistBanho";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_HistBanho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistBanhos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistBanhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            this.radPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            this.radPanel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel7)).EndInit();
            this.radPanel7.ResumeLayout(false);
            this.radPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel8)).EndInit();
            this.radPanel8.ResumeLayout(false);
            this.radPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel9)).EndInit();
            this.radPanel9.ResumeLayout(false);
            this.radPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblValorRMensal;
        private System.Windows.Forms.Label lblRendaM;
        private Telerik.WinControls.UI.RadGridView rgvHistBanhos;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private System.Windows.Forms.Label lblValorRSemanal;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private System.Windows.Forms.Label lblQtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQtSemana;
        private System.Windows.Forms.Label lblRendaS;
        private Telerik.WinControls.UI.RadRadioButton radMes;
        private Telerik.WinControls.UI.RadRadioButton radSemana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadPanel radPanel7;
        private Telerik.WinControls.UI.RadPanel radPanel8;
        private Telerik.WinControls.UI.RadPanel radPanel9;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
