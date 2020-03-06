using Comandos.Cadastro;
using Comandos.Consulta;
using Comandos.Atualizacao;
using Comandos.Exclusao;
using System;
using System.Windows.Forms;
using Classes.Cadastros;

namespace QuemPegouOCarro
{
    public partial class FrmCadCarro : Form
    {
        public FrmCadCarro()
        {
            InitializeComponent();
        }

        private InserirCarro inserirCarro;
        private CadCarro cadCarro;
        private ConsultaCarro consultaCarro;
        private AtualizarCadCarro atualizarCarro;
        private ExcluirCadCarro excluirCarro;
        private int ID_Carro;

        private void GridListaCarro()
        {
            consultaCarro = new ConsultaCarro();
            try
            {
                DgvListaCarro.DataSource = consultaCarro.ListaCadCarro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void LimparCampos()
        {
            TxtPlaca.Clear();
            TxtMarca.Clear();
            TxtChassi.Clear();
            TxtRenavam.Clear();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            cadCarro = new CadCarro();
            inserirCarro = new InserirCarro();

            cadCarro.Placa = TxtPlaca.Text.Trim();
            cadCarro.Marca = TxtMarca.Text.Trim();
            cadCarro.Chassi = TxtChassi.Text.Trim();
            cadCarro.Renavam = TxtRenavam.Text.Trim();

            try
            {
                inserirCarro.CadastrarCarro(cadCarro);
                LimparCampos();
                GridListaCarro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }

        private void FrmCadCarro_Load(object sender, EventArgs e)
        {
            GridListaCarro();
        }

        private void DgvListaCarro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID_Carro = int.Parse(DgvListaCarro.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                TxtPlaca.Text = DgvListaCarro.Rows[e.RowIndex].Cells["Placa"].Value.ToString();
                TxtMarca.Text = DgvListaCarro.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                TxtChassi.Text = DgvListaCarro.Rows[e.RowIndex].Cells["Chassi"].Value.ToString();
                TxtRenavam.Text = DgvListaCarro.Rows[e.RowIndex].Cells["Renavam"].Value.ToString();
                BtnSalvar.Enabled = false;
                BtnExcluir.Enabled = true;
                BtnAlterar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            cadCarro = new CadCarro();
            atualizarCarro = new AtualizarCadCarro();

            cadCarro.ID = ID_Carro;
            cadCarro.Placa = TxtPlaca.Text.Trim();
            cadCarro.Marca = TxtMarca.Text.Trim();
            cadCarro.Chassi = TxtChassi.Text.Trim();
            cadCarro.Renavam = TxtRenavam.Text.Trim();

            try
            {
                atualizarCarro.AtualizarCarro(cadCarro);
                LimparCampos();
                GridListaCarro();
                BtnSalvar.Enabled = true;
                BtnExcluir.Enabled = false;
                BtnAlterar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            excluirCarro = new ExcluirCadCarro();

            try
            {
                if (MessageBox.Show("A exclusão do veiculo irá excluir os dados de controle e vencimentos.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    excluirCarro.ExcluirCarro(ID_Carro);
                    LimparCampos();
                    GridListaCarro();
                    BtnSalvar.Enabled = true;
                    BtnExcluir.Enabled = false;
                    BtnAlterar.Enabled = false;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
    }
}
