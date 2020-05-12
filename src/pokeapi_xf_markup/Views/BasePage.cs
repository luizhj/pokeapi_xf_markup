using System.ComponentModel;
using pokeapi_xf_markup.ViewModels;
using Xamarin.Forms;

namespace pokeapi_xf_markup.Views
{
    public class BasePage : ContentPage
    {
        BaseViewModel ViewModel => BindingContext as BaseViewModel;

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel == null)
            {
                return;
            }

            Title = ViewModel.Title;
            ViewModel.PropertyChanged += TitlePropertyChanged;

            await ViewModel.LoadAsync();
        }
        protected override async void OnDisappearing()
        {
            base.OnDisappearing();

            if (ViewModel == null)
            {
                return;
            }

            Title = ViewModel.Title;
            ViewModel.PropertyChanged -= TitlePropertyChanged;

            await ViewModel.UnLoadAsync();
        }
        void TitlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != nameof(ViewModel.Title))
            {
                return;
            }

            Title = ViewModel.Title;
        }
    }
}
