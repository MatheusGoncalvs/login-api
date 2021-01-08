using Login.Domain;
using System;
using Xunit;

namespace Login.Tests
{
    public class PessoaTest
    {
        [Fact]
        public void IdadeDeveIgualAnoAtualMenosAnoDataNascimento()
        {
            var casoDeTeste = new Pessoa(new DateTime(1992,06,17));

            Assert.Equal(29, casoDeTeste.Idade);
        }
    }
}
