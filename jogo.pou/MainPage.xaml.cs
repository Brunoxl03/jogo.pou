using Microsoft.Maui.Controls;

namespace jogo.pou;

public partial class MainPage : ContentPage
{
	Personagem atual;
	Hamster Ratinho = new Hamster();
	Lobo Lobão = new Lobo();
	Raposa Fox = new Raposa();


	public MainPage()
	{
		InitializeComponent();

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

	   var timer = Application.Current.Dispatcher.CreateTimer();
	   timer.Interval = TimeSpan.FromSeconds(1);
	   timer.Tick += (s,e)=>
	   PassouTempo();
	   timer.Start();
	}

	void PassouTempo()
	{
		atual.Setsono(atual.GetSono() - 0.01);
		AtualizaPersonagem();
		atual.SetFome(atual.GetFome() - 0.01);
		AtualizaPersonagem();
		atual.SetSede(atual.GetSede() - 0.01);
	}

    void AtualizaPersonagem()
    {
		Progressofome.progress = atual.GetFome();
		Progressosono.progress = atual.GetSono();
		progressosede.progress = atual.GetSede();

    }

	  private void ProgressoTristeza(object sender, EventArgs args)
   	{
      	atual.SetSede(atual.GetSede() + 0.01);
		AtualizaPersonagem();
   	}
   private void ProgressoFome(object sender, EventArgs args)
   	{
      	atual.SetFome(atual.GetFome() + 0.01);
		AtualizaPersonagem();
   	}
   private void ProgressoConfusao(object sender, EventArgs args)
   	{
      	atual.Setsono(atual.GetSono() + 0.01);
		AtualizaPersonagem();
   	}
}

