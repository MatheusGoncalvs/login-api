using System;
using System.Threading.Tasks;

namespace Login.Domain.Interfaces
{
    public interface IPessoaRepository
    {
         Task<Pessoa> ObterPessoaPorUsuarioESenha(string email, string senha);
    }
}