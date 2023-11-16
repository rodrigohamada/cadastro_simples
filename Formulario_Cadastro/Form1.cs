using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroForm cadastroForm = new CadastroForm();
            cadastroForm.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            PesquisaForm pesquisaForm = new PesquisaForm();
            pesquisaForm.Show();
        }

        private void btnExclusao_Click(object sender, EventArgs e)
        {
            ExclusaoForm exclusaoForm = new ExclusaoForm();
            exclusaoForm.Show();
        }
    }
}
