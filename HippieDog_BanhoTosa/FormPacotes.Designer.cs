namespace HippieDog_BanhoTosa
{
    partial class FormPacotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRacasPequenas = new System.Windows.Forms.ComboBox();
            this.cbQtBanhoPq = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLevaTrazPq = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbValorPq = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbValorMed = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLevaTrazMed = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbQtBanhoMed = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboRacasMedia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbValorGrande = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbLevaTrazGrande = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbQtBanhoGrande = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboRacasGrande = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalcularMedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PACOTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raças";
            // 
            // cboRacasPequenas
            // 
            this.cboRacasPequenas.FormattingEnabled = true;
            this.cboRacasPequenas.Location = new System.Drawing.Point(22, 126);
            this.cboRacasPequenas.Name = "cboRacasPequenas";
            this.cboRacasPequenas.Size = new System.Drawing.Size(157, 21);
            this.cboRacasPequenas.TabIndex = 2;
            // 
            // cbQtBanhoPq
            // 
            this.cbQtBanhoPq.FormattingEnabled = true;
            this.cbQtBanhoPq.Items.AddRange(new object[] {
            "Três Dias",
            "Seis Dias",
            "Nove Dias"});
            this.cbQtBanhoPq.Location = new System.Drawing.Point(185, 126);
            this.cbQtBanhoPq.Name = "cbQtBanhoPq";
            this.cbQtBanhoPq.Size = new System.Drawing.Size(157, 21);
            this.cbQtBanhoPq.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade Banhos";
            // 
            // cbLevaTrazPq
            // 
            this.cbLevaTrazPq.FormattingEnabled = true;
            this.cbLevaTrazPq.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbLevaTrazPq.Location = new System.Drawing.Point(348, 126);
            this.cbLevaTrazPq.Name = "cbLevaTrazPq";
            this.cbLevaTrazPq.Size = new System.Drawing.Size(157, 21);
            this.cbLevaTrazPq.TabIndex = 6;
            this.cbLevaTrazPq.SelectedIndexChanged += new System.EventHandler(this.levaTrazPq_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Leva e Traz";
            // 
            // cbValorPq
            // 
            this.cbValorPq.FormattingEnabled = true;
            this.cbValorPq.Location = new System.Drawing.Point(511, 126);
            this.cbValorPq.Name = "cbValorPq";
            this.cbValorPq.Size = new System.Drawing.Size(90, 21);
            this.cbValorPq.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "PACOTE RAÇAS PEQUENAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "PACOTE RAÇAS MÉDIA";
            // 
            // cbValorMed
            // 
            this.cbValorMed.FormattingEnabled = true;
            this.cbValorMed.Location = new System.Drawing.Point(511, 220);
            this.cbValorMed.Name = "cbValorMed";
            this.cbValorMed.Size = new System.Drawing.Size(90, 21);
            this.cbValorMed.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor";
            // 
            // cbLevaTrazMed
            // 
            this.cbLevaTrazMed.FormattingEnabled = true;
            this.cbLevaTrazMed.Location = new System.Drawing.Point(348, 220);
            this.cbLevaTrazMed.Name = "cbLevaTrazMed";
            this.cbLevaTrazMed.Size = new System.Drawing.Size(157, 21);
            this.cbLevaTrazMed.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Leva e Traz";
            // 
            // cbQtBanhoMed
            // 
            this.cbQtBanhoMed.FormattingEnabled = true;
            this.cbQtBanhoMed.Items.AddRange(new object[] {
            "Três Dias",
            "Seis Dias",
            "Nove Dias"});
            this.cbQtBanhoMed.Location = new System.Drawing.Point(185, 220);
            this.cbQtBanhoMed.Name = "cbQtBanhoMed";
            this.cbQtBanhoMed.Size = new System.Drawing.Size(157, 21);
            this.cbQtBanhoMed.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Quantidade Banhos";
            // 
            // cboRacasMedia
            // 
            this.cboRacasMedia.FormattingEnabled = true;
            this.cboRacasMedia.Location = new System.Drawing.Point(22, 220);
            this.cboRacasMedia.Name = "cboRacasMedia";
            this.cboRacasMedia.Size = new System.Drawing.Size(157, 21);
            this.cboRacasMedia.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Raças";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "PACOTE RAÇAS GRANDES\r\n";
            // 
            // cbValorGrande
            // 
            this.cbValorGrande.FormattingEnabled = true;
            this.cbValorGrande.Location = new System.Drawing.Point(511, 316);
            this.cbValorGrande.Name = "cbValorGrande";
            this.cbValorGrande.Size = new System.Drawing.Size(90, 21);
            this.cbValorGrande.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(508, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Valor";
            // 
            // cbLevaTrazGrande
            // 
            this.cbLevaTrazGrande.FormattingEnabled = true;
            this.cbLevaTrazGrande.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbLevaTrazGrande.Location = new System.Drawing.Point(348, 316);
            this.cbLevaTrazGrande.Name = "cbLevaTrazGrande";
            this.cbLevaTrazGrande.Size = new System.Drawing.Size(157, 21);
            this.cbLevaTrazGrande.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(345, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Leva e Traz";
            // 
            // cbQtBanhoGrande
            // 
            this.cbQtBanhoGrande.FormattingEnabled = true;
            this.cbQtBanhoGrande.Items.AddRange(new object[] {
            "Três Dias",
            "Seis Dias",
            "Nove Dias"});
            this.cbQtBanhoGrande.Location = new System.Drawing.Point(185, 316);
            this.cbQtBanhoGrande.Name = "cbQtBanhoGrande";
            this.cbQtBanhoGrande.Size = new System.Drawing.Size(157, 21);
            this.cbQtBanhoGrande.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(182, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Quantidade Banhos";
            // 
            // cboRacasGrande
            // 
            this.cboRacasGrande.FormattingEnabled = true;
            this.cboRacasGrande.Location = new System.Drawing.Point(22, 316);
            this.cboRacasGrande.Name = "cboRacasGrande";
            this.cboRacasGrande.Size = new System.Drawing.Size(157, 21);
            this.cboRacasGrande.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Raças";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(22, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 1);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(24, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 1);
            this.panel2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcularMedio
            // 
            this.btnCalcularMedio.Location = new System.Drawing.Point(605, 218);
            this.btnCalcularMedio.Name = "btnCalcularMedio";
            this.btnCalcularMedio.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularMedio.TabIndex = 31;
            this.btnCalcularMedio.Text = "Calcular";
            this.btnCalcularMedio.UseVisualStyleBackColor = true;
            this.btnCalcularMedio.Click += new System.EventHandler(this.btnCalcularMedio_Click);
            // 
            // FormPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularMedio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbValorGrande);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbLevaTrazGrande);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbQtBanhoGrande);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboRacasGrande);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbValorMed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbLevaTrazMed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbQtBanhoMed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboRacasMedia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbValorPq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLevaTrazPq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbQtBanhoPq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboRacasPequenas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPacotes";
            this.Text = "FormPacotes";
            this.Load += new System.EventHandler(this.FormPacotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRacasPequenas;
        private System.Windows.Forms.ComboBox cbQtBanhoPq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLevaTrazPq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbValorPq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbValorMed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLevaTrazMed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbQtBanhoMed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboRacasMedia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbValorGrande;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbLevaTrazGrande;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbQtBanhoGrande;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboRacasGrande;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalcularMedio;
    }
}