namespace Peixera_Virtual;

public class Peixera
{
    Random R = new Random();
    List<Animals_peixera> llistaAnimals = new List<Animals_peixera>();

    public Peixera()
    {
        for (int i = 0; i < 50; i++)
        {
            llistaAnimals.Add(new Peix(R.Next(0, 20), R.Next(0, 20), Sexes.Masculi));
            llistaAnimals.Add(new Peix(R.Next(0, 20), R.Next(0, 20), Sexes.Femeni));
        }

        for (int i = 0; i < 10; i++)
        {
            llistaAnimals.Add(new Tauro(R.Next(0, 20), R.Next(0, 20), Sexes.Masculi));
            llistaAnimals.Add(new Tauro(R.Next(0, 20), R.Next(0, 20), Sexes.Femeni));
        }

        for (int i = 0; i < 15; i++)
        {
            llistaAnimals.Add(new Pop(R.Next(0, 20), R.Next(0, 20), Sexes.Pop));
        }

        for (int i = 0; i < 3; i++)
        {
            llistaAnimals.Add(new Tortuga(R.Next(0, 20), R.Next(0, 20), Sexes.Masculi));
            llistaAnimals.Add(new Tortuga(R.Next(0, 20), R.Next(0, 20), Sexes.Femeni));
        }
    }

    public void Simular()
    {
        for (int ronda = 1; ronda <= 100; ronda++)
        {
            foreach (var animal in llistaAnimals)
            {
                if (animal.EstaViu())
                {
                    animal.Mou();
                }
            }

            List<Animals_peixera> nous = new List<Animals_peixera>();

            for (int i = 0; i < llistaAnimals.Count; i++)
            {
                for (int j = i + 1; j < llistaAnimals.Count; j++)
                {
                    var a = llistaAnimals[i];
                    var b = llistaAnimals[j];

                    if (a.EstaViu() && b.EstaViu())
                    {
                        if (a.GetX() == b.GetX() && a.GetY() == b.GetY())
                        {
                            var fill = a.HeTrobatUnAltre(b);

                            if (fill != null)
                            {
                                nous.Add(fill);
                            }

                            if (a.EstaViu() && b.EstaViu())
                            {
                                var fill2 = b.HeTrobatUnAltre(a);

                                if (fill2 != null)
                                {
                                    nous.Add(fill2);
                                }
                            }
                        }
                    }
                }
            }

            for (int i = llistaAnimals.Count - 1; i >= 0; i--)
            {
                if (!llistaAnimals[i].EstaViu())
                {
                    llistaAnimals.RemoveAt(i);
                }
            }

            foreach (var n in nous)
            {
                llistaAnimals.Add(n);
            }

        }

        int peixos = 0;
        int peixosM = 0;
        int peixosF = 0;
        int tauros = 0;
        int taurosM = 0;
        int taurosF = 0;
        int pops = 0;
        int tortugues = 0;
        int tortuguesM = 0;
        int tortuguesF = 0;

        foreach (var a in llistaAnimals)
        {
            if (a is Peix)
            {
                peixos++;

                if (a.Sexe == Sexes.Masculi) peixosM++;
                if (a.Sexe == Sexes.Femeni) peixosF++;
            }

            if (a is Tauro)
            {
                tauros++;

                if (a.Sexe == Sexes.Masculi) taurosM++;
                if (a.Sexe == Sexes.Femeni) taurosF++;
            }

            if (a is Pop) pops++;

            if (a is Tortuga)
            {
                tortugues++;

                if (a.Sexe == Sexes.Masculi) tortuguesM++;
                if (a.Sexe == Sexes.Femeni) tortuguesF++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Simulacio acabada");

        Console.WriteLine("Peixos: " + peixos + " (M " + peixosM + " / F " + peixosF + ")");
        Console.WriteLine("Tauros: " + tauros + " (M " + taurosM + " / F " + taurosF + ")");
        Console.WriteLine("Pops: " + pops);
        Console.WriteLine("Tortugues: " + tortugues + " (M " + tortuguesM + " / F " + tortuguesF + ")");
        Console.WriteLine("TOTAL: " + llistaAnimals.Count);
    }
}