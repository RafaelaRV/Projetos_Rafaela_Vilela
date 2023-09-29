using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDPessoas_1._0.Modelo;

namespace CRUDPessoas_1._0.Apresentacao
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<String> listaDadosPessoa = new List<string>();
            listaDadosPessoa.Add(txbNome.Text);
            listaDadosPessoa.Add(txbRG.Text);
            listaDadosPessoa.Add(txbCPF.Text);
            Controle controle = new Controle();
            controle.cadastrarPessoa(listaDadosPessoa);
            MessageBox.Show(controle.mensagem);
        }
    }
}
