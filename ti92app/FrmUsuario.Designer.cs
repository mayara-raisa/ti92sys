namespace ti92app
{
    partial class FrmUsuario
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "BUSCA POR NOME";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(332, 48);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(256, 20);
            this.txtBusca.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.chkAtivo);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.cmbNivel);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(45, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 232);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "SENHA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "EMAIL";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(72, 106);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Location = new System.Drawing.Point(28, 159);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAtivo.Size = new System.Drawing.Size(58, 17);
            this.chkAtivo.TabIndex = 11;
            this.chkAtivo.Text = "ATIVO";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(169, 197);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 20);
            this.txtNome.TabIndex = 3;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(72, 132);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 10;
            this.cmbNivel.SelectedIndexChanged += new System.EventHandler(this.cmbNivel_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(87, 197);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NÍVEL";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(6, 197);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(71, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "NOME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(332, 74);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(256, 238);
            this.lstLista.TabIndex = 15;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 427);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstLista);
            this.Name = "FrmUsuario";
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstLista;
    }
}