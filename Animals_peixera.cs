using System.Threading.Tasks.Sources;

namespace Peixera_Virtual;

public enum Sexes
{
    Masculi,
    Femeni,
    Pop,
}
public abstract class Animals_peixera
{
    protected int X;
    protected int Y;
    protected int DirX;
    protected int DirY;
    Random R = new Random();
    protected bool viu = true;
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
        int n = R.Next(0, 4);
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

    public virtual void Mou()
    {
        X = (X + DirX) %20;
        Y = (Y + DirY) %20;
    }

    public abstract Animals_peixera? HeTrobatUnAltre(Animals_peixera altre);
}