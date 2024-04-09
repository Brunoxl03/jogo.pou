namespace jogo.pou;

public partial class MainPage : ContentPage
{
	Hamster Ratinho = new Hamster();
	Lobo Lobão = new Lobo();
	Raposa Fox = new Raposa();
	Personagem atual;


	public MainPage()
	{
		InitializeComponent();

		imgpersonagem.Source = "hamster.jpg";

		atual = Ratinho;

 		ProgressoFome.Progress=atual.GetFome
		imgpersonagem.Source = atual.GetNomeDaFoto();
	}
	

}

