using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("AppFlix.Imagens.videomais.png");
            Escolha1.Source = ImageSource.FromResource("AppFlix.Imagens.Escolha1.png");
            Escolha2.Source = ImageSource.FromResource("AppFlix.Imagens.Escolha2.png");
            Escolha3.Source = ImageSource.FromResource("AppFlix.Imagens.Escolha3.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Escolha1_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new TelaInicial());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }


        }

        private void Escolha2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new TelaInicial());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }

        private void Escolha3_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new TelaInicial());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }
    }
}