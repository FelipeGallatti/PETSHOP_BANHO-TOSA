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
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.tbxDetalhes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDono = new System.Windows.Forms.TextBox();
            this.tbxPet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(44, 308);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(552, 146);
            this.dgvAgenda.TabIndex = 0;
            this.dgvAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellDoubleClick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(395, 261);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 34;
            this.lblValor.Text = "Valor";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(432, 258);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(164, 20);
            this.tbxValor.TabIndex = 33;
            // 
            // dtHora
            // 
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(292, 72);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(63, 20);
            this.dtHora.TabIndex = 32;
            this.dtHora.Value = new System.DateTime(2023, 7, 6, 18, 9, 0, 0);
            // 
            // tbxDetalhes
            // 
            this.tbxDetalhes.Location = new System.Drawing.Point(391, 54);
            this.tbxDetalhes.Name = "tbxDetalhes";
            this.tbxDetalhes.Size = new System.Drawing.Size(205, 198);
            this.tbxDetalhes.TabIndex = 31;
            this.tbxDetalhes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Detalhes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Dono | Cliente";
            // 
            // tbxDono
            // 
            this.tbxDono.Location = new System.Drawing.Point(44, 258);
            this.tbxDono.Name = "tbxDono";
            this.tbxDono.Size = new System.Drawing.Size(150, 20);
            this.tbxDono.TabIndex = 28;
            // 
            // tbxPet
            // 
            this.tbxPet.Location = new System.Drawing.Point(205, 197);
            this.tbxPet.Name = "tbxPet";
            this.tbxPet.Size = new System.Drawing.Size(150, 20);
            this.tbxPet.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pet";
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(44, 197);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(150, 20);
            this.tbxTelefone.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefone";
            // 
            // cbServico
            // 
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Location = new System.Drawing.Point(44, 130);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(311, 21);
            this.cbServico.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Serviço";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(44, 72);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(213, 20);
            this.dtData.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 21);
            this.button2.TabIndex = 36;
            this.button2.Text = "FALTOU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(43, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "0";
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 479);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.tbxDetalhes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxDono);
            this.Controls.Add(this.tbxPet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbServico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAgenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.RichTextBox tbxDetalhes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDono;
        private System.Windows.Forms.TextBox tbxPet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblID;
    }
}