namespace Peixera_Virtual;

public class Tortuga : Animals_peixera
{
    Random R = new Random();

    public Tortuga(int x, int y, Sexes h) : base(x, y, h)
    {

    }

    public override Animals_peixera? HeTrobatUnAltre(Animals_peixera altre)
    {
        if (altre is Tauro)
        {

        }
        else if (altre is Tortuga)
        {
            if (Sexe == altre.Sexe)
            {
                Mata();
                altre.Mata();
            }
            else
            {
                int sexeNou = R.Next(0, 2);

                if (sexeNou == 0)
                {
                    return new Tortuga(X, Y, Sexes.Masculi);
                }
                else
                {
                    return new Tortuga(X, Y, Sexes.Femeni);
                }
            }
        }

        return null;
    }
}