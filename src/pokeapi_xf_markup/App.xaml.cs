using pokeapi_xf_markup.Services;
using pokeapi_xf_markup.Views;
using Xamarin.Forms;

namespace pokeapi_xf_markup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            DependencyService.Register<PokeDao>();

            Device.SetFlags(new string[] { "Markup_Experimental" });

            MainPage = new NavigationPage(new PokemonListPage() );
        }
    }
}
