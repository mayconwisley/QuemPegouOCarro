using Classes.Cadastros;
using Comandos.Atualizacao;
using Comandos.Cadastro;
using Comandos.Consulta;
using Comandos.Exclusao;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace QuemPegouOCarro
{
    public partial class FrmCadControle : Form
    {
        public FrmCadControle()
        {
            InitializeComponent();
        }

        ConsultaCarro consultaCarro;
        ConsultaMotorista consultaMotorista;
        ConsultaIDCarro consultaIdCarro;
        ConsultaIDMotorista consultaIdMotorista;
        ConsultaCadControle consultaControle;
        InserirCadConstrole cadastroControle;
        AtualizarCadControle atualizarControle;
        ExcluirCadControle excluirControle;
        CadControle cadControle;

        DateTime dataHora;

        int ID_Carro, ID_Motorista, ID_Controle;

        private void ListaMarcaModeloCarro()
        {
            consultaCarro = new ConsultaCarro();
            try
            {
                CbxMarcaModeloCarro.DataSource = consultaCarro.ListaCadCarro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void ListaMotorista()
        {
            consultaMotorista = new ConsultaMotorista();
            try
            {
                CbxMotorista.DataSource = consultaMotorista.ListaCadMotorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void GridListaControle()
        {
            consultaControle = new ConsultaCadControle();
            try
            {
                var listaControle = consultaControle.ListaCadControle().Select(ListaControle => new
                {
                    ID = ListaControle.ID,
                    Nome = ListaControle.ID_Motorista.Nome,
                    Marca = ListaControle.ID_Carro.Marca,
                    DataHoraSaida = ListaControle.Saida,
                    DataHoraChegada = ListaControle.Chegada,
                    Descricao = ListaControle.Descricao
                }).ToList();

                DgvListaSaidaChegada.DataSource = null;
                DgvListaSaidaChegada.DataSource = listaControle;
                DgvListaSaidaChegada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DgvListaSaidaChegada.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvListaSaidaChegada.Columns["ID"].Visible = false;
                DgvListaSaidaChegada.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void FrmCadControle_Load(object sender, EventArgs e)
        {
            ListaMarcaModeloCarro();
            ListaMotorista();
            GridListaControle();
        }

        private void CbxMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaIdMotorista = new ConsultaIDMotorista();
            ID_Motorista = consultaIdMotorista.IDMotorista(CbxMotorista.Text.Trim());
        }

        private void BtnSaiu_Click(object sender, EventArgs e)
        {
            cadastroControle = new InserirCadConstrole();
            cadControle = new CadControle();
            try
            {
                cadControle.Saida = dataHora;
                cadControle.Descricao = RtxtDescricao.Text;

                cadControle.ID_Carro = new CadCarro();
                cadControle.ID_Carro.ID = ID_Carro;

                cadControle.ID_Motorista = new CadMotorista();
                cadControle.ID_Motorista.ID = ID_Motorista;

                cadastroControle.CadastrarCadControleSaida(cadControle);
                RtxtDescricao.Clear();
                GridListaControle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnChegou_Click(object sender, EventArgs e)
        {
            atualizarControle = new AtualizarCadControle();
            cadControle = new CadControle();
            try
            {
                cadControle.ID = ID_Controle;
                cadControle.Chegada = dataHora;
                atualizarControle.AtualizarControle(cadControle);
                GridListaControle();
                BtnExcluir.Enabled = false;
                BtnChegou.Enabled = false;
                BtnSaiu.Enabled = true;
                RtxtDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            excluirControle = new ExcluirCadControle();
            try
            {
                excluirControle.ExcluirControle(ID_Controle);
                GridListaControle();
                BtnExcluir.Enabled = false;
                BtnChegou.Enabled = false;
                BtnSaiu.Enabled = true;
                RtxtDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DgvListaSaidaChegada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID_Controle = int.Parse(DgvListaSaidaChegada.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                BtnExcluir.Enabled = true;
                BtnChegou.Enabled = true;
                BtnSaiu.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dataHora = DateTime.Now;
            LblDataHora.Text = "Data e Hora: " + dataHora;
        }

        private void CbxMarcaModeloCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaIdCarro = new ConsultaIDCarro();
            ID_Carro = consultaIdCarro.IDCarro(CbxMarcaModeloCarro.Text.Trim());
        }
    }
}
