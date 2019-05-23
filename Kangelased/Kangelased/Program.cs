using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kangelased
{
    class Program
    {
        static List<Kangelane> kangelased = new List<Kangelane>();
        static void Loefailist(string failinimi)
        {
            string[] failiandmed = File.ReadAllLines(failinimi);
            foreach (string rida in failiandmed)
            {
                string[] nimi_ja_koht = rida.Split('/');
                for (int i = 0; 1 < nimi_ja_koht.Length; i++)
                {
                    nimi_ja_koht[i] = nimi_ja_koht[i].Trim();
                }
                if (nimi_ja_koht[0].EndsWith("*")){
                    kangelased.Add(new SuperKangelane(nimi_ja_koht[0].Trim('*'), nimi_ja_koht[1]));
                }
                else { kangelased.Add(new Kangelane(nimi_ja_koht[0], nimi_ja_koht[1]));
                }
            }
        }
        static void Main(string[] args)
        {
            Loefailist("kangelased.txt");
            foreach(Kangelane hero in kangelased)
            {
                Console.WriteLine(hero);
            int arv = 100;
            Console.WriteLine(hero);
                Console.WriteLine($"Päästa tuleb {arv} inimest.\nPäästa suudeti{Kangelane.Päästa(arv)}.\n----------------");
            }
            
        }
    }
}
