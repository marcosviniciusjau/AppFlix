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

    
     
    }
}