namespace Peixera_Virtual;

public class Peixera
{
    class Program
    {
        static void RondesPeixera()
        {
            Random R = new Random();
            List<Animals_peixera> llistaAnimals = new List<Animals_peixera>();

            for (int i = 0; i < 50; i++)
            {
                llistaAnimals.Add(new Peix(R.Next(0, 20), R.Next(0, 20), Sexes.Masculi));
                llistaAnimals.Add(new Peix(R.Next(0, 20), R.Next(0, 20), Sexes.Femeni));
            }

            for (int ronda = 1; ronda <= 100; ronda++)
            {
                foreach (var animal in llistaAnimals)
                {
                    animal.Mou();
                }
            }
        }
    }
}