using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pergunta03 : ContentPage
    {
       
        public Pergunta03()
        {
            InitializeComponent();
        }

        public async void btnProximo_Clicked(object sender, EventArgs e)
        {
            if(rdbopcao2.IsChecked)
            {
                MainPage.pontuacao++;
            }

            await Navigation.PushAsync(new Resultado());
        }
    }
}