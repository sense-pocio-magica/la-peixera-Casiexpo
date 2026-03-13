namespace Peixera_Virtual;

public class Tauro : Animals_peixera
{
    Random R = new Random();

    int Temps_Vida = 75;
    int Rondes = 0;

    public Tauro(int x, int y, Sexes h) : base(x, y, h)
    {

    }

    public override void Mou()
    {
        Rondes++;

        if (Rondes > Temps_Vida)
        {
            Mata();
        }
        else
        {
            base.Mou();
        }
    }

    public override Animals_peixera? HeTrobatUnAltre(Animals_peixera altre)
    {
        if (altre is Tortuga)
        {
            Direccio(); //Has dit que ho deixi així, que si el fill surt amb la mateixa direcció que el pare o la mare, mala sort.
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
                int sexeNou = R.Next(0, 2);

                if (sexeNou == 0)
                {
                    return new Tauro(X, Y, Sexes.Masculi);
                }
                else
                {
                    return new Tauro(X, Y, Sexes.Femeni);
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