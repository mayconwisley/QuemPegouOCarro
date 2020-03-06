using Comandos.Consulta;
using Comandos.Cadastro;
using Comandos.Exclusao;
using Classes.Cadastros;
using System;
using System.Windows.Forms;
using System.Linq;

namespace QuemPegouOCarro
{
    public partial class FrmCadVencCarro : Form
    {
        public FrmCadVencCarro()
        {
            InitializeComponent();
        }

        ConsultaCarro consultaCarro;
        ConsultaIDCarro consultaIDCarro;
        ConsultaCadVencCarro consultarCadVencCarro;
        InserirCadVencCarro cadastroVencCarro;
        ExcluirCadVencCarro excluirVencCarro;
        CadVencCarro cadVencCarro;

        int ID_Carro, ID_Vencimento;

        private void ListarMarcasModeloCarro()
        {
            try
            {
                consultaCarro = new ConsultaCarro();
                CbxCarroModelo.DataSource = consultaCarro.ListaCadCarro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void GridListaVencimento()
        {
            consultarCadVencCarro = new ConsultaCadVencCarro();

            try
            {
                var listaVencCarro = consultarCadVencCarro.ListaVencCarro().Select(ListaVencCarro => new
                {
                    ID = ListaVencCarro.ID,
                    Marca = ListaVencCarro.ID_Carro.Marca,
                    DataVencimento = ListaVencCarro.Vencimento,
                    Status = ListaVencCarro.Status


                }).ToList();

                DgvListaVencimentos.DataSource = null;
                DgvListaVencimentos.DataSource = listaVencCarro;
                DgvListaVencimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DgvListaVencimentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvListaVencimentos.Columns["ID"].Visible = false;
                DgvListaVencimentos.Columns["Status"].Visible = false;
                DgvListaVencimentos.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void FrmCadVencCarro_Load(object sender, EventArgs e)
        {
            ListarMarcasModeloCarro();
            GridListaVencimento();
        }

        private void CbxCarroModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaIDCarro = new ConsultaIDCarro();

            try
            {
                ID_Carro = consultaIDCarro.IDCarro(CbxCarroModelo.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // A = A vencer, V = Vencido;

            cadastroVencCarro = new InserirCadVencCarro();
            cadVencCarro = new CadVencCarro();

            char status = 'A';
            try
            {
                if (DtpDataVencimento.Value.Date < DateTime.Now.Date)
                {
                    status = 'V';
                }

                cadVencCarro.ID_Carro = new CadCarro();
                cadVencCarro.ID_Carro.ID = ID_Carro;
                cadVencCarro.Vencimento = DateTime.Parse(DtpDataVencimento.Text);
                cadVencCarro.Status = status.ToString();
                cadastroVencCarro.CadastrarVencCarro(cadVencCarro);
                GridListaVencimento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DgvListaVencimentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID_Vencimento = int.Parse(DgvListaVencimentos.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                BtnExcluir.Enabled = true;
                BtnSalvar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            excluirVencCarro = new ExcluirCadVencCarro();
            try
            {
                excluirVencCarro.ExcluirVencCarro(ID_Vencimento);
                GridListaVencimento();
                BtnExcluir.Enabled = false;
                BtnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
    }
}
