namespace Peixera_Virtual;

public class Tauro: Animals_peixera
{
    private int Temps_Vida = 75;
    public Tauro(int x, int y, Sexes h, int tempsVida) : base(x, y, h)
    {
        Temps_Vida = tempsVida;
    }
}