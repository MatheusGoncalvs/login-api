using System.Threading.Tasks;
using Login.Domain.Interfaces;
using Login.Infraestruture.Security;

namespace Login.API.Sevices
{
    public class LoginAppService : ILoginAppService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly JwtToken _jwtToken;

        public LoginAppService(IPessoaRepository pessoaRepository, JwtToken jwtToken)
        {
            this._pessoaRepository = pessoaRepository;
            this._jwtToken = jwtToken;
        }
        public async Task<PessoaViewModel> Login(PessoaViewModel pessoa)
        {
            var id = await _pessoaRepository.ObterIdPorUsuarioESenha(pessoa.Email, pessoa.Password);

            pessoa.Token = _jwtToken.GerarTokenJwt(id);

            return pessoa;
        }
    }
}