using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persistence;
//: nome da classe herda tudo que o metodo pode fazer
public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> opcoes):base(opcoes)
    {
        
    }
    public DbSet<Person> Pessoas { get; set; }
    public DbSet<Contract> Contratos { get; set; }
    protected override void OnModelCreating(ModelBuilder builder){
     builder.Entity<Person>(criracaoTabela =>{
         criracaoTabela.HasKey(campoTabela => campoTabela.id);
         criracaoTabela
         .HasMany(campoTabela => campoTabela.contratosAtivos)
         .WithOne()
         .HasForeignKey(criracaoTabela=> criracaoTabela.pessoaId);
     });
      builder.Entity<Contract>(criracaoTabela =>{
          criracaoTabela.HasKey(campoTabela => campoTabela.id);
     });
    }
}