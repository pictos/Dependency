using Dependency.Services;
using Xamarin.Forms;

namespace Dependency
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

           var valor = await DependencyService.Get<IStorage>().GetFreeSpace();

            await DisplayAlert("Aviso", valor.ToString(), "OK");
        }
    }
}
