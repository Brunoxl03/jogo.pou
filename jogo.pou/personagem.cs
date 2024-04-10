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
        if(f<0)
        fome=0;
        else if(f>1)
        fome=1;
        else
        fome=f;
    }
    public double GetFome()
{    
    return fome;
}

    public void SetSede (double s)
    {
         if(s<0)
        sede=0;
        else if(s>1)
        sede=1;
        else
        sede=s;
        sede=s;
    }
     public double GetSede()
{
    return sede;
}
    public void Setsono (double so)
    {

         if(so<0)
        sono=0;
        else if(so>1)
        sono=1;
        else
        sono=so;
        sono=so;
       
    }
     public double GetSono()
{
    return sono;
}
    
}