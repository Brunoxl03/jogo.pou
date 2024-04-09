using System.Security.Cryptography.X509Certificates;

namespace jogo.pou;
public class Personagem
{
    public double fome;
    public double sede;
    public double sono;
    public string NomeDaFoto;

    public Personagem()
    {
        fome = 0;
        sede = 0;
        sono = 0;
        NomeDaFoto = "hamster.jpg";
    }
    public string GetNomeDaFoto()
    {
        return NomeDaFoto;
    }
    public void SetFome (double f)
    {
        fome=f;
        if( Fome <= 0)

    }
    public double GetFome()
{
    return Fome;
}

    public void SetSede (double s)
    {
       sede=S;
       if(sede <= 0)
    }
     public double GetSede()
{
    return Sede;
}
    public void Setsono (double e)
    {
        sono=S;
        if(sono <= 0)
       
    }
     public double GetSono()
{
    return Sono;
}
    
}