using System.Threading.Tasks;
namespace Login.API.Sevices
{
    public interface ILoginAppService
    {
         Task<PessoaViewModel> Login(PessoaViewModel pessoa);
    }
}