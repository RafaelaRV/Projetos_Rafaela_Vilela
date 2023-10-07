using Adicionar_Funcionário;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPim
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnAdcFunc_Click(object sender, EventArgs e)
        {
            frmAdicionarFuncionario frmAdicionarFuncionario = new frmAdicionarFuncionario();
            frmAdicionarFuncionario.Show();
            this.Hide();
        }

        private void btnCadDependente_Click(object sender, EventArgs e)
        {
            frmCadastroDependentes frmCadastroDependentes = new frmCadastroDependentes();
            frmCadastroDependentes.Show();
            this.Hide();
        }

        private void btnCadCargo_Click(object sender, EventArgs e)
        {
            FrmCadCargo frmCadCargo = new FrmCadCargo();
            frmCadCargo.Show();
            this.Hide();
        }

        private void btnListFunc_Click(object sender, EventArgs e)
        {
            FrmListadeFuncionarios frmListadeFuncionarios = new FrmListadeFuncionarios();
            frmListadeFuncionarios.Show();
            this.Hide();
        }

        private void btnListEdnderco_Click(object sender, EventArgs e)
        {
            FrmLista_de_Endereço frmLista_De_Endereço = new FrmLista_de_Endereço();
            frmLista_De_Endereço.Show();
            this.Hide();
        }

        private void btnListDependente_Click(object sender, EventArgs e)
        {
            frmListaDependentes frmListaDependentes = new frmListaDependentes();
            frmListaDependentes.Show();
            this.Hide();
        }

        private void btnCargContas_Click(object sender, EventArgs e)
        {
            frmCargosContas frmCargosContas = new frmCargosContas();
            frmCargosContas.Show();
            this.Hide();
        }

        private void btnApagarFunc_Click(object sender, EventArgs e)
        {
            frmApagarFuncionario frmApagarFuncionario = new frmApagarFuncionario();
            frmApagarFuncionario.Show();
            this.Hide();
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            frmEditarFuncionario frmEditarFuncionario = new frmEditarFuncionario();
            frmEditarFuncionario.Show();
            this.Hide();
        }

        private void btnEditDependentes_Click(object sender, EventArgs e)
        {
            frmEditarDependentes frmEditarDependentes = new frmEditarDependentes();
            frmEditarDependentes.Show();
        }

        private void btnCadSenha_Click(object sender, EventArgs e)
        {
            frmCadSenha frmCadSenha = new frmCadSenha();
            frmCadSenha.Show();
            this.Hide();
        }

        private void btnDadosFunc_Click(object sender, EventArgs e)
        {
            frmDadosFuncionario frmDadosFuncionario = new frmDadosFuncionario();
            frmDadosFuncionario.Show();
            this.Hide();
        }
    }
}
