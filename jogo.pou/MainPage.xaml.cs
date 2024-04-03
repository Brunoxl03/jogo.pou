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

 		prog.Progress=0.5;
		imgpersonagem.Source = atual.GetNomeDaFoto();
	}
	

}

