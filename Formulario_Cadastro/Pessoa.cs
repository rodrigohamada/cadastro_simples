using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Cadastro
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;

        public Pessoa(string nome, int idade, string cpf)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public string getCpf()
        {
            return this.cpf;
        }
    }
}
