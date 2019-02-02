using kaffe;
using System;
using System.Collections.Generic;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Kaffe> kaffeList = new List<Kaffe>();
            
            Cortado cortado = new Cortado();

            FlatWhite flatWhite = new FlatWhite(20);

            Latte latte = new Latte();

            SortKaffe sortKaffe = new SortKaffe(10);

            kaffeList.Add(cortado);
            kaffeList.Add(flatWhite);
            kaffeList.Add(latte);
            kaffeList.Add(sortKaffe);
            Console.WriteLine("KAFFER:");
            foreach (var hKaffe in kaffeList)
            {
                Console.WriteLine($"Navn : {hKaffe.ToString()} Pris : {hKaffe.Pris()} kr. Styrke : {hKaffe.Styrke()}");
                Console.WriteLine();
            }




            Console.ReadKey();


        }
    }
}
