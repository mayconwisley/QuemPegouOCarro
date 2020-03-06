namespace QuemPegouOCarro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastrarCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastrarMotorista = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastrarVencimento = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuVencimentoCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuVencimentoMotorista = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuControleSaidaChegada = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuConsultarSaidaChegada = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRelatorioVencimento = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRelatorioMotorista = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRelatorioCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRelatorioControle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnQuemPegouOCarro = new System.Windows.Forms.Button();
            this.LblDataHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrar,
            this.MenuControle,
            this.MenuConsultar,
            this.MenuRelatorio,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastrar
            // 
            this.MenuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCadastrarCarro,
            this.SubMenuCadastrarMotorista,
            this.SubMenuCadastrarVencimento});
            this.MenuCadastrar.Name = "MenuCadastrar";
            this.MenuCadastrar.Size = new System.Drawing.Size(69, 20);
            this.MenuCadastrar.Text = "Cadastrar";
            // 
            // SubMenuCadastrarCarro
            // 
            this.SubMenuCadastrarCarro.Name = "SubMenuCadastrarCarro";
            this.SubMenuCadastrarCarro.Size = new System.Drawing.Size(142, 22);
            this.SubMenuCadastrarCarro.Text = "Carro";
            this.SubMenuCadastrarCarro.Click += new System.EventHandler(this.SubMenuCadastrarCarro_Click);
            // 
            // SubMenuCadastrarMotorista
            // 
            this.SubMenuCadastrarMotorista.Name = "SubMenuCadastrarMotorista";
            this.SubMenuCadastrarMotorista.Size = new System.Drawing.Size(142, 22);
            this.SubMenuCadastrarMotorista.Text = "Motorista";
            this.SubMenuCadastrarMotorista.Click += new System.EventHandler(this.SubMenuCadastrarMotorista_Click);
            // 
            // SubMenuCadastrarVencimento
            // 
            this.SubMenuCadastrarVencimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuVencimentoCarro,
            this.SubMenuVencimentoMotorista});
            this.SubMenuCadastrarVencimento.Name = "SubMenuCadastrarVencimento";
            this.SubMenuCadastrarVencimento.Size = new System.Drawing.Size(142, 22);
            this.SubMenuCadastrarVencimento.Text = "Vencimentos";
            // 
            // SubMenuVencimentoCarro
            // 
            this.SubMenuVencimentoCarro.Name = "SubMenuVencimentoCarro";
            this.SubMenuVencimentoCarro.Size = new System.Drawing.Size(125, 22);
            this.SubMenuVencimentoCarro.Text = "Carro";
            this.SubMenuVencimentoCarro.Click += new System.EventHandler(this.SubMenuVencimentoCarro_Click);
            // 
            // SubMenuVencimentoMotorista
            // 
            this.SubMenuVencimentoMotorista.Name = "SubMenuVencimentoMotorista";
            this.SubMenuVencimentoMotorista.Size = new System.Drawing.Size(125, 22);
            this.SubMenuVencimentoMotorista.Text = "Motorista";
            this.SubMenuVencimentoMotorista.Click += new System.EventHandler(this.SubMenuVencimentoMotorista_Click);
            // 
            // MenuControle
            // 
            this.MenuControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuControleSaidaChegada});
            this.MenuControle.Name = "MenuControle";
            this.MenuControle.Size = new System.Drawing.Size(65, 20);
            this.MenuControle.Text = "Controle";
            // 
            // SubMenuControleSaidaChegada
            // 
            this.SubMenuControleSaidaChegada.Name = "SubMenuControleSaidaChegada";
            this.SubMenuControleSaidaChegada.Size = new System.Drawing.Size(193, 22);
            this.SubMenuControleSaidaChegada.Text = "Saida e Chegada Carro";
            this.SubMenuControleSaidaChegada.Click += new System.EventHandler(this.SubMenuControleSaidaChegada_Click);
            // 
            // MenuConsultar
            // 
            this.MenuConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuConsultarSaidaChegada});
            this.MenuConsultar.Name = "MenuConsultar";
            this.MenuConsultar.Size = new System.Drawing.Size(70, 20);
            this.MenuConsultar.Text = "Consultar";
            // 
            // SubMenuConsultarSaidaChegada
            // 
            this.SubMenuConsultarSaidaChegada.Name = "SubMenuConsultarSaidaChegada";
            this.SubMenuConsultarSaidaChegada.Size = new System.Drawing.Size(194, 22);
            this.SubMenuConsultarSaidaChegada.Text = "Saida e Chegado Carro";
            this.SubMenuConsultarSaidaChegada.Click += new System.EventHandler(this.SubMenuConsultarSaidaChegada_Click);
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRelatorioVencimento,
            this.SubMenuRelatorioMotorista,
            this.SubMenuRelatorioCarro,
            this.SubMenuRelatorioControle});
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(66, 20);
            this.MenuRelatorio.Text = "Relatório";
            this.MenuRelatorio.Visible = false;
            // 
            // SubMenuRelatorioVencimento
            // 
            this.SubMenuRelatorioVencimento.Name = "SubMenuRelatorioVencimento";
            this.SubMenuRelatorioVencimento.Size = new System.Drawing.Size(142, 22);
            this.SubMenuRelatorioVencimento.Text = "Vencimentos";
            this.SubMenuRelatorioVencimento.Click += new System.EventHandler(this.SubMenuRelatorioVencimento_Click);
            // 
            // SubMenuRelatorioMotorista
            // 
            this.SubMenuRelatorioMotorista.Name = "SubMenuRelatorioMotorista";
            this.SubMenuRelatorioMotorista.Size = new System.Drawing.Size(142, 22);
            this.SubMenuRelatorioMotorista.Text = "Motoristas";
            // 
            // SubMenuRelatorioCarro
            // 
            this.SubMenuRelatorioCarro.Name = "SubMenuRelatorioCarro";
            this.SubMenuRelatorioCarro.Size = new System.Drawing.Size(142, 22);
            this.SubMenuRelatorioCarro.Text = "Carros";
            // 
            // SubMenuRelatorioControle
            // 
            this.SubMenuRelatorioControle.Name = "SubMenuRelatorioControle";
            this.SubMenuRelatorioControle.Size = new System.Drawing.Size(142, 22);
            this.SubMenuRelatorioControle.Text = "Controle";
            this.SubMenuRelatorioControle.Click += new System.EventHandler(this.SubMenuRelatorioControle_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 102);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(246, 17);
            this.toolStripStatusLabel1.Text = "Desenvolvido por: Maycon Wisley | Versão 1.0";
            // 
            // btnQuemPegouOCarro
            // 
            this.btnQuemPegouOCarro.BackgroundImage = global::QuemPegouOCarro.Properties.Resources.opalapreto78;
            this.btnQuemPegouOCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuemPegouOCarro.FlatAppearance.BorderSize = 0;
            this.btnQuemPegouOCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnQuemPegouOCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnQuemPegouOCarro.Location = new System.Drawing.Point(12, 27);
            this.btnQuemPegouOCarro.Name = "btnQuemPegouOCarro";
            this.btnQuemPegouOCarro.Size = new System.Drawing.Size(195, 69);
            this.btnQuemPegouOCarro.TabIndex = 2;
            this.btnQuemPegouOCarro.Text = "button1";
            this.btnQuemPegouOCarro.UseVisualStyleBackColor = true;
            this.btnQuemPegouOCarro.Click += new System.EventHandler(this.SubMenuControleSaidaChegada_Click);
            // 
            // LblDataHora
            // 
            this.LblDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDataHora.AutoSize = true;
            this.LblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataHora.Location = new System.Drawing.Point(226, 48);
            this.LblDataHora.Name = "LblDataHora";
            this.LblDataHora.Size = new System.Drawing.Size(36, 54);
            this.LblDataHora.TabIndex = 3;
            this.LblDataHora.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 124);
            this.Controls.Add(this.LblDataHora);
            this.Controls.Add(this.btnQuemPegouOCarro);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quem Pegou o Carro?";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultar;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastrarCarro;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastrarMotorista;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastrarVencimento;
        private System.Windows.Forms.ToolStripMenuItem SubMenuVencimentoCarro;
        private System.Windows.Forms.ToolStripMenuItem SubMenuVencimentoMotorista;
        private System.Windows.Forms.ToolStripMenuItem MenuControle;
        private System.Windows.Forms.ToolStripMenuItem SubMenuControleSaidaChegada;
        private System.Windows.Forms.ToolStripMenuItem SubMenuConsultarSaidaChegada;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRelatorioVencimento;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRelatorioMotorista;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRelatorioCarro;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRelatorioControle;
        private System.Windows.Forms.Button btnQuemPegouOCarro;
        private System.Windows.Forms.Label LblDataHora;
        private System.Windows.Forms.Timer timer1;
    }
}

