namespace Peixera_Virtual;

public class Pop: Animals_peixera
{
    private int PosicioX;
    private int PosicioY;
    private string Direccio_De_Rotacio;
    Random R = new Random();
    
    public Pop(int x, int y, Sexes h) : base(x, y, h)
    {
        
    }

    private void DireccioDelPop()
    {
        int DireccioRotacio = R.Next(1, 2);
        switch (DireccioRotacio)
        {
            case 1:
                Direccio_De_Rotacio = "Horari";
                break;
            case 2:
                Direccio_De_Rotacio = "AntiHorari";
                break;
        }
    }

    private void ApareixerPop()
    {
        int OnApareixer = R.Next(0, 3);
        switch(OnApareixer)
        {
            case 0:
                PosicioX = 0;
                break;
            case 1:
                PosicioX = 19;
                break;
            case 2:
                PosicioY = 0;
                break;
            case 3:
                PosicioY = 19;
                break;
        }
    }
    
    //if ((posiciox, posicio.y) == (0,0))
    // while (y < 19)
    // {
    //y ++
    // }

    private void Moviment()
    {
        if (Direccio_De_Rotacio == "AntiHorari")
        {
            if ((PosicioX, PosicioY) == (0, 0))
            {
                while (PosicioY < 19)
                {
                    PosicioY++;
                }
            }
            else if ((PosicioX, PosicioY) == (0, 19))
            {
                while (PosicioX < 19)
                {
                    PosicioX++;
                }
            }
            else if ((PosicioX, PosicioY) == (19, 19))
            {
                while (PosicioY < 0)
                {
                    PosicioY--;
                }
            }
            else if ((PosicioX, PosicioY) == (19, 0))
            {
                while (PosicioX < 0)
                {
                    PosicioX--;
                }
            }
        }
        else if (Direccio_De_Rotacio == "Horari")
        {
            if ((PosicioX, PosicioY) == (0, 0))
            {
                while (PosicioX < 19)
                {
                    PosicioX++;
                }
            }
            else if ((PosicioX, PosicioY) == (19, 0))
            {
                while (PosicioY < 19)
                {
                    PosicioY++;
                }
            }
            else if ((PosicioX, PosicioY) == (19, 19))
            {
                while (PosicioX < 0)
                {
                    PosicioX--;
                }
            }
            else if ((PosicioX, PosicioY) == (0, 19))
            {
                while (PosicioY < 0)
                {
                    PosicioY--;
                }
            }
        }
    }

    public override Animals_peixera? HeTrobatUnAltre(Animals_peixera altre)
    {
        if (altre is Pop)
        {
            if (Direccio_De_Rotacio == "Horari")
            {
                Direccio_De_Rotacio = "AntiHorari";
            }
            else if (Direccio_De_Rotacio == "AntiHorari")
            {
                Direccio_De_Rotacio = "Horari";
            }
        }
        else if (altre is Tauro)
        {
            Mata();
        }
        return null;
    }
}