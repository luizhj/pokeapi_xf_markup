using System;
using System.Diagnostics;
using System.Threading.Tasks;
using pokeapi_xf_markup.Models;
using Refit;

namespace pokeapi_xf_markup.Services
{
    public class PokeDao : IPokeService
    {
        readonly string baseurl = @"https://pokeapi.co/api/v2";
        readonly IPokeService pokeService;

        public PokeDao() => pokeService = RestService.For<IPokeService>(baseurl);

        public async Task<Pokemon> Pokemon(string name)
        {
            try
            {
                return await pokeService.Pokemon(name);
            }
            catch (Exception error)
            {
                if (error is ApiException _api)
                {
                    var msg = _api.StatusCode switch
                    {
                        System.Net.HttpStatusCode.BadRequest => "Erro na consulta",
                        System.Net.HttpStatusCode.Forbidden => "Nao permitido",
                        System.Net.HttpStatusCode.InternalServerError => "Erro no servidor",
                        System.Net.HttpStatusCode.MethodNotAllowed => "Nao permitido",
                        System.Net.HttpStatusCode.NotFound => "Nao encontrado",
                        _ => ""
                    };

                    Debug.WriteLine(_api.Message);
                }
                throw;
            }
        }
        public async Task<Pokemon> Pokemon(int id)
        {
            try
            {
                return await pokeService.Pokemon(id);
            }
            catch (Exception error)
            {
                if (error is ApiException _api)
                {
                    Debug.WriteLine(_api.Message);
                }
                throw;
            }
        }
        public async Task<PokeResult> Pokemons(int offset = 0, int limit = 20)
        {
            try
            {
                return await pokeService.Pokemons(offset,limit);
            }
            catch (Exception error)
            {
                if (error is ApiException _api)
                {
                    Debug.WriteLine(_api.Message);
                }
                throw;
            }
        }
    }
}
