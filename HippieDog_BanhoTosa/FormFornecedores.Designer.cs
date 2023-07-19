namespace HippieDog_BanhoTosa
{
    partial class FormFornecedores
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.tbxTelefoneOpcional = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.tbxProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endreço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone (Opcional)";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(51, 85);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(199, 20);
            this.tbxNome.TabIndex = 6;
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(51, 163);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(199, 20);
            this.tbxEndereco.TabIndex = 8;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(51, 202);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(199, 20);
            this.tbxTelefone.TabIndex = 11;
            // 
            // tbxTelefoneOpcional
            // 
            this.tbxTelefoneOpcional.Location = new System.Drawing.Point(51, 241);
            this.tbxTelefoneOpcional.Name = "tbxTelefoneOpcional";
            this.tbxTelefoneOpcional.Size = new System.Drawing.Size(199, 20);
            this.tbxTelefoneOpcional.TabIndex = 10;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(51, 124);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(199, 20);
            this.tbxEmail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.label8.Location = new System.Drawing.Point(417, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Lista de Fornecedores";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(51, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 82);
            this.panel1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Excluir Fornecedor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Editar Fornecedor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cadastrar Fornecedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(265, 85);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.Size = new System.Drawing.Size(495, 319);
            this.dgvFornecedores.TabIndex = 15;
            this.dgvFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellClick);
            // 
            // tbxProduto
            // 
            this.tbxProduto.Location = new System.Drawing.Point(51, 280);
            this.tbxProduto.Name = "tbxProduto";
            this.tbxProduto.Size = new System.Drawing.Size(199, 20);
            this.tbxProduto.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Produto";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(51, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbxProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.tbxTelefoneOpcional);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.TextBox tbxTelefoneOpcional;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.TextBox tbxProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
    }
}