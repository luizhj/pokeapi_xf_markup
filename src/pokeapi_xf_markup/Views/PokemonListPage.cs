using FFImageLoading.Forms;
using pokeapi_xf_markup.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace pokeapi_xf_markup.Views
{
    public class PokemonListPage : BasePage
    {
        readonly PokemonListViewModel viewModel = new PokemonListViewModel();

        public PokemonListPage()
        {
            BindingContext = viewModel;
            Content = new Frame
            {
                BackgroundColor = Color.Wheat,
                HasShadow = true,
                Content = new StackLayout
                {
                    Children =
                    {
                        new CachedImage().Bind(CachedImage.SourceProperty,nameof(viewModel.Pokemon.ImageFromt)).Margin(0,0),

                        new Label {} .Font (15) .Bold () .TextCenterHorizontal() 
                        .Bind("viewModel.Pokemon.Name")
                    }
                }.Start()
            };
        }
    }
}