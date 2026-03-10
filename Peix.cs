namespace Peixera_Virtual;

public class Peix: Animals_peixera
{
    Random R = new Random();
    public Peix(int x, int y, Sexes h) : base(x, y, h)
    {
        
    }

    public override Animals_peixera? HeTrobatUnAltre(Animals_peixera altre)
    {
        if (altre is Tauro)
        {
            Mou();
        } 
        else if (altre is Peix)
        {
            if (Sexe == altre.Sexe)
            {
                Mata();
                altre.Mata();
            }
            else
            {
                int Sexe_Nou_Peix = R.Next(1, 2);

                if (Sexe_Nou_Peix == 1)
                {
                    return new Peix(X, Y, Sexes.Masculi);
                }
                else
                {
                    return new Peix(X, Y, Sexes.Femeni);
                }
            }
        }

        return null;
    }
}