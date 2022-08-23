using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shazam : ContentPage
    {
        public Shazam()
        {
            InitializeComponent();
            HtmlWebViewSource html_externo = new HtmlWebViewSource();
            html_externo.Html = @"<iframe 
                                        width='520' 
                                        height='405' 
                                        src='https://www.youtube.com/embed/Ptq-Xr7ipM8' 
                                        title='YouTube video player' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; clipboard-black; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen>
                                    </iframe>";
            NavigationPage.SetHasNavigationBar(this, false);
            video.Source = html_externo;



            lbl_sinopse.Text = "Billy Batson tem apenas 14 anos de idade, mas recebeu de um antigo mago o dom de se transformar em um super-herói adulto chamado Shazam."
                + " Ao gritar a palavra SHAZAM!, o adolescente se transforma nessa sua poderosa versão adulta para se divertir e testar suas habilidades. "
                + "Contudo, ele precisa aprender a controlar seus poderes para enfrentar o malvado Dr. Thaddeus Sivana.";
        }
    }
}