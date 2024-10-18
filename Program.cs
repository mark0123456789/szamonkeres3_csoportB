using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diakpontszamok
{
    internal class Program
    {
        public static string[] diakok = new string[5];
        public static int[,] pontszamok = new int[5, 4];  

  
        public static void Bekeres()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kérem a(z) {i + 1}. diák nevét:");
                diakok[i] = Console.ReadLine();

                for (int j = 0; j < 4; j++)  
                {
                    Console.WriteLine($"Kérem a(z) {i + 1}. diák {j + 1}. pontszámát:");
                    pontszamok[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public static void Atlag()
        {
            for (int i = 0; i < 5; i++)
            {
                int osszeg = 0;
                for (int j = 0; j < 4; j++)
                {
                    osszeg += pontszamok[i, j];
                }
                double atlag = (double)osszeg / 4;
                Console.WriteLine($"{diakok[i]} nevű diák átlaga: {atlag}");
            }
        }

        public static void MinPont()
        {
            int minPontszam = pontszamok[0, 0];
            string minDiak = diakok[0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pontszamok[i, j] < minPontszam)
                    {
                        minPontszam = pontszamok[i, j];
                        minDiak = diakok[i];
                    }
                }
            }
            Console.WriteLine($"A legkisebb pontszám: {minPontszam}, diák: {minDiak}");
        }


        public static void MaxPont()
        {
            int maxPontszam = pontszamok[0, 0];
            string maxDiak = diakok[0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pontszamok[i, j] > maxPontszam)
                    {
                        maxPontszam = pontszamok[i, j];
                        maxDiak = diakok[i];
                    }
                }
            }
            Console.WriteLine($"A legnagyobb pontszám: {maxPontszam}, diák: {maxDiak}");
        }

        public static void Main(string[] args)
        {
            Bekeres();
            Atlag();
            MinPont();
            MaxPont();
        }
    }
}
