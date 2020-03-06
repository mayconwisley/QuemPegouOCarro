using Comandos.Consulta;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuemPegouOCarro
{
    public partial class FrmConsultaControle : Form
    {
        public FrmConsultaControle()
        {
            InitializeComponent();
        }

        ConsultaCadControle consultaControle;
        ConsultaCarro consultaCarro;
        ConsultaMotorista consultaMotorista;
        ConsultaIDCarro consultaIDCarro;
        ConsultaIDMotorista consultarIDMotorista;
        ConsultaCadControleCarro consultaCadControleCarro;
        ConsultaCadControleMotorista consultaCadControleMotorista;
        ConsultaCadControleData consultaCadControleData;

        int ID_Carro, ID_Motorista;

        private void ListarMarcasModeloCarro()
        {
            try
            {
                consultaCarro = new ConsultaCarro();
                CbxCarro.DataSource = consultaCarro.ListaCadCarro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
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

        private void Geral()
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

                DgvListaControle.DataSource = null;
                DgvListaControle.DataSource = listaControle;
                DgvListaControle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DgvListaControle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvListaControle.Columns["ID"].Visible = false;
                DgvListaControle.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void PorCarro(int ID_Carro)
        {
            consultaCadControleCarro = new ConsultaCadControleCarro();
            try
            {
                var listaControle = consultaCadControleCarro.ListaCadControleCarro(ID_Carro).Select(ListaControle => new
                {
                    ID = ListaControle.ID,
                    Nome = ListaControle.ID_Motorista.Nome,
                    Marca = ListaControle.ID_Carro.Marca,
                    DataHoraSaida = ListaControle.Saida,
                    DataHoraChegada = ListaControle.Chegada,
                    Descricao = ListaControle.Descricao
                }).ToList();

                DgvListaControle.DataSource = null;
                DgvListaControle.DataSource = listaControle;
                DgvListaControle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DgvListaControle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvListaControle.Columns["ID"].Visible = false;
                DgvListaControle.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void PorMotorista(int ID_Motorista)
        {
            consultaCadControleMotorista = new ConsultaCadControleMotorista();
            try
            {
                var listaControle = consultaCadControleMotorista.ListaCadControleMotorista(ID_Motorista).Select(ListaControle => new
                {
                    ID = ListaControle.ID,
                    Nome = ListaControle.ID_Motorista.Nome,
                    Marca = ListaControle.ID_Carro.Marca,
                    DataHoraSaida = ListaControle.Saida,
                    DataHoraChegada = ListaControle.Chegada,
                    Descricao = ListaControle.Descricao
                }).ToList();

                DgvListaControle.DataSource = null;
                DgvListaControle.DataSource = listaControle;
                DgvListaControle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DgvListaControle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvListaControle.Columns["ID"].Visible = false;
                DgvListaControle.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void PorData(DateTime dateTime)
        {
            consultaCadControleData = new ConsultaCadControleData();
            try
            {
                var listaControle = consultaCadControleData.ListaCadControleData(dateTime.Date).Select(ListaControle => new
                {
                    ID = ListaControle.ID,
                    Nome = ListaControle.ID_Motorista.Nome,
                    Marca = ListaControle.ID_Carro.Marca,
                    DataHoraSaida = ListaControle.Saida,
                    DataHoraChegada = ListaControle.Chegada,
                    Descricao = ListaControle.Descricao
                }).ToList();

                DgvListaControle.DataSource = null;
                DgvListaControle.DataSource = listaControle;
                DgvListaControle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DgvListaControle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvListaControle.Columns["ID"].Visible = false;
                DgvListaControle.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void FrmConsultaControle_Load(object sender, EventArgs e)
        {
            Geral();
            ListarMarcasModeloCarro();
            ListarMotorista();
        }

        private void RbGeral_CheckedChanged(object sender, EventArgs e)
        {
            if (RbGeral.Checked)
            {
                CbxCarro.Enabled = false;
                CbxMotorista.Enabled = false;
                DtpData.Enabled = false;
                Geral();
            }
        }

        private void RbPorData_CheckedChanged(object sender, EventArgs e)
        {
            if (RbPorData.Checked)
            {
                CbxCarro.Enabled = false;
                CbxMotorista.Enabled = false;
                DtpData.Enabled = true;
                DtpData_ValueChanged(e, e);
            }
        }

        private void RbPorCarro_CheckedChanged(object sender, EventArgs e)
        {
            if (RbPorCarro.Checked)
            {
                CbxCarro.Enabled = true;
                CbxMotorista.Enabled = false;
                DtpData.Enabled = false;
                CbxCarro_SelectedIndexChanged(e, e);
            }
        }

        private void RbPorMotorista_CheckedChanged(object sender, EventArgs e)
        {
            if (RbPorMotorista.Checked)
            {
                CbxCarro.Enabled = false;
                CbxMotorista.Enabled = true;
                DtpData.Enabled = false;
                CbxMotorista_SelectedIndexChanged(e, e);
            }
        }

        private void CbxMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultarIDMotorista = new ConsultaIDMotorista();

            try
            {
                ID_Motorista = consultarIDMotorista.IDMotorista(CbxMotorista.Text.Trim());
                if (RbPorMotorista.Checked)
                {
                    PorMotorista(ID_Motorista);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DtpData_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (RbPorData.Checked)
                {
                    PorData(DtpData.Value.Date);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void CbxCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaIDCarro = new ConsultaIDCarro();
            consultaCadControleCarro = new ConsultaCadControleCarro();

            try
            {
                ID_Carro = consultaIDCarro.IDCarro(CbxCarro.Text.Trim());
                if (RbPorCarro.Checked)
                {
                    PorCarro(ID_Carro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
    }
}
