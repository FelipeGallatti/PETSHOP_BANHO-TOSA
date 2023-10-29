namespace HippieDog_BanhoTosa
{
    partial class FormAgenda
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
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.lblDono = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblraca = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.rgvAgenda = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAgenda.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Location = new System.Drawing.Point(9, 77);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(615, 285);
            this.radSplitContainer1.SplitterWidth = 8;
            this.radSplitContainer1.TabIndex = 39;
            this.radSplitContainer1.TabStop = false;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lblData);
            this.radPanel1.Controls.Add(this.lblHora);
            this.radPanel1.Controls.Add(this.lblValor);
            this.radPanel1.Controls.Add(this.lblServico);
            this.radPanel1.Controls.Add(this.lblraca);
            this.radPanel1.Controls.Add(this.lblPet);
            this.radPanel1.Controls.Add(this.lblDono);
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Location = new System.Drawing.Point(9, 365);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(615, 44);
            this.radPanel1.TabIndex = 40;
            // 
            // radButton1
            // 
            this.radButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radButton1.Location = new System.Drawing.Point(505, 0);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 44);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "FALTOU";
            // 
            // lblDono
            // 
            this.lblDono.AutoSize = true;
            this.lblDono.Location = new System.Drawing.Point(20, 13);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(36, 13);
            this.lblDono.TabIndex = 1;
            this.lblDono.Text = "Dono";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(64, 13);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(23, 13);
            this.lblPet.TabIndex = 2;
            this.lblPet.Text = "Pet";
            // 
            // lblraca
            // 
            this.lblraca.AutoSize = true;
            this.lblraca.Location = new System.Drawing.Point(95, 13);
            this.lblraca.Name = "lblraca";
            this.lblraca.Size = new System.Drawing.Size(31, 13);
            this.lblraca.TabIndex = 3;
            this.lblraca.Text = "Raça";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(134, 13);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 4;
            this.lblServico.Text = "Serviço";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(264, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 13);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(224, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(32, 13);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(185, 13);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.rgvAgenda);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(615, 285);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // rgvAgenda
            // 
            this.rgvAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvAgenda.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rgvAgenda.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvAgenda.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvAgenda.Name = "rgvAgenda";
            this.rgvAgenda.Size = new System.Drawing.Size(615, 285);
            this.rgvAgenda.TabIndex = 0;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 479);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAgenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvAgenda.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblraca;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblDono;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblServico;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadGridView rgvAgenda;
    }
}