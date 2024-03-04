namespace HippieDog_BanhoTosa
{
    partial class FormContasPagas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContasPagas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rgvContasPagas = new Telerik.WinControls.UI.RadGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagas.MasterTemplate)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.rgvContasPagas);
            this.panel1.Location = new System.Drawing.Point(8, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 347);
            this.panel1.TabIndex = 53;
            // 
            // rgvContasPagas
            // 
            this.rgvContasPagas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvContasPagas.Location = new System.Drawing.Point(1, 1);
            // 
            // 
            // 
            this.rgvContasPagas.MasterTemplate.AllowAddNewRow = false;
            this.rgvContasPagas.MasterTemplate.AllowDeleteRow = false;
            this.rgvContasPagas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvContasPagas.MasterTemplate.EnableGrouping = false;
            this.rgvContasPagas.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvContasPagas.Name = "rgvContasPagas";
            this.rgvContasPagas.Size = new System.Drawing.Size(613, 345);
            this.rgvContasPagas.TabIndex = 49;
            this.rgvContasPagas.ThemeName = "VisualStudio2012Light";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BackgroundImage = global::HippieDog_BanhoTosa.Properties.Resources.gradient__4_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radLabel1);
            this.panel4.Location = new System.Drawing.Point(7, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 34);
            this.panel4.TabIndex = 52;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.radLabel1.Location = new System.Drawing.Point(228, 1);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(158, 30);
            this.radLabel1.TabIndex = 52;
            this.radLabel1.Text = "CONTAS PAGAS";
            // 
            // FormContasPagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContasPagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Pagas";
            this.Load += new System.EventHandler(this.FormContasPagas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvContasPagas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGridView rgvContasPagas;
        private System.Windows.Forms.Panel panel4;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}