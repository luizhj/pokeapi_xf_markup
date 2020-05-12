using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFImageLoading.Forms;
using pokeapi_xf_markup.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace pokeapi_xf_markup.Views
{
    public class PokemonListPage : ContentPage
    {
        readonly PokemonListViewModel viewModel = new PokemonListViewModel();

        public PokemonListPage()
        {
            BindingContext = viewModel;
            Content = new StackLayout
            {
                Children = {
                    new Frame
                    {
                        BackgroundColor = Color.Wheat,
                        Content = new StackLayout
                        {
                            Children =
                            {
                                new CachedImage
                                {
                                    
                                }.Bind()
                            }
                        }
                        
                    }
                }
            };
        }
    }
}