using System.Threading.Tasks.Sources;

namespace Peixera_Virtual;

public enum Sexes
{
    Masculi,
    Femeni,
    Pop,
}
public class Animals_peixera
{
    private int X;
    private int Y;
    private int DirX;
    private int DirY;
    Random r = new Random();
    private bool viu = true;
    public Sexes Sexe {get; set;}


    public Animals_peixera(int x, int y, Sexes h)
    {
        X = x;
        Y = y;
        Sexe = h;
        Direccio();
    }
    
    
    public virtual void Direccio()
    {
        int n = r.Next(0, 4);
        switch (n)
        {
            case 0:
                (DirX, DirY) = (-1, 0);
                break;
            case 1:
                (DirX, DirY) = (1, 0);
                break;
            case 2:
                (DirX, DirY) = (0, 1);
                break;
            case 3:
                (DirX, DirY) = (0, -1);
                break;
        }
    }

    public void Mata()
    {
        viu = false;
    }

    public void Mou()
    {
        X = (X + DirX) %20;
        Y = (Y + DirY) %20;
    }
}