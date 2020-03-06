namespace QuemPegouOCarro
{
    partial class FrmCadMotorista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMotorista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCNH = new System.Windows.Forms.TextBox();
            this.MktVencimentoCNH = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MktCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRG = new System.Windows.Forms.TextBox();
            this.DgvListaMotorista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VencimentoCNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMotorista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motorista";
            // 
            // TxtMotorista
            // 
            this.TxtMotorista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMotorista.Location = new System.Drawing.Point(15, 27);
            this.TxtMotorista.Name = "TxtMotorista";
            this.TxtMotorista.Size = new System.Drawing.Size(328, 20);
            this.TxtMotorista.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNH";
            // 
            // TxtCNH
            // 
            this.TxtCNH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCNH.Location = new System.Drawing.Point(15, 66);
            this.TxtCNH.Name = "TxtCNH";
            this.TxtCNH.Size = new System.Drawing.Size(139, 20);
            this.TxtCNH.TabIndex = 3;
            // 
            // MktVencimentoCNH
            // 
            this.MktVencimentoCNH.Location = new System.Drawing.Point(160, 66);
            this.MktVencimentoCNH.Mask = "00/00/0000";
            this.MktVencimentoCNH.Name = "MktVencimentoCNH";
            this.MktVencimentoCNH.Size = new System.Drawing.Size(86, 20);
            this.MktVencimentoCNH.TabIndex = 4;
            this.MktVencimentoCNH.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vencimento CNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF";
            // 
            // MktCPF
            // 
            this.MktCPF.Location = new System.Drawing.Point(15, 105);
            this.MktCPF.Mask = "000\\.000\\.000\\-00";
            this.MktCPF.Name = "MktCPF";
            this.MktCPF.Size = new System.Drawing.Size(94, 20);
            this.MktCPF.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "RG";
            // 
            // TxtRG
            // 
            this.TxtRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRG.Location = new System.Drawing.Point(115, 105);
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(105, 20);
            this.TxtRG.TabIndex = 9;
            // 
            // DgvListaMotorista
            // 
            this.DgvListaMotorista.AllowUserToAddRows = false;
            this.DgvListaMotorista.AllowUserToDeleteRows = false;
            this.DgvListaMotorista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaMotorista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaMotorista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CNH,
            this.VencimentoCNH,
            this.CPF,
            this.RG});
            this.DgvListaMotorista.Location = new System.Drawing.Point(15, 146);
            this.DgvListaMotorista.MultiSelect = false;
            this.DgvListaMotorista.Name = "DgvListaMotorista";
            this.DgvListaMotorista.ReadOnly = true;
            this.DgvListaMotorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaMotorista.Size = new System.Drawing.Size(453, 150);
            this.DgvListaMotorista.TabIndex = 10;
            this.DgvListaMotorista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaMotorista_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            // CNH
            // 
            this.CNH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CNH.DataPropertyName = "CNH";
            this.CNH.HeaderText = "CNH";
            this.CNH.Name = "CNH";
            this.CNH.ReadOnly = true;
            this.CNH.Width = 55;
            // 
            // VencimentoCNH
            // 
            this.VencimentoCNH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VencimentoCNH.DataPropertyName = "VencimentoCNH";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.VencimentoCNH.DefaultCellStyle = dataGridViewCellStyle3;
            this.VencimentoCNH.HeaderText = "Vencimento CNH";
            this.VencimentoCNH.Name = "VencimentoCNH";
            this.VencimentoCNH.ReadOnly = true;
            this.VencimentoCNH.Width = 105;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPF.DataPropertyName = "CPF";
            dataGridViewCellStyle4.Format = "000\\.000\\.000-00";
            dataGridViewCellStyle4.NullValue = null;
            this.CPF.DefaultCellStyle = dataGridViewCellStyle4;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 52;
            // 
            // RG
            // 
            this.RG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RG.DataPropertyName = "RG";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Width = 48;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(393, 26);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(393, 55);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 11;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(393, 84);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dois cliques sobre o motorista para EXCLUIR ou ATUALIZAR.";
            // 
            // FrmCadMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 321);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DgvListaMotorista);
            this.Controls.Add(this.TxtRG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MktCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MktVencimentoCNH);
            this.Controls.Add(this.TxtCNH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMotorista);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadMotorista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Motorista";
            this.Load += new System.EventHandler(this.FrmCadMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMotorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMotorista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCNH;
        private System.Windows.Forms.MaskedTextBox MktVencimentoCNH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MktCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRG;
        private System.Windows.Forms.DataGridView DgvListaMotorista;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn VencimentoCNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.Label label6;
    }
}