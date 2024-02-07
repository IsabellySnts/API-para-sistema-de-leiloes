using Microsoft.EntityFrameworkCore;
using RockeseatLeilao.API.Entity;
using RockeseatLeilao.API.Repositorys;

namespace RockeseatLeilao.API.UseCases.Leiloes.GetCurrent;

public class GetCurrentLeilaoUseCase
{
    public Auction ExecuteCase()
    {
        var repository = new RocketseatLeilaoDbContext();

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .First();
    }
}
