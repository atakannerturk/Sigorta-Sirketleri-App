using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace frontend.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Giris_Clicked(object sender, EventArgs e)
        {


            await Navigation.PushModalAsync(new KullaniciArayuz());

        }
        void Handle_Toggle(object sender, ToggledEventArgs e)
        {

        }
    }
}