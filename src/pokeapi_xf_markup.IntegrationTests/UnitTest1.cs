using System;
using Xunit;
using Refit;
using pokeapi_xf_markup.Services;
using System.Threading.Tasks;

namespace pokeapi_xf_markup.TestsIntegration
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var baseurl = @"https://pokeapi.co/api/v2";

            var pokeservice = RestService.For<IPokeService>(baseurl);
            try
            {
                //var pokemons = await pokeservice.Pokemons(0,150);
                var bulbasauro = await pokeservice.Pokemon(1);
                //var charmander = await pokeservice.Pokemon("charmander");
            }
            catch (Exception error)
            {
                throw;
            }
        }
    }
}
