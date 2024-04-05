namespace jogo.pou;

public partial class MainPage : ContentPage
{
	hamster Ratinho;
	lobo Lobão;
	raposa Fox;
	Personagem atual;


	public MainPage()
	{
		InitializeComponent();

		imgpersonagem.Source = "hamster.jpg";
		Ratinho = new hamster();
		Lobão = new lobo();
		Fox = new raposa();

		atual = Ratinho;

 		sede.Progress=0.5;
		Fome.Progress=0.3;
		energia.Progress=05;
		imgpersonagem.Source = atual.GetNomeDaFoto();
	}
	

}

