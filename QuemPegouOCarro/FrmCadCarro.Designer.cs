namespace QuemPegouOCarro
{
    partial class FrmCadCarro
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
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtChassi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRenavam = new System.Windows.Forms.TextBox();
            this.DgvListaCarro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renavam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPlaca.Location = new System.Drawing.Point(16, 27);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(64, 20);
            this.TxtPlaca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca/Modelo";
            // 
            // TxtMarca
            // 
            this.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMarca.Location = new System.Drawing.Point(86, 27);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(173, 20);
            this.TxtMarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chassi";
            // 
            // TxtChassi
            // 
            this.TxtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtChassi.Location = new System.Drawing.Point(16, 66);
            this.TxtChassi.Name = "TxtChassi";
            this.TxtChassi.Size = new System.Drawing.Size(243, 20);
            this.TxtChassi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Renavam";
            // 
            // TxtRenavam
            // 
            this.TxtRenavam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRenavam.Location = new System.Drawing.Point(16, 105);
            this.TxtRenavam.Name = "TxtRenavam";
            this.TxtRenavam.Size = new System.Drawing.Size(112, 20);
            this.TxtRenavam.TabIndex = 7;
            // 
            // DgvListaCarro
            // 
            this.DgvListaCarro.AllowUserToAddRows = false;
            this.DgvListaCarro.AllowUserToDeleteRows = false;
            this.DgvListaCarro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaCarro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCarro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Placa,
            this.Marca,
            this.Chassi,
            this.Renavam});
            this.DgvListaCarro.Location = new System.Drawing.Point(19, 131);
            this.DgvListaCarro.MultiSelect = false;
            this.DgvListaCarro.Name = "DgvListaCarro";
            this.DgvListaCarro.ReadOnly = true;
            this.DgvListaCarro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaCarro.Size = new System.Drawing.Size(396, 111);
            this.DgvListaCarro.TabIndex = 8;
            this.DgvListaCarro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaCarro_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Placa
            // 
            this.Placa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 59;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 62;
            // 
            // Chassi
            // 
            this.Chassi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Chassi.DataPropertyName = "Chassi";
            this.Chassi.HeaderText = "Chassi";
            this.Chassi.Name = "Chassi";
            this.Chassi.ReadOnly = true;
            this.Chassi.Width = 63;
            // 
            // Renavam
            // 
            this.Renavam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Renavam.DataPropertyName = "Renavam";
            this.Renavam.HeaderText = "Renavam";
            this.Renavam.Name = "Renavam";
            this.Renavam.ReadOnly = true;
            this.Renavam.Width = 78;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(340, 24);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 9;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(340, 53);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 9;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(340, 82);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dois cliques sobre o veiculo para EXCLUIR ou ATUALIZAR";
            // 
            // FrmCadCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 267);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DgvListaCarro);
            this.Controls.Add(this.TxtRenavam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtChassi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadCarro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Carro";
            this.Load += new System.EventHandler(this.FrmCadCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtChassi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRenavam;
        private System.Windows.Forms.DataGridView DgvListaCarro;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renavam;
        private System.Windows.Forms.Label label5;
    }
}