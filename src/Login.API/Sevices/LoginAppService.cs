using System;
using System.Threading.Tasks;
using AutoMapper;
using Login.Domain.Interfaces;
using Login.Infraestruture.Security;

namespace Login.API.Sevices
{
    public class LoginAppService : ILoginAppService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly JwtToken _jwtToken;
        private readonly IMapper _mapper;

        public LoginAppService(IPessoaRepository pessoaRepository, JwtToken jwtToken, IMapper mapper)
        {
            this._pessoaRepository = pessoaRepository;
            this._jwtToken = jwtToken;
            this._mapper = mapper;
        }
        public async Task<PessoaViewModel> Login(PessoaViewModel pessoaViewModel)
        {
            var Pessoa = await _pessoaRepository.ObterPessoaPorUsuarioESenha(pessoaViewModel.Email, pessoaViewModel.Password);

            var PessoaViewModel = _mapper.Map<PessoaViewModel>(Pessoa);

            PessoaViewModel.Token = _jwtToken.GerarTokenJwt(Guid.Parse(Pessoa.UserId));

            return PessoaViewModel;
        }
    }
}