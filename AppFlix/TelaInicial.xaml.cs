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
            logo.Source = ImageSource.FromResource("AppFlix.Imagens.video-plus.png") ;
            destaque.Source = ImageSource.FromResource("AppFlix.Posters.batman.jpg");
           
            Home.Source = ImageSource.FromResource("AppFlix.Imagens.home.png");
            Buscar.Source = ImageSource.FromResource("AppFlix.Imagens.buscar.png");
            Download.Source = ImageSource.FromResource("AppFlix.Imagens.download.png");
            btnCapitaMarvel.Source = ImageSource.FromResource("AppFlix.Posters.capitamarvel.jpg");
            //btnReiLeao.Source = ImageSource.FromResource("AppFlix.Posters.reileao.jpeg");
            //btnIndianaJones.Source = ImageSource.FromResource("AppFlix.Posters.indianajones.jpg");
            btnPanteraNegra2.Source = ImageSource.FromResource("AppFlix.Posters.panteranegra2.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("AppFlix.Posters.panteranegra.jpg");
            btnShazan.Source = ImageSource.FromResource("AppFlix.Posters.shazam.jpg");
            btnDumbo.Source = ImageSource.FromResource("AppFlix.Posters.dumbo.jpg");
            btnProjetoAdam.Source = ImageSource.FromResource("AppFlix.Posters.projetoadam.jpg");
            //btnAventuraFloresta.Source = ImageSource.FromResource("AppFlix.Posters.aventurafloresta.jpeg");
            //btnChamadoFloresta.Source = ImageSource.FromResource("AppFlix.Posters.chamadofloresta.jpg");
           // btnSonic.Source = ImageSource.FromResource("AppFlix.Posters.sonic.jpg");
            //btnFlintstones.Source = ImageSource.FromResource("AppFlix.Posters.flintstones.jpeg");

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

        private void btnShazam_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Shazam());
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

        private void btnVef_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Vef());
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

        private void btnIndianaJones_Clicked(object sender, EventArgs e)
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

        private void btnProjetoAdam_Clicked(object sender, EventArgs e)
        {
         
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
