using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace frontend.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KullaniciArayuz : ContentPage
    {
        public KullaniciArayuz()
        {
            InitializeComponent();
        }
        async void Kasko_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Kasko Sigortalarım", "Geri", null, "Araç Markası: Renault","Araç Kasko Bedeli: 150000 Tl","Kasko Bitiş Tarihi:08.02.2022");
            Debug.WriteLine("Action: " + action);
        }
        async void Trafik_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Trafik Sigortalarım", "Geri", null, "Sigorta Bilgisi Bulunamadı");
            Debug.WriteLine("Action: " + action);
        }
        async void Saglik_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Saglik Sigortalarım", "Geri", null, "Sigorta Bilgisi Bulunamadı");
            Debug.WriteLine("Action: " + action);
        }
        async void Hayat_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Hayat Sigortalarım", "Geri", null, "Sigorta Bilgisi Bulunamadı");
            Debug.WriteLine("Action: " + action);
        }
        async void Bireysel_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Bireysel Sigortalarım", "Geri", null, "Sigorta Bilgisi Bulunamadı");
            Debug.WriteLine("Action: " + action);
        }
        async void Dask_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Dask Sigortalarım", "Geri", null, "Sigorta Bilgisi Bulunamadı");
            Debug.WriteLine("Action: " + action);
        }
        async void Ferdi_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Ferdi Hayat Sigortalarım", "Geri", null, "Sigorta Bilgisi Bulunamadı");
            Debug.WriteLine("Action: " + action);
        }

    }
}