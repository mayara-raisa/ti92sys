﻿namespace ti92app
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.canceladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.operaçãoToolStripMenuItem,
            this.movimentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // operaçãoToolStripMenuItem
            // 
            this.operaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.orçamentosToolStripMenuItem});
            this.operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            this.operaçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.operaçãoToolStripMenuItem.Text = "&Operação";
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.pagamentosToolStripMenuItem});
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Image = global::ti92app.Properties.Resources._6986_64x64;
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagamentosToolStripMenuItem.Text = "&Pagamentos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "sistema";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::ti92app.Properties.Resources.Users;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clientesToolStripMenuItem.Text = "C&lientes";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "&Consulta";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.listarToolStripMenuItem,
            this.gerenciarToolStripMenuItem});
            this.produtosToolStripMenuItem.Image = global::ti92app.Properties.Resources.Estoque1;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.novoToolStripMenuItem1.Text = "&Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.listarToolStripMenuItem.Text = "&Listar";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gerenciarToolStripMenuItem.Text = "&Gerenciar";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem2,
            this.consultaToolStripMenuItem1,
            this.configuraçõesToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Image = global::ti92app.Properties.Resources.user1;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usuáriosToolStripMenuItem.Text = "&Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem2
            // 
            this.novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            this.novoToolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
            this.novoToolStripMenuItem2.Text = "&Novo";
            this.novoToolStripMenuItem2.Click += new System.EventHandler(this.novoToolStripMenuItem2_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.consultaToolStripMenuItem1.Text = "&Consulta";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "&Configurações";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.perfilToolStripMenuItem.Text = "&Perfil";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem3,
            this.listarToolStripMenuItem1,
            this.canceladosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Image = global::ti92app.Properties.Resources._1911_64x64;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidosToolStripMenuItem.Text = "&Pedidos";
            // 
            // novoToolStripMenuItem3
            // 
            this.novoToolStripMenuItem3.Name = "novoToolStripMenuItem3";
            this.novoToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem3.Text = "&Novo";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "&Listar";
            // 
            // canceladosToolStripMenuItem
            // 
            this.canceladosToolStripMenuItem.Name = "canceladosToolStripMenuItem";
            this.canceladosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.canceladosToolStripMenuItem.Text = "&Cancelados";
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.orçamentosToolStripMenuItem.Checked = true;
            this.orçamentosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.orçamentosToolStripMenuItem.Image = global::ti92app.Properties.Resources.Edit_Alt1;
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orçamentosToolStripMenuItem.Text = "&Orçamentos";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Image = global::ti92app.Properties.Resources.FinPedido;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "&Vendas";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Image = global::ti92app.Properties.Resources.caixareg_gif;
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caixaToolStripMenuItem.Text = "&Caixa";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema TI92 Comercial - TI92SYS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem canceladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}