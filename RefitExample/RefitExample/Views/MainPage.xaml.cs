using RefitExample.Models;
using RefitExample.Service;
using RefitExample.ViewModels;
using Xamarin.Forms;

namespace RefitExample.Views
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();

        }

        public async void GetPerson() {

            var service = RefitServiceGenerator.GetService();

            Person person = await service.GetPerson();
            
        }
    }
}
