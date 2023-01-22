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
    public partial class PanteraNegra2 : ContentPage
    {
        public PanteraNegra2()
        {
            InitializeComponent();
            HtmlWebViewSource html_externo = new HtmlWebViewSource();
            html_externo.Html = @"<iframe 
                                        width='520' 
                                        height='405' 
                                        src='https://www.youtube.com/embed/zJOicbceWlE' 
                                        title='YouTube video player' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; clipboard-black; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen>
                                    </iframe>";
            NavigationPage.SetHasNavigationBar(this, false);
            video.Source = html_externo;



            lbl_sinopse.Text = "Um jovem humilde descobre uma lâmpada mágica, com um gênio que pode lhe conceder desejos. "
                + "Agora o rapaz quer conquistar a moça por quem se apaixonou.";
        }
    }
}