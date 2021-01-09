using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login.Domain
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string UserId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        [NotMapped]
        public int Idade { get; private set; }
        [NotMapped]
        public DateTime DataNascimento { get; private set; }

        public Pessoa() 
        { 
        }
        public Pessoa(DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;

            CalcularIdade();
        }

        public void CalcularIdade()
        {
            this.Idade = DateTime.Now.Year - this.DataNascimento.Year;
        }
    }
}