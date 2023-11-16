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
    public partial class CadastroForm : Form
    {
        Cadastro cadastro = Cadastro.Instance;
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string cpf = txtCPF.Text;

            Pessoa pessoa = new Pessoa(nome, idade, cpf);
            cadastro.CadastrarPessoa(pessoa);

            MessageBox.Show("Pessoa cadastrada com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
