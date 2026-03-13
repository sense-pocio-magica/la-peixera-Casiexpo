namespace Peixera_Virtual;

public class Pop : Animals_peixera
{
    Random R = new Random();

    bool Horari;

    public Pop(int x, int y, Sexes h) : base(x, y, h)
    {
        CollocarAlPerimetre();

        int n = R.Next(0, 2);

        if (n == 0)
        {
            Horari = true;
        }
        else
        {
            Horari = false;
        }
    }

    public void CollocarAlPerimetre()
    {
        int costat = R.Next(0, 4);

        if (costat == 0)
        {
            X = 0;
        }
        else if (costat == 1)
        {
            X = 19;
        }
        else if (costat == 2)
        {
            Y = 0;
        }
        else
        {
            Y = 19;
        }
    }

    public override void Mou()
    {
        if (Horari)
        {
            if (X == 0 && Y > 0)
            {
                Y--;
            }
            else if (Y == 0 && X < 19)
            {
                X++;
            }
            else if (X == 19 && Y < 19)
            {
                Y++;
            }
            else if (Y == 19 && X > 0)
            {
                X--;
            }
        }
        else
        {
            if (X == 0 && Y < 19)
            {
                Y++;
            }
            else if (Y == 19 && X < 19)
            {
                X++;
            }
            else if (X == 19 && Y > 0)
            {
                Y--;
            }
            else if (Y == 0 && X > 0)
            {
                X--;
            }
        }
    }

    public void CanviarDireccio()
    {
        if (Horari)
        {
            Horari = false;
        }
        else
        {
            Horari = true;
        }
    }

    public override Animals_peixera? HeTrobatUnAltre(Animals_peixera altre)
    {
        if (altre is Pop)
        {
            CanviarDireccio();

            Pop p = (Pop)altre;
            p.CanviarDireccio();
        }
        else if (altre is Tauro)
        {
            Mata();
        }

        return null;
    }
}