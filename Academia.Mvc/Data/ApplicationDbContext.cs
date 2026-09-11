using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Academia.Mvc.Models
namespace Academia.Mvc.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) :base(Options) {}

    public DbSet<Aluno> Alunos { get; set; }
    public Dbset<Profissional> Profissionais {get; set;}
    public Dbset<Plano> Planos {get;set;}
    public Dbset<Matricula> Matriculas {get; set;}
    public Dbset<AvaliacaoFisica> AvaliacoesFisicas {get; set;}
    public Dbset<Aula> Aulas {get; set;}
    public Dbsett<Inscricao> Inscricoes {get; set;}
    public Dbset<Produto> Produtos {get; set;}
}
