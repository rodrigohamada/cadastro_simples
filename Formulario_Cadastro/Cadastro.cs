using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Cadastro
{
    public class Cadastro
    {
        private static Cadastro instance;
        private List<Pessoa> listaPessoas;

        private Cadastro()
        {
            this.listaPessoas = new List<Pessoa>();
        }

        public static Cadastro Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Cadastro();
                }
                return instance;
            }
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            this.listaPessoas.Add(pessoa);
        }

        public Pessoa PesquisarCPF(string cpf)
        {
            foreach (Pessoa pessoa in this.listaPessoas)
            {
                if (pessoa.getCpf() == cpf)
                {
                    return pessoa;
                }
            }
            return null;
        }

        public bool RemoverPessoa(string cpf)
        {
            Pessoa pessoa = this.PesquisarCPF(cpf);
            if (pessoa != null)
            {
                this.listaPessoas.Remove(pessoa);
                return true;
            }
            return false;
        }
    }
}
