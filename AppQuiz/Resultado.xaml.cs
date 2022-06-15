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
    public partial class Resultado : ContentPage
    {

        public Resultado()
        {
            InitializeComponent();

            if (MainPage.pontuacao < 3)
            {
                lblNome.Text = "Não foi dessa vez, " + MainPage.nome + ", você acertou " + MainPage.pontuacao + " pergunta(s).";
            }
            else
            {
                lblNome.Text = "PARABÉNS, " + MainPage.nome + ", VOCÊ ACERTOU TODAS AS PERGUNTAS.";
            }

            lblResultado.Text = MainPage.pontuacao.ToString();

        }

        private void btnFinalizar_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}