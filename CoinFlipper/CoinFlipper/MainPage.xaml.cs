using System.Runtime.CompilerServices;

namespace CoinFlipper
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void spin_Clicked(object sender, EventArgs e)
        {
            string girar = Convert.ToString(picker.SelectedItem);
            int sorteio = new Random().Next(2);
            if (sorteio == 0)
            {
                CoinImage.Source = "cara.png";
                if (girar == "cara"){
                    Result.Text = "Você acertou o resultado";
                }
                else
                {
                    Result.Text = "Você errou o resultado";
                }
            } else
            {
                CoinImage.Source = "coroa.png";
                if (girar == "coroa")
                {
                    Result.Text = "Você acertou o resultado";
                }
                else
                {
                    Result.Text = "Você errou o resultado";
                }
            }
           
        }
    }

}
