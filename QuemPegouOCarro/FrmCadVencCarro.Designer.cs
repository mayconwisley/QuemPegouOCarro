namespace QuemPegouOCarro
{
    partial class FrmCadVencCarro
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
            this.CbxCarroModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.DgvListaVencimentos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVencimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro - Modelo/Marca";
            // 
            // CbxCarroModelo
            // 
            this.CbxCarroModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxCarroModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxCarroModelo.DisplayMember = "Marca";
            this.CbxCarroModelo.FormattingEnabled = true;
            this.CbxCarroModelo.Location = new System.Drawing.Point(15, 25);
            this.CbxCarroModelo.Name = "CbxCarroModelo";
            this.CbxCarroModelo.Size = new System.Drawing.Size(236, 21);
            this.CbxCarroModelo.TabIndex = 1;
            this.CbxCarroModelo.ValueMember = "Marca";
            this.CbxCarroModelo.SelectedIndexChanged += new System.EventHandler(this.CbxCarroModelo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Vencimento";
            // 
            // DtpDataVencimento
            // 
            this.DtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataVencimento.Location = new System.Drawing.Point(15, 65);
            this.DtpDataVencimento.Name = "DtpDataVencimento";
            this.DtpDataVencimento.Size = new System.Drawing.Size(101, 20);
            this.DtpDataVencimento.TabIndex = 3;
            // 
            // DgvListaVencimentos
            // 
            this.DgvListaVencimentos.AllowUserToAddRows = false;
            this.DgvListaVencimentos.AllowUserToDeleteRows = false;
            this.DgvListaVencimentos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaVencimentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaVencimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaVencimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Marca,
            this.DataVencimento,
            this.Status});
            this.DgvListaVencimentos.Location = new System.Drawing.Point(15, 111);
            this.DgvListaVencimentos.MultiSelect = false;
            this.DgvListaVencimentos.Name = "DgvListaVencimentos";
            this.DgvListaVencimentos.ReadOnly = true;
            this.DgvListaVencimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaVencimentos.Size = new System.Drawing.Size(352, 136);
            this.DgvListaVencimentos.TabIndex = 5;
            this.DgvListaVencimentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaVencimentos_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // DataVencimento
            // 
            this.DataVencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataVencimento.DataPropertyName = "DataVencimento";
            this.DataVencimento.HeaderText = "DataVencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.ReadOnly = true;
            this.DataVencimento.Width = 111;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(292, 12);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(292, 41);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dois cliques para EXCLUIR.";
            // 
            // FrmCadVencCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 273);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DgvListaVencimentos);
            this.Controls.Add(this.DtpDataVencimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxCarroModelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadVencCarro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Vencimento Carro";
            this.Load += new System.EventHandler(this.FrmCadVencCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVencimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxCarroModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpDataVencimento;
        private System.Windows.Forms.DataGridView DgvListaVencimentos;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label3;
    }
}