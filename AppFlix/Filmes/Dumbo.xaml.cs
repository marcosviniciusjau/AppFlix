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
            /*var htmlSource = new HtmlWebViewSource();

          htmlSource.Html = @"<iframe width='560' height='315' 
                               src='https://www.youtube.com/embed/jxAq0WZL9t0' 
                               title='YouTube video player' frameborder='0' allow='accelerometer; 
                               autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                               allowfullscreen></iframe>";

          Visualizador.Source = htmlSource;*/
            logo.Source = ImageSource.FromResource("AppFlix.Imagens.video-plus.png");

            NavigationPage.SetHasNavigationBar(this, false);




            lbl_sinopse.Text = "Na trama, Holt Farrier é uma ex-estrela de circo " 
                +"fica encarregado de cuidar de um elefante recém-nascido," 
                +" cujas orelhas gigantes fazem dele motivo de piada"
                +"No entanto, os filhos dele descobrem que o pequeno "
                + "elefante é capaz voar!"
                ;
        }
    }
}