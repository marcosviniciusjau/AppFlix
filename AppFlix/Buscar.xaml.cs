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
    public partial class Buscar : ContentPage
    {
        public Buscar()
        {
            InitializeComponent();
            btnAventura.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Aventura.png");
            btnComedia.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Comedia.png");
            btnDrama.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Drama.png");
            btnTerror.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Terror.png");
            btnFiccaoCientifica.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.FiccaoCientifica.png");
            btnSuspense.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Suspense.png");
            btnAnimacao.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Animacao.png");
            btnDocumentario.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Documentario.png");
            btnGuerra.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Guerra.png");
            btnNacional.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Nacional.png");
            btnRomance.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Romance.png");
            btnInfantil.Source = ImageSource.FromResource("AppFlix.ImagensCategorias.Infantil.png");


            NavigationPage.SetHasNavigationBar(this, false);

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }
        private void btnAventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }
    }
}