using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Cadastros;
using Comandos.Cadastro;
using Comandos.Consulta;
using Comandos.Atualizacao;
using Comandos.Exclusao;

namespace QuemPegouOCarro
{
    public partial class FrmCadMotorista : Form
    {
        public FrmCadMotorista()
        {
            InitializeComponent();
        }

        private CadMotorista cadMotorista;
        private InserirMotorista inserirMotorista;
        private ConsultaMotorista consultaMotorista;
        private AtualizarCadMotorista atualizarMotorista;
        private ExcluirCadMotorista excluirMotorista;
        private int ID_Motorista;

        private void GridListaMotorista()
        {
            consultaMotorista = new ConsultaMotorista();
            try
            {
                DgvListaMotorista.DataSource = consultaMotorista.ListaCadMotorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void LimparCampos()
        {
            TxtMotorista.Clear();
            TxtCNH.Clear();
            TxtRG.Clear();
            MktCPF.Clear();
            MktVencimentoCNH.Clear();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            cadMotorista = new CadMotorista();
            inserirMotorista = new InserirMotorista();

            try
            {
                cadMotorista.Nome = TxtMotorista.Text.Trim();
                cadMotorista.CNH = TxtCNH.Text.Trim();
                cadMotorista.VencimentoCNH = DateTime.Parse(MktVencimentoCNH.Text.Trim());
                cadMotorista.CPF = MktCPF.Text.Trim().Replace(".", "").Replace("-", "");
                cadMotorista.RG = TxtRG.Text.Trim();

                inserirMotorista.CadastrarMotorista(cadMotorista);
                LimparCampos();
                GridListaMotorista();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void FrmCadMotorista_Load(object sender, EventArgs e)
        {
            GridListaMotorista();
        }

        private void DgvListaMotorista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID_Motorista = int.Parse(DgvListaMotorista.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                TxtMotorista.Text = DgvListaMotorista.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                TxtCNH.Text = DgvListaMotorista.Rows[e.RowIndex].Cells["CNH"].Value.ToString();
                TxtRG.Text = DgvListaMotorista.Rows[e.RowIndex].Cells["RG"].Value.ToString();
                MktCPF.Text = DgvListaMotorista.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                MktVencimentoCNH.Text = DgvListaMotorista.Rows[e.RowIndex].Cells["VencimentoCNH"].Value.ToString();
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
            cadMotorista = new CadMotorista();
            atualizarMotorista = new AtualizarCadMotorista();

            try
            {
                cadMotorista.ID = ID_Motorista;
                cadMotorista.Nome = TxtMotorista.Text.Trim();
                cadMotorista.CNH = TxtCNH.Text.Trim();
                cadMotorista.VencimentoCNH = DateTime.Parse(MktVencimentoCNH.Text.Trim());
                cadMotorista.CPF = MktCPF.Text.Trim().Replace(".", "").Replace("-", "");
                cadMotorista.RG = TxtRG.Text.Trim();

                atualizarMotorista.AtualizarMotorista(cadMotorista);
                LimparCampos();
                GridListaMotorista();
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
            excluirMotorista = new ExcluirCadMotorista();
            try
            {
                if (MessageBox.Show("A exclusão do motorista irá excluir os dados de controle e vencimentos.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    excluirMotorista.ExcluirMotorista(ID_Motorista);
                    LimparCampos();
                    GridListaMotorista();
                    BtnSalvar.Enabled = true;
                    BtnExcluir.Enabled = false;
                    BtnAlterar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
