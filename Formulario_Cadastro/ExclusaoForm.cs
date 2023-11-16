﻿using System;
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
    public partial class ExclusaoForm : Form
    {
        Cadastro cadastro = Cadastro.Instance;
        public ExclusaoForm()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txtExclusaoCPF.Text;
            Pessoa pessoa = cadastro.PesquisarCPF(cpf);

            if (pessoa != null)
            {
                txtExclusaoNome.Text = pessoa.getNome();
                txtExclusaoIdade.Text = pessoa.getIdade().ToString();
                txtExclusao.Text = pessoa.getCpf();
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string cpf = txtExclusaoCPF.Text;
            bool removed = cadastro.RemoverPessoa(cpf);

            if (removed)
            {
                MessageBox.Show("Pessoa removida com sucesso!");
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
