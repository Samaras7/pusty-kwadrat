using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace zadanie9
{
    class Program
    {
        public static void Kwadrat(int h)
        {
            FileStream plik = new FileStream("kwadrat.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            System.IO.StreamWriter zapis = new StreamWriter(plik);


            for (int j = 0; j < h; j++)
            {
                Console.Write("*");
                zapis.Write("*");
            }
            Console.WriteLine();
            zapis.Write("\n");
            for (int i = 0; i < h - 2; i++) //głowna pętla
            {

                Console.Write("*");
                zapis.Write("*");
                for (int j = 0; j < h - 2; j++)
                {
                    Console.Write(" ");
                    zapis.Write(" ");
                }
                Console.Write("*");
                zapis.Write("*");
                Console.WriteLine();
                zapis.Write("\n");

            }
            for (int i = 0; i < h; i++)
            {
                Console.Write("*");
                zapis.Write("*");
            }

            zapis.Close();
            plik.Close();
        }
        static void Main(string[] args)
        {



            Console.WriteLine("podaj długość boku: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Kwadrat(h);


            Console.ReadKey();
        }
    }
}