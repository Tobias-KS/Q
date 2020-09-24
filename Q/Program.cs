using System;

namespace Q
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue[] KoListe = new Queue[6];
            for (int i = 0; i < KoListe.Length; i++)
            {
                KoListe[i] = new Queue();
            }

            Random rnd = new Random();

            for (int i = 0; i < 600; i++)
            {
                int x = rnd.Next(1, 7) - 1;
                KoListe[x].enQue(x); 
            }
            for (int i = 0; i < KoListe.Length; i++)
            {
                KoListe[i].printQue();
            }    
        }
    }
}
