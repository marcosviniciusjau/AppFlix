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
    public partial class PanteraNegra : ContentPage
    {
        public PanteraNegra()
        {
            InitializeComponent();
          
            HtmlWebViewSource html_externo = new HtmlWebViewSource();
            html_externo.Html = @"<iframe 
                                        width='650' 
                                        height='105' 
                                        src='https://www.youtube.com/embed/wL4a4MafSjQ'
                                        title ='YouTube video player' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen>
                                    </iframe>";
            NavigationPage.SetHasNavigationBar(this, false);
            video.Source = html_externo;



            lbl_sinopse.Text = "Conheça a história de T'Challa, príncipe do reino de Wakanda,"
                + "que perde o seu pai e viaja para os Estados Unidos, onde tem contato com os Vingadores."
                + "Em 1992, o Rei de Wakanda, T'Chaka visita seu irmão N' Jobu em Oakland, na Califórnia. T'Chaka acusa N'Jobu de auxiliar o traficante de armas Ulysses Klaw a roubar vibranium do reino wakandano. O parceiro de N'Jobu revela que ele é um espião wakandano disfarçado chamado Zuri, e confirma as suspeitas de T'Chaka"
                + "Depois dos eventos de Capitão América: Guerra Civil, após a morte de T'Chaka, seu filho T'Challa retorna a Wakanda para assumir o trono.";
        }
    }
}