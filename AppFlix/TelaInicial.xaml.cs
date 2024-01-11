using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFlix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
            destaque.Source = ImageSource.FromResource("AppFlix.Posters.batman.jpg");
           
            Home.Source = ImageSource.FromResource("AppFlix.Imagens.home.png");
            Buscar.Source = ImageSource.FromResource("AppFlix.Imagens.buscar.png");
            Download.Source = ImageSource.FromResource("AppFlix.Imagens.download.png");
            btnDumbo.Source = ImageSource.FromResource("AppFlix.Posters.dumbo.jpg");
           
            NavigationPage.SetHasNavigationBar(this, false);
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

      


        private void btnBuscar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Buscar());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");

            }
        }

        private void btnChamadoFloresta_Clicked(object sender, EventArgs e)
        {

        }

        private void btnAventuraFloresta_Clicked(object sender, EventArgs e)
        {

        }

        private void btnReiLeao_Clicked(object sender, EventArgs e)
        {
          
        }

        private void btnFlintstones_Clicked(object sender, EventArgs e)
        {

        }

       

        private void btnHome_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDownload_Clicked(object sender, EventArgs e)
        {

        }

        private void btnSonic_Clicked(object sender, EventArgs e)
        {
        
        }

      }
}
