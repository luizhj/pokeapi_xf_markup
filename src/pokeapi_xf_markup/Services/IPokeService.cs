using System.Threading.Tasks;
using pokeapi_xf_markup.Models;
using Refit;

namespace pokeapi_xf_markup.Services
{
    public interface IPokeService
    {
        [Get("/pokemon/?offset={offset}&limit={limit}")]
        Task<PokeResult> Pokemons(int offset = 0, int limit = 20);

        [Get("/pokemon/{name}")]
        Task<Pokemon> Pokemon(string name);

        [Get("/pokemon/{id}")]
        Task<Pokemon> Pokemon(int id);
    }
}
