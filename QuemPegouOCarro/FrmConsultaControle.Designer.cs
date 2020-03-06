namespace QuemPegouOCarro
{
    partial class FrmConsultaControle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbGeral = new System.Windows.Forms.RadioButton();
            this.RbPorMotorista = new System.Windows.Forms.RadioButton();
            this.RbPorCarro = new System.Windows.Forms.RadioButton();
            this.RbPorData = new System.Windows.Forms.RadioButton();
            this.CbxMotorista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxCarro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListaControle = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaControle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbGeral);
            this.groupBox1.Controls.Add(this.RbPorMotorista);
            this.groupBox1.Controls.Add(this.RbPorCarro);
            this.groupBox1.Controls.Add(this.RbPorData);
            this.groupBox1.Controls.Add(this.CbxMotorista);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CbxCarro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // RbGeral
            // 
            this.RbGeral.AutoSize = true;
            this.RbGeral.Checked = true;
            this.RbGeral.Location = new System.Drawing.Point(9, 18);
            this.RbGeral.Name = "RbGeral";
            this.RbGeral.Size = new System.Drawing.Size(50, 17);
            this.RbGeral.TabIndex = 6;
            this.RbGeral.TabStop = true;
            this.RbGeral.Text = "Geral";
            this.RbGeral.UseVisualStyleBackColor = true;
            this.RbGeral.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // RbPorMotorista
            // 
            this.RbPorMotorista.AutoSize = true;
            this.RbPorMotorista.Location = new System.Drawing.Point(213, 19);
            this.RbPorMotorista.Name = "RbPorMotorista";
            this.RbPorMotorista.Size = new System.Drawing.Size(87, 17);
            this.RbPorMotorista.TabIndex = 6;
            this.RbPorMotorista.Text = "Por Motorista";
            this.RbPorMotorista.UseVisualStyleBackColor = true;
            this.RbPorMotorista.CheckedChanged += new System.EventHandler(this.RbPorMotorista_CheckedChanged);
            // 
            // RbPorCarro
            // 
            this.RbPorCarro.AutoSize = true;
            this.RbPorCarro.Location = new System.Drawing.Point(138, 18);
            this.RbPorCarro.Name = "RbPorCarro";
            this.RbPorCarro.Size = new System.Drawing.Size(69, 17);
            this.RbPorCarro.TabIndex = 6;
            this.RbPorCarro.Text = "Por Carro";
            this.RbPorCarro.UseVisualStyleBackColor = true;
            this.RbPorCarro.CheckedChanged += new System.EventHandler(this.RbPorCarro_CheckedChanged);
            // 
            // RbPorData
            // 
            this.RbPorData.AutoSize = true;
            this.RbPorData.Location = new System.Drawing.Point(65, 18);
            this.RbPorData.Name = "RbPorData";
            this.RbPorData.Size = new System.Drawing.Size(67, 17);
            this.RbPorData.TabIndex = 6;
            this.RbPorData.Text = "Por Data";
            this.RbPorData.UseVisualStyleBackColor = true;
            this.RbPorData.CheckedChanged += new System.EventHandler(this.RbPorData_CheckedChanged);
            // 
            // CbxMotorista
            // 
            this.CbxMotorista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxMotorista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxMotorista.DisplayMember = "Nome";
            this.CbxMotorista.Enabled = false;
            this.CbxMotorista.FormattingEnabled = true;
            this.CbxMotorista.Location = new System.Drawing.Point(9, 94);
            this.CbxMotorista.Name = "CbxMotorista";
            this.CbxMotorista.Size = new System.Drawing.Size(479, 21);
            this.CbxMotorista.TabIndex = 5;
            this.CbxMotorista.ValueMember = "Nome";
            this.CbxMotorista.SelectedIndexChanged += new System.EventHandler(this.CbxMotorista_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Motorista";
            // 
            // CbxCarro
            // 
            this.CbxCarro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxCarro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxCarro.DisplayMember = "Marca";
            this.CbxCarro.Enabled = false;
            this.CbxCarro.FormattingEnabled = true;
            this.CbxCarro.Location = new System.Drawing.Point(123, 54);
            this.CbxCarro.Name = "CbxCarro";
            this.CbxCarro.Size = new System.Drawing.Size(365, 21);
            this.CbxCarro.TabIndex = 3;
            this.CbxCarro.ValueMember = "Marca";
            this.CbxCarro.SelectedIndexChanged += new System.EventHandler(this.CbxCarro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carro - Marca/Modelo";
            // 
            // DtpData
            // 
            this.DtpData.Enabled = false;
            this.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpData.Location = new System.Drawing.Point(9, 55);
            this.DtpData.Name = "DtpData";
            this.DtpData.Size = new System.Drawing.Size(108, 20);
            this.DtpData.TabIndex = 1;
            this.DtpData.ValueChanged += new System.EventHandler(this.DtpData_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Saida";
            // 
            // DgvListaControle
            // 
            this.DgvListaControle.AllowUserToAddRows = false;
            this.DgvListaControle.AllowUserToDeleteRows = false;
            this.DgvListaControle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaControle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaControle.Location = new System.Drawing.Point(15, 143);
            this.DgvListaControle.Name = "DgvListaControle";
            this.DgvListaControle.ReadOnly = true;
            this.DgvListaControle.Size = new System.Drawing.Size(498, 230);
            this.DgvListaControle.TabIndex = 1;
            // 
            // FrmConsultaControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 386);
            this.Controls.Add(this.DgvListaControle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaControle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Controle";
            this.Load += new System.EventHandler(this.FrmConsultaControle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaControle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxMotorista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RbPorMotorista;
        private System.Windows.Forms.RadioButton RbPorCarro;
        private System.Windows.Forms.RadioButton RbPorData;
        private System.Windows.Forms.DataGridView DgvListaControle;
        private System.Windows.Forms.RadioButton RbGeral;
    }
}