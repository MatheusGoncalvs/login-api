using Login.Domain;
using Microsoft.EntityFrameworkCore;

namespace Login.Data
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        { }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}