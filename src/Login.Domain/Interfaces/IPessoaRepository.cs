using System;
using System.Threading.Tasks;

namespace Login.Domain.Interfaces
{
    public interface IPessoaRepository
    {
         Task<Guid> ObterIdPorUsuarioESenha(string email, string senha);
    }
}