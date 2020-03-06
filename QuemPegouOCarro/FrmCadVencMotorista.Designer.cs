namespace QuemPegouOCarro
{
    partial class FrmCadVencMotorista
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
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.DgvListaMotorista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxMotorista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMotorista)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(292, 41);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(292, 12);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 14;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // DgvListaMotorista
            // 
            this.DgvListaMotorista.AllowUserToAddRows = false;
            this.DgvListaMotorista.AllowUserToDeleteRows = false;
            this.DgvListaMotorista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvListaMotorista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvListaMotorista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaMotorista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaMotorista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.DataVencimento,
            this.Status});
            this.DgvListaMotorista.Location = new System.Drawing.Point(15, 111);
            this.DgvListaMotorista.MultiSelect = false;
            this.DgvListaMotorista.Name = "DgvListaMotorista";
            this.DgvListaMotorista.ReadOnly = true;
            this.DgvListaMotorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaMotorista.Size = new System.Drawing.Size(352, 136);
            this.DgvListaMotorista.TabIndex = 12;
            this.DgvListaMotorista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaMotorista_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // DataVencimento
            // 
            this.DataVencimento.DataPropertyName = "DataVencimento";
            this.DataVencimento.HeaderText = "DataVencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.ReadOnly = true;
            this.DataVencimento.Width = 111;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 62;
            // 
            // DtpVencimento
            // 
            this.DtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpVencimento.Location = new System.Drawing.Point(15, 65);
            this.DtpVencimento.Name = "DtpVencimento";
            this.DtpVencimento.Size = new System.Drawing.Size(101, 20);
            this.DtpVencimento.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data de Vencimento";
            // 
            // CbxMotorista
            // 
            this.CbxMotorista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxMotorista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxMotorista.DisplayMember = "Nome";
            this.CbxMotorista.FormattingEnabled = true;
            this.CbxMotorista.Location = new System.Drawing.Point(15, 25);
            this.CbxMotorista.Name = "CbxMotorista";
            this.CbxMotorista.Size = new System.Drawing.Size(236, 21);
            this.CbxMotorista.TabIndex = 8;
            this.CbxMotorista.ValueMember = "Nome";
            this.CbxMotorista.SelectedIndexChanged += new System.EventHandler(this.CbxMotorista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Morotista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dois cliques para EXCLUIR.";
            // 
            // FrmCadVencMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DgvListaMotorista);
            this.Controls.Add(this.DtpVencimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxMotorista);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadVencMotorista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Vencimento Motorista";
            this.Load += new System.EventHandler(this.FrmCadVencMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMotorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridView DgvListaMotorista;
        private System.Windows.Forms.DateTimePicker DtpVencimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label3;
    }
}