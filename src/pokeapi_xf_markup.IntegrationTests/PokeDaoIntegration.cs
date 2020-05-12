using System.Threading.Tasks;
using pokeapi_xf_markup.Services;
using Xunit;

namespace pokeapi_xf_markup.TestsIntegration
{
    public class PokeDaoIntegration
    {
        IPokeService pokeDao;

        [Fact]
        public async Task GetFirst150Pokemons()
        {
            pokeDao ??= new PokeDao();
            var pokemons = await pokeDao.Pokemons(0, 150);
            Assert.Equal(150, pokemons.Results.Count);
        }
        [Fact]
        public async Task GetPokemonByName()
        {
            pokeDao ??= new PokeDao();
            var charmander = await pokeDao.Pokemon("charmander");
            Assert.Equal("charmander", charmander.Name);
        }
        [Fact]
        public async Task GetPokemonById()
        {
            pokeDao ??= new PokeDao();
            var bulbasauro = await pokeDao.Pokemon(1);
            Assert.Equal(1, bulbasauro.Id);
        }
    }
}
