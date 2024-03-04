namespace HippieDog_BanhoTosa.User_Control
{
    partial class UC_Cadastrar_Pet
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tbxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMedio = new System.Windows.Forms.RadioButton();
            this.chkPequena = new System.Windows.Forms.RadioButton();
            this.chkGrande = new System.Windows.Forms.RadioButton();
            this.dtCadastro = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDono = new System.Windows.Forms.TextBox();
            this.tbxPet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnAdicionar = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnAddFoto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.tbxTelefone);
            this.radPanel1.Controls.Add(this.label7);
            this.radPanel1.Controls.Add(this.panel1);
            this.radPanel1.Controls.Add(this.cbRaca);
            this.radPanel1.Controls.Add(this.radPanel3);
            this.radPanel1.Controls.Add(this.dtCadastro);
            this.radPanel1.Controls.Add(this.label8);
            this.radPanel1.Controls.Add(this.radRichTextEditor1);
            this.radPanel1.Controls.Add(this.label4);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Controls.Add(this.tbxEndereco);
            this.radPanel1.Controls.Add(this.label6);
            this.radPanel1.Controls.Add(this.tbxDono);
            this.radPanel1.Controls.Add(this.tbxPet);
            this.radPanel1.Controls.Add(this.label5);
            this.radPanel1.Controls.Add(this.label3);
            this.radPanel1.Location = new System.Drawing.Point(1, 1);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(613, 322);
            this.radPanel1.TabIndex = 0;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(399, 85);
            this.tbxTelefone.Mask = "(00) 00000-0000";
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(181, 22);
            this.tbxTelefone.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F);
            this.label7.Location = new System.Drawing.Point(396, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 65;
            this.label7.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnAddFoto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(37, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 172);
            this.panel1.TabIndex = 0;
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(227, 130);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(150, 21);
            this.cbRaca.TabIndex = 4;
            this.cbRaca.SelectedIndexChanged += new System.EventHandler(this.cbRaca_SelectedIndexChanged);
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.radPanel3.Controls.Add(this.label2);
            this.radPanel3.Controls.Add(this.chkMedio);
            this.radPanel3.Controls.Add(this.chkPequena);
            this.radPanel3.Controls.Add(this.chkGrande);
            this.radPanel3.Location = new System.Drawing.Point(227, 159);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(353, 36);
            this.radPanel3.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "Porte";
            // 
            // chkMedio
            // 
            this.chkMedio.AutoSize = true;
            this.chkMedio.Font = new System.Drawing.Font("Roboto", 9F);
            this.chkMedio.Location = new System.Drawing.Point(178, 9);
            this.chkMedio.Name = "chkMedio";
            this.chkMedio.Size = new System.Drawing.Size(58, 18);
            this.chkMedio.TabIndex = 39;
            this.chkMedio.TabStop = true;
            this.chkMedio.Text = "Médio";
            this.chkMedio.UseVisualStyleBackColor = true;
            // 
            // chkPequena
            // 
            this.chkPequena.AutoSize = true;
            this.chkPequena.Font = new System.Drawing.Font("Roboto", 9F);
            this.chkPequena.Location = new System.Drawing.Point(84, 8);
            this.chkPequena.Name = "chkPequena";
            this.chkPequena.Size = new System.Drawing.Size(73, 18);
            this.chkPequena.TabIndex = 38;
            this.chkPequena.TabStop = true;
            this.chkPequena.Text = "Pequena";
            this.chkPequena.UseVisualStyleBackColor = true;
            // 
            // chkGrande
            // 
            this.chkGrande.AutoSize = true;
            this.chkGrande.Font = new System.Drawing.Font("Roboto", 9F);
            this.chkGrande.Location = new System.Drawing.Point(265, 9);
            this.chkGrande.Name = "chkGrande";
            this.chkGrande.Size = new System.Drawing.Size(64, 18);
            this.chkGrande.TabIndex = 40;
            this.chkGrande.TabStop = true;
            this.chkGrande.Text = "Grande";
            this.chkGrande.UseVisualStyleBackColor = true;
            // 
            // dtCadastro
            // 
            this.dtCadastro.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtCadastro.Location = new System.Drawing.Point(399, 127);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(181, 24);
            this.dtCadastro.TabIndex = 5;
            this.dtCadastro.TabStop = false;
            this.dtCadastro.Text = "quinta-feira, 14 de dezembro de 2023";
            this.dtCadastro.Value = new System.DateTime(2023, 12, 14, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9F);
            this.label8.Location = new System.Drawing.Point(35, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 14);
            this.label8.TabIndex = 62;
            this.label8.Text = "Observações:";
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.radRichTextEditor1.Location = new System.Drawing.Point(38, 230);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.radRichTextEditor1.SelectionStroke = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.radRichTextEditor1.Size = new System.Drawing.Size(542, 69);
            this.radRichTextEditor1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F);
            this.label4.Location = new System.Drawing.Point(396, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 59;
            this.label4.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F);
            this.label1.Location = new System.Drawing.Point(224, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 58;
            this.label1.Text = "Raça";
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(399, 43);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(181, 22);
            this.tbxEndereco.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F);
            this.label6.Location = new System.Drawing.Point(224, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 55;
            this.label6.Text = "Dono | Cliente";
            // 
            // tbxDono
            // 
            this.tbxDono.Location = new System.Drawing.Point(227, 43);
            this.tbxDono.Name = "tbxDono";
            this.tbxDono.Size = new System.Drawing.Size(150, 22);
            this.tbxDono.TabIndex = 0;
            // 
            // tbxPet
            // 
            this.tbxPet.Location = new System.Drawing.Point(227, 85);
            this.tbxPet.Name = "tbxPet";
            this.tbxPet.Size = new System.Drawing.Size(150, 22);
            this.tbxPet.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F);
            this.label5.Location = new System.Drawing.Point(224, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 14);
            this.label5.TabIndex = 52;
            this.label5.Text = "Pet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F);
            this.label3.Location = new System.Drawing.Point(396, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 51;
            this.label3.Text = "Endereço";
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
            this.panel4.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.radPanel1);
            this.panel2.Location = new System.Drawing.Point(18, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 325);
            this.panel2.TabIndex = 50;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.btnAdicionar);
            this.radPanel2.Location = new System.Drawing.Point(20, 386);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(613, 44);
            this.radPanel2.TabIndex = 48;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Green;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdicionar.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(613, 44);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.radLabel1.Location = new System.Drawing.Point(227, 1);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(162, 30);
            this.radLabel1.TabIndex = 52;
            this.radLabel1.Text = "CADASTRAR PET";
            // 
            // btnAddFoto
            // 
            this.btnAddFoto.BackColor = System.Drawing.Color.White;
            this.btnAddFoto.BackgroundImage = global::HippieDog_BanhoTosa.Properties.Resources.adicionar_botao;
            this.btnAddFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFoto.Location = new System.Drawing.Point(125, 125);
            this.btnAddFoto.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddFoto.Name = "btnAddFoto";
            this.btnAddFoto.Size = new System.Drawing.Size(35, 35);
            this.btnAddFoto.TabIndex = 68;
            this.btnAddFoto.TabStop = false;
            this.btnAddFoto.Click += new System.EventHandler(this.btnAddFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::HippieDog_BanhoTosa.Properties.Resources.dogface;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Cadastrar_Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "UC_Cadastrar_Pet";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UC_Cadastrar_Pet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton chkMedio;
        private System.Windows.Forms.RadioButton chkPequena;
        private System.Windows.Forms.RadioButton chkGrande;
        private Telerik.WinControls.UI.RadDateTimePicker dtCadastro;
        private System.Windows.Forms.Label label8;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDono;
        private System.Windows.Forms.TextBox tbxPet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnAddFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton btnAdicionar;
        private System.Windows.Forms.MaskedTextBox tbxTelefone;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
