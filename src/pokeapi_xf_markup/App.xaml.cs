using Xamarin.Forms;

namespace pokeapi_xf_markup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new string[] { "Markup_Experimental" });
            MainPage = new MainPage();
        }
    }
}
