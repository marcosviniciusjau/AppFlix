using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
            destaque.Source = ImageSource.FromResource("AppFlix.Categorias.Aventura.png");
            btnCapitaMarvel.Source = ImageSource.FromResource("AppFlix.Posters.capitamarvel.jpg");
            btnPanteraNegra2.Source = ImageSource.FromResource("AppFlix.Posters.panteranegra2.jpg");
            btnDumbo.Source = ImageSource.FromResource("AppFlix.Posters.dumbo.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("AppFlix.Posters.panteranegra.jpg");
       
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnCapitaMarvel_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.CapitaMarvel());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }

        private void btnPanteraNegra_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new Filmes.PanteraNegra());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }

         

        private void btnDumbo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Dumbo());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }

    
        private void btnPanteraNegra2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.PanteraNegra2());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }
    }
}