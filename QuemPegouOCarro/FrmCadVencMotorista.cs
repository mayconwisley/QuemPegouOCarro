using Classes.Cadastros;
using Comandos.Cadastro;
using Comandos.Consulta;
using Comandos.Exclusao;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace QuemPegouOCarro
{
    public partial class FrmCadVencMotorista : Form
    {
        public FrmCadVencMotorista()
        {
            InitializeComponent();
        }

        ConsultaCadVencMotorista consultaVencMotorista;
        ConsultaMotorista consultaMotorista;
        InserirCadVencMotorista cadastroVencMotorista;
        ExcluirCadVencMotorista excluirVencMotorista;
        CadVencMototista cadVencMotorista;
        ConsultaIDMotorista consultarIDMotorista;

        int ID_Motorista, ID_VencMotorista;

        private void ListarMotorista()
        {
            try
            {
                consultaMotorista = new ConsultaMotorista();
                CbxMotorista.DataSource = consultaMotorista.ListaCadMotorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void GridListaVencimento()
        {
            consultaVencMotorista = new ConsultaCadVencMotorista();

            try
            {
                var listaVencMotorista = consultaVencMotorista.ListaVencMotorista().Select(ListaVencMotorista => new
                {
                    ID = ListaVencMotorista.ID,
                    Nome = ListaVencMotorista.ID_Motorista.Nome,
                    DataVencimento = ListaVencMotorista.Vencimento,
                    Status = ListaVencMotorista.Status
                }).ToList();

                DgvListaMotorista.DataSource = null;
                DgvListaMotorista.DataSource = listaVencMotorista;
                DgvListaMotorista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DgvListaMotorista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvListaMotorista.Columns["ID"].Visible = false;
                DgvListaMotorista.Columns["Status"].Visible = false;
                DgvListaMotorista.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void FrmCadVencMotorista_Load(object sender, EventArgs e)
        {
            ListarMotorista();
            GridListaVencimento();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // A = A vencer, V = Vencido;

            cadastroVencMotorista = new InserirCadVencMotorista();
            cadVencMotorista = new CadVencMototista();

            char status = 'A';
            try
            {
                if (DtpVencimento.Value.Date < DateTime.Now.Date)
                {
                    status = 'V';
                }

                cadVencMotorista.ID_Motorista = new CadMotorista();
                cadVencMotorista.ID_Motorista.ID = ID_Motorista;
                cadVencMotorista.Vencimento = DateTime.Parse(DtpVencimento.Text);
                cadVencMotorista.Status = status.ToString();
                cadastroVencMotorista.CadastrarVencMotorista(cadVencMotorista);
                GridListaVencimento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void CbxMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultarIDMotorista = new ConsultaIDMotorista();

            try
            {
                ID_Motorista = consultarIDMotorista.IDMotorista(CbxMotorista.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);

            }
        }

        private void DgvListaMotorista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID_VencMotorista = int.Parse(DgvListaMotorista.Rows[e.RowIndex].Cells["ID"].Value.ToString());
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
            excluirVencMotorista = new ExcluirCadVencMotorista();
            try
            {
                excluirVencMotorista.ExcluirVencMotorista(ID_VencMotorista);
                GridListaVencimento();
                BtnExcluir.Enabled = true;
                BtnSalvar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
    }
}
