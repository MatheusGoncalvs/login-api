using System;
using System.Threading.Tasks;
using Login.Domain;
using Login.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Login.Data.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly PessoaContext _pessoaContext;

        public PessoaRepository(PessoaContext pessoaContext)
        {
            this._pessoaContext = pessoaContext;
        }
        public async Task<Pessoa> ObterPessoaPorUsuarioESenha(string email, string senha)
        {
            var pessoa = await _pessoaContext.Pessoas.FirstOrDefaultAsync(p => p.Email == email && p.Senha == senha);

            return pessoa;
        }
    }
}