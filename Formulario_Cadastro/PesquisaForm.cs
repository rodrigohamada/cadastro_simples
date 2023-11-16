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
    public partial class PesquisaForm : Form
    {
        Cadastro cadastro = Cadastro.Instance;
        public PesquisaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = txtPesquisaCPF.Text;
            Pessoa pessoa = cadastro.PesquisarCPF(cpf);

            if (pessoa != null)
            {
                txtPesquisaNome.Text = pessoa.getNome();
                txtPesquisaIdade.Text = pessoa.getIdade().ToString();
                txtPesquisa.Text = pessoa.getCpf();
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
