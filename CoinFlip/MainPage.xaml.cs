namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public bool Cara { get; private set; }
        public bool Coroa { get; private set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }


            //Algoritmo
            //Verificar qual opção está selecionada. (if alguma coisa)
            //Fazer o sorteio da moeda (Random)
            //Exibir o lado que foi sorteado (Alterar a propriedade)
            //Verificar se a opção é igual ao lado escolhido (if)
            //Exibir o resultado do jogo em um alerta (DisplayAlert)

            private void Girar_Clicked(object sender, EventArgs e)
            {
            //Algoritmo
            //Verificar qual opção está selecionada. (if alguma coisa)
            //Fazer o sorteio da moeda (Random)
            //Exibir o lado que foi sorteado (Alterar a propriedade)
            //Verificar se a opção é igual ao lado escolhido (if)
            //Exibir o resultado do jogo em um alerta (DisplayAlert)


            // Verifica qual opção está selecionada
            string escolhaUsuario = "";
            if (Cara)
            {
                escolhaUsuario = "Cara";
            }
            else if (Coroa)
            {
                escolhaUsuario = "Coroa";
            }
            else
            {
                DisplayAlert("Atenção", "Selecione Cara ou Coroa antes de girar.", "OK");
                return;
            }

            // Sorteia o lado da moeda
            Random random = new Random();
            string resultado = random.Next(2) == 0 ? "" : "Coroa";

            // Atualiza a imagem (opcional - você precisa ter as imagens no seu projeto)
            coroa.Source = resultado == "Cara" ? "cara.webp" : "coroa.png";

            // Verifica se o usuário acertou
            if (escolhaUsuario == resultado)
            {
                DisplayAlert("Resultado", $"Deu {resultado}! Você acertou!", "OK");
            }
            else
            {
                DisplayAlert("Resultado", $"Deu {resultado}! Você errou!", "OK");
            }
            
            }

    }
}


