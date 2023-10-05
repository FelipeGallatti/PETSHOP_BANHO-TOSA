namespace HippieDog_BanhoTosa
{
    partial class FormAgendar_Banho
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPet = new System.Windows.Forms.TextBox();
            this.tbxDono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDetalhes = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(66, 64);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(213, 20);
            this.dtData.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serviço";
            // 
            // cbServico
            // 
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Location = new System.Drawing.Point(66, 140);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(311, 21);
            this.cbServico.TabIndex = 5;
            this.cbServico.SelectedIndexChanged += new System.EventHandler(this.cbServico_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(66, 207);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(150, 20);
            this.tbxTelefone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pet";
            // 
            // tbxPet
            // 
            this.tbxPet.Location = new System.Drawing.Point(227, 207);
            this.tbxPet.Name = "tbxPet";
            this.tbxPet.Size = new System.Drawing.Size(150, 20);
            this.tbxPet.TabIndex = 9;
            // 
            // tbxDono
            // 
            this.tbxDono.Location = new System.Drawing.Point(66, 268);
            this.tbxDono.Name = "tbxDono";
            this.tbxDono.Size = new System.Drawing.Size(311, 20);
            this.tbxDono.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dono | Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Detalhes";
            // 
            // tbxDetalhes
            // 
            this.tbxDetalhes.Location = new System.Drawing.Point(66, 332);
            this.tbxDetalhes.Name = "tbxDetalhes";
            this.tbxDetalhes.Size = new System.Drawing.Size(311, 74);
            this.tbxDetalhes.TabIndex = 13;
            this.tbxDetalhes.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(389, 140);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(389, 48);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(227, 80);
            this.btnAgendar.TabIndex = 15;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // dtHora
            // 
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(285, 64);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(63, 20);
            this.dtHora.TabIndex = 16;
            this.dtHora.Value = new System.DateTime(2023, 7, 6, 18, 9, 0, 0);
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(116, 431);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(100, 20);
            this.tbxValor.TabIndex = 17;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(63, 434);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "Valor";
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(227, 241);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(150, 21);
            this.cbRaca.TabIndex = 19;
            this.cbRaca.SelectedIndexChanged += new System.EventHandler(this.cbRaca_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Raça";
            // 
            // FormAgendar_Banho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 504);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.monthCalendar1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgendar_Banho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AGENDAR_BANHO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAgendar_Banho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPet;
        private System.Windows.Forms.TextBox tbxDono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbxDetalhes;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label label8;
    }
}