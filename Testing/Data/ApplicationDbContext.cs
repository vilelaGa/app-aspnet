using Microsofit.EntityFrameworkCore;
using EmprestimoLivros.Models;

namespace Testing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public Dbset<EmprestimosModel> Emprestimos { get; set; }

    }
}