using System.Runtime.InteropServices.Marshalling;

namespace Peixera_Virtual;

public class Tauro: Animals_peixera
{
    private int Temps_Vida = 75;
    private int Rondes_Actuals = 0;
    Random R = new Random();
    
    public Tauro(int x, int y, Sexes h, int tempsVida) : base(x, y, h)
    {
        Temps_Vida = tempsVida;
    }

    public override void Mou()
    {
        if (Rondes_Actuals > Temps_Vida)
        {
            Mata();
        }
        else
        {
            base.Mou();
            Rondes_Actuals++;
        }
       
    }

    public override Animals_peixera? HeTrobatUnAltre(Animals_peixera altre)
    {
        if (altre is Tortuga)
        {
            Direccio(); //Has dit que així serveix, que si toca la mateixa direcció, mala sort.
        } 
        else if (altre is Tauro)
        {
            if (Sexe == altre.Sexe)
            {
                Mata();
                altre.Mata();
            }
            else
            {
                int Sexe_Nou_Tauro = R.Next(1, 2);

                if (Sexe_Nou_Tauro == 1)
                {
                    return new Peix(X, Y, Sexes.Masculi);
                }
                else
                {
                    return new Peix(X, Y, Sexes.Femeni);
                }
            }
        }
        else
        {
            altre.Mata();
        }

        return null;
    }
}
