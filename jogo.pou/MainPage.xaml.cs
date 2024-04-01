namespace jogo.pou;

public partial class MainPage : ContentPage
{
	Hamster Ratinho;
	Lobo Lobão;
	Raposa Fox;
	Personagem atual;


	public MainPage()
	{
		InitializeComponent();

		imgpersonagem.source = "hamster.jpg";
		Ratinho = new Hamster();
		Lobão = new Lobo();
		Fox = new Raposa();

		atual = Ratinho;

		imgpersonagem.source = atual.GetNomeDaFoto();
	}
	

}

