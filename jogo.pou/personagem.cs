using System.Security.Cryptography.X509Certificates;

namespace jogo.pou;
public class Personagem
{
    public double fome;
    public double sede;
    public double energia;
    public string NomeDaFoto;

    public Personagem()
    {
        fome = 0;
        sede = 0;
        energia = 0;
        NomeDaFoto = "hamster.jpg";
    }
    public string GetNomeDaFoto()
    {
        return NomeDaFoto;
    }
    public void SetFome (double f)
    {
        if (f >= 0 && f <= 1)
        fome = f;
        else if (f > 1)
        fome = 1;
        else if (f > 0)
        fome = 0;
    }
    public void SetSede (double s)
    {
        if (s >= 0 && s <= 1)
        sede = s;
        else if (s > 1)
        sede = 1;
        else if (s > 0)
        sede = 0;
    }

    public void SetEnergia (double e)
    {
        if (e >= 0 && e <= 1)
        energia = e;
        else if (e > 1)
        energia = 1;
        else if (e > 0)
        energia = 0;
    }
    
}