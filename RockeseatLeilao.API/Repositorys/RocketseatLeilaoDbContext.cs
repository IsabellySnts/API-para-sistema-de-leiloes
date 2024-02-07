using Microsoft.EntityFrameworkCore;
using RockeseatLeilao.API.Entity;
using System.Security.Cryptography.X509Certificates;

namespace RockeseatLeilao.API.Repositorys;

public class RocketseatLeilaoDbContext : DbContext
{
    //conectando com a tabela do banco de dados
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //informando o caminho do banco de dados
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\Isabelly\\Downloads\\leilaoDbNLW.db ");
    }
}
