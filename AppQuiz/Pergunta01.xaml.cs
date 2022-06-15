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
    public partial class Pergunta01 : ContentPage
    {

        

        public Pergunta01()
        {
            InitializeComponent();
        }

        public async void btnProximo_Clicked(object sender, EventArgs e)
        {

            if (rdbopcao1.IsChecked)
            {
                MainPage.pontuacao++;
            }

            await Navigation.PushAsync(new Pergunta02());

        }
    }
}