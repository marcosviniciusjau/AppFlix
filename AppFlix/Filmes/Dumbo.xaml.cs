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
    public partial class Dumbo : ContentPage
    {
        public Dumbo()
        {
            InitializeComponent();
            HtmlWebViewSource html_externo = new HtmlWebViewSource();
            html_externo.Html = @"<iframe 
                                        width='395' 
                                        height='420' 
                                        src='https://www.youtube.com/embed/jxAq0WZL9t0' 
                                        title='YouTube video player' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; clipboard-black; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen>
                                    </iframe>";
            NavigationPage.SetHasNavigationBar(this, false);
            video.Source = html_externo;



            lbl_sinopse.Text = "Na trama, Holt Farrier é uma ex-estrela de circo que retorna da guerra "
                + "e encontra seu mundo virado de cabeça para baixo. O circo em que trabalhava está "
                + "passando por grandes dificuldades, e ele fica encarregado de cuidar de um elefante "
                + "recém-nascido, cujas orelhas gigantes fazem dele motivo de piada. "
                + "No entanto, os filhos de Holt descobrem que o pequeno elefante é capaz voar!"
                + " A artista aérea Colette Marchant e o empresário VA Vandevere se dirigem para fazer o Dumbo, o elefante voador, uma estrela.";
        }
    }
}