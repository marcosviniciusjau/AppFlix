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
    public partial class Vef : ContentPage
    {
        public Vef()
        {
            InitializeComponent();

            btnVef1.Source = ImageSource.FromResource("AppFlix07042021.Posters.vef1.jpg");
            btnVef2.Source = ImageSource.FromResource("AppFlix07042021.Posters.vef2.jpg");
            btnVef3.Source = ImageSource.FromResource("AppFlix07042021.Posters.vef3.jpg");
            btnVef4.Source = ImageSource.FromResource("AppFlix07042021.Posters.vef4.jpg");
            btnVef5.Source = ImageSource.FromResource("AppFlix07042021.Posters.vef5.jpg");
            btnVef6.Source = ImageSource.FromResource("AppFlix07042021.Posters.vef6.jpg");
            btnVef7.Source = ImageSource.FromResource("AppFlix07042021.Posters.vef7.jpg");
            btnVef9.Source = ImageSource.FromResource("AppFlix07042021.Posters.vef9.jpg");
            HtmlWebViewSource html_externo = new HtmlWebViewSource();
            html_externo.Html = @"<iframe 
                                       width='520' 
                                        height='405'  
                                        src='https://www.youtube.com/embed/KvSlvtPnZTo' 
                                        title='YouTube video player' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; clipboard-black; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen>
                                    </iframe>";
            NavigationPage.SetHasNavigationBar(this, false);
            video.Source = html_externo;



            lbl_sinopse.Text = "Depois que Brian e Mia se aposentaram, e o resto da equipe "
                + "foi exonerado, Dom e Letty estão em lua de mel e levam uma vida pacata e "
                + "completamente normal.";
        }
    }
}