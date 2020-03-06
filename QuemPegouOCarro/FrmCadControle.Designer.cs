namespace QuemPegouOCarro
{
    partial class FrmCadControle
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
            this.CbxMarcaModeloCarro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxMotorista = new System.Windows.Forms.ComboBox();
            this.LblDataHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.DgvListaSaidaChegada = new System.Windows.Forms.DataGridView();
            this.BtnSaiu = new System.Windows.Forms.Button();
            this.BtnChegou = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaSaidaChegada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro - Marca/Modelo";
            // 
            // CbxMarcaModeloCarro
            // 
            this.CbxMarcaModeloCarro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxMarcaModeloCarro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxMarcaModeloCarro.DisplayMember = "Marca";
            this.CbxMarcaModeloCarro.FormattingEnabled = true;
            this.CbxMarcaModeloCarro.Location = new System.Drawing.Point(15, 25);
            this.CbxMarcaModeloCarro.Name = "CbxMarcaModeloCarro";
            this.CbxMarcaModeloCarro.Size = new System.Drawing.Size(297, 21);
            this.CbxMarcaModeloCarro.TabIndex = 1;
            this.CbxMarcaModeloCarro.ValueMember = "Marca";
            this.CbxMarcaModeloCarro.SelectedIndexChanged += new System.EventHandler(this.CbxMarcaModeloCarro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motorista";
            // 
            // CbxMotorista
            // 
            this.CbxMotorista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxMotorista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxMotorista.DisplayMember = "Nome";
            this.CbxMotorista.FormattingEnabled = true;
            this.CbxMotorista.Location = new System.Drawing.Point(15, 86);
            this.CbxMotorista.Name = "CbxMotorista";
            this.CbxMotorista.Size = new System.Drawing.Size(297, 21);
            this.CbxMotorista.TabIndex = 3;
            this.CbxMotorista.ValueMember = "Nome";
            this.CbxMotorista.SelectedIndexChanged += new System.EventHandler(this.CbxMotorista_SelectedIndexChanged);
            // 
            // LblDataHora
            // 
            this.LblDataHora.AutoSize = true;
            this.LblDataHora.Location = new System.Drawing.Point(12, 133);
            this.LblDataHora.Name = "LblDataHora";
            this.LblDataHora.Size = new System.Drawing.Size(80, 13);
            this.LblDataHora.TabIndex = 4;
            this.LblDataHora.Text = "Data e Hora: ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição";
            // 
            // RtxtDescricao
            // 
            this.RtxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtxtDescricao.Location = new System.Drawing.Point(15, 183);
            this.RtxtDescricao.MaxLength = 255;
            this.RtxtDescricao.Name = "RtxtDescricao";
            this.RtxtDescricao.Size = new System.Drawing.Size(297, 96);
            this.RtxtDescricao.TabIndex = 6;
            this.RtxtDescricao.Text = "";
            // 
            // DgvListaSaidaChegada
            // 
            this.DgvListaSaidaChegada.AllowUserToAddRows = false;
            this.DgvListaSaidaChegada.AllowUserToDeleteRows = false;
            this.DgvListaSaidaChegada.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaSaidaChegada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaSaidaChegada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaSaidaChegada.Location = new System.Drawing.Point(15, 312);
            this.DgvListaSaidaChegada.MultiSelect = false;
            this.DgvListaSaidaChegada.Name = "DgvListaSaidaChegada";
            this.DgvListaSaidaChegada.ReadOnly = true;
            this.DgvListaSaidaChegada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaSaidaChegada.Size = new System.Drawing.Size(566, 150);
            this.DgvListaSaidaChegada.TabIndex = 7;
            this.DgvListaSaidaChegada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaSaidaChegada_CellDoubleClick);
            // 
            // BtnSaiu
            // 
            this.BtnSaiu.Location = new System.Drawing.Point(412, 25);
            this.BtnSaiu.Name = "BtnSaiu";
            this.BtnSaiu.Size = new System.Drawing.Size(169, 82);
            this.BtnSaiu.TabIndex = 8;
            this.BtnSaiu.Text = "&Saiu!!!";
            this.BtnSaiu.UseVisualStyleBackColor = true;
            this.BtnSaiu.Click += new System.EventHandler(this.BtnSaiu_Click);
            // 
            // BtnChegou
            // 
            this.BtnChegou.Enabled = false;
            this.BtnChegou.Location = new System.Drawing.Point(412, 150);
            this.BtnChegou.Name = "BtnChegou";
            this.BtnChegou.Size = new System.Drawing.Size(169, 82);
            this.BtnChegou.TabIndex = 8;
            this.BtnChegou.Text = "&Chegou!!!";
            this.BtnChegou.UseVisualStyleBackColor = true;
            this.BtnChegou.Click += new System.EventHandler(this.BtnChegou_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(506, 283);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dois cliques para indicar que CHEGOU ou EXCLUIR.";
            // 
            // FrmCadControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnChegou);
            this.Controls.Add(this.BtnSaiu);
            this.Controls.Add(this.DgvListaSaidaChegada);
            this.Controls.Add(this.RtxtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDataHora);
            this.Controls.Add(this.CbxMotorista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxMarcaModeloCarro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadControle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Controle";
            this.Load += new System.EventHandler(this.FrmCadControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaSaidaChegada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxMarcaModeloCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxMotorista;
        private System.Windows.Forms.Label LblDataHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RtxtDescricao;
        private System.Windows.Forms.DataGridView DgvListaSaidaChegada;
        private System.Windows.Forms.Button BtnSaiu;
        private System.Windows.Forms.Button BtnChegou;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label3;
    }
}