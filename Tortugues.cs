namespace Peixera_Virtual;

public class Tortuga: Animals_peixera
{
    Random R = new Random();
    public Tortuga(int x, int y, Sexes h) : base(x, y, h)
    {
    }

    public override Animals_peixera? HeTrobatUnAltre(Animals_peixera altre)
    {
        if (altre is Tortuga)
        {
            if (Sexe == altre.Sexe)
            {
                Mata();
                altre.Mata();
            }
            else
            {
                int Sexe_Nova_Tortuga = R.Next(1, 2);

                if (Sexe_Nova_Tortuga == 1)
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