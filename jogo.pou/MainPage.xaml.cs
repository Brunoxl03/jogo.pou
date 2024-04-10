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
		fome.Progress=atual.GetFome();
		sede.Progress=atual.GetSede();
		sono.Progress=atual.GetSono();
		imgpersonagem.Source = atual.GetNomeDaFoto();
	}
	private void TrocaBixos(object sender, EventArgs args)
	{
	   if(atual == Ratinho)
	   { 
		  atual = Lobão;
	   }
	   else if(atual == Ratinho)
	   { 
		 atual = Lobão;
	   }
	   else 
	   {
		 atual = Fox;
	   }
	   imgpersonagem.Source = atual.GetNomeDaFoto();
	   AtualizaPersonagem();
	}

    private void AtualizaPersonagem()
    {

    }
}

