using System.Collections.ObjectModel;
using System.Threading.Tasks;
using pokeapi_xf_markup.Models;
using pokeapi_xf_markup.Services;
using Xamarin.Forms;

namespace pokeapi_xf_markup.ViewModels
{
    public class PokemonListViewModel : BaseViewModel
    {

        ObservableCollection<Pokemon> pokemons;
        public ObservableCollection<Pokemon> Pokemons
        {
            get => pokemons;
            set => SetProperty(ref pokemons, value);
        }

        Pokemon pokemon;
        public Pokemon Pokemon
        {
            get => pokemon;
            set => SetProperty(ref pokemon, value);
        }

        IPokeService pokedao;

        public PokemonListViewModel() => pokedao ??= DependencyService.Resolve<IPokeService>();

        public override Task LoadAsync() => Load();

        async Task Load()
        {
            Pokemon = await pokedao.Pokemon(1);

            //var pokes = await pokedao.Pokemons(0, 150);
            //var _pokemons = new ObservableCollection<Pokemon>();
            //foreach (var item in pokes.Results)
            //{
            //    if (await pokedao.Pokemon(item.Name) is Pokemon temp)
            //    {
            //        _pokemons.Add(temp);
            //    }
            //}
        }
    }
}
