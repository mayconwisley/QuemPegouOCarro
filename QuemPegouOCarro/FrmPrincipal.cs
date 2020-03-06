using System;
using System.Windows.Forms;

namespace QuemPegouOCarro
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private FrmCadCarro cadCarro;
        private FrmCadControle cadConstrole;
        private FrmCadMotorista cadMotorista;
        private FrmCadVencCarro cadVencCarro;
        private FrmCadVencMotorista cadVencMotorista;
        private FrmConsultaControle consultaControle;
        private FrmRelVencimento relVencimento;
        private FrmRelControle relControle;

        bool abrir = true;

        private void SubMenuCadastrarCarro_Click(object sender, EventArgs e)
        {
            cadCarro = new FrmCadCarro();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmCadCarro)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                cadCarro.Show();
            }
        }

        private void SubMenuCadastrarMotorista_Click(object sender, EventArgs e)
        {
            cadMotorista = new FrmCadMotorista();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmCadMotorista)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                cadMotorista.Show();
            }
        }

        private void SubMenuVencimentoCarro_Click(object sender, EventArgs e)
        {
            cadVencCarro = new FrmCadVencCarro();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmCadVencCarro)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                cadVencCarro.Show();
            }

        }

        private void SubMenuVencimentoMotorista_Click(object sender, EventArgs e)
        {
            cadVencMotorista = new FrmCadVencMotorista();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmCadVencMotorista)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                cadVencMotorista.Show();
            }
        }

        private void SubMenuControleSaidaChegada_Click(object sender, EventArgs e)
        {
            cadConstrole = new FrmCadControle();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmCadControle)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                cadConstrole.Show();
            }
        }

        private void SubMenuConsultarSaidaChegada_Click(object sender, EventArgs e)
        {
            consultaControle = new FrmConsultaControle();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmConsultaControle)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                consultaControle.Show();
            }

        }

        private void SubMenuRelatorioVencimento_Click(object sender, EventArgs e)
        {
            relVencimento = new FrmRelVencimento();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmRelVencimento)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                relVencimento.Show();
            }
        }

        private void SubMenuRelatorioControle_Click(object sender, EventArgs e)
        {
            relControle = new FrmRelControle();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmRelControle)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                relControle.Show();
            }
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnQuemPegouOCarro_Click(object sender, EventArgs e)
        {
            SubMenuControleSaidaChegada_Click(e, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblDataHora.Text = DateTime.Now.ToString();
        }
    }
}
