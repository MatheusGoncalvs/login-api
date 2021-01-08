using AutoMapper;
using Login.Domain;

namespace Login.API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Pessoa, PessoaViewModel>();
        }
    }
}