using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuiz
{

    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        public static int pontuacao=0;
        public static string nome;

        public void btnIniciar_Clicked(object sender, EventArgs e)
        {
            MainPage.nome = edtNome.Text.ToUpper();
            Navigation.PushAsync(new Pergunta01());
        }

        private void btnFinalizar_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
