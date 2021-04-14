using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210414_2
{
    class Program
    {
        static void Main()
        {
            //írás
            var sw = new StreamWriter(
                path: @"pelda.txt",
                append: false,
                encoding: Encoding.UTF8);

            sw.WriteLine("Hello World!\n\n");
            sw.WriteLine($"Pi = {Math.PI}");
            sw.WriteLine("2 + 3 = {0}", 2 + 3);
            sw.WriteLine("Árvíztűrő Tükörfúrógép");
            Console.WriteLine("megnyíltam, tényeleg, szia!");
            var lista = new List<string>() { "egy", "kettő", "három" };
            foreach (var e in lista) sw.Write($"{e}, ");
            sw.Close();

            //olvasás
            double pi = 0;
            var sr = new StreamReader("pelda.txt", Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                var sor = sr.ReadLine();

                if(sor.Contains("Pi"))
                {
                    string[] darabok = sor.Split('=');

                    pi = double.Parse(darabok[1].Trim());
                }
            }
            sr.Close();
            Console.WriteLine(2 * pi);
            Console.ReadKey();
        }
    }
}
