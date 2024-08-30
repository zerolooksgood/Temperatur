using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Temperatur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            StreamReader file = new StreamReader("C:\\Users\\mariu\\OneDrive - Viken fylkeskommune\\Documents\\VGS Mailand 2023-2025 Marius RB\\2ITA 2024\\Utvikling\\C#\\Oppg Aug 30\\Temperatur\\Temperatur\\temperatur.txt"); //Finner filen som temperaturene er lagret i
            string line = file.ReadLine(); //Leser en linje fra filen
            int[] list = new int[12];
            int temp = 0;
            while (line != null) //Kjører til linjen er tom (til den har lest alle linjene)
            {
                list[temp] = Convert.ToInt32(line);
                temp++;
                line = file.ReadLine();
            }

            //Oppg 2
            Console.WriteLine(gjennomsnitt(list));

            Console.ReadLine();

        }

        //Oppg 2
        static double gjennomsnitt(int[] list)
        {
            double sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            return sum / list.Length;
        }
    }
}
