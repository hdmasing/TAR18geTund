using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    public class Kangelane
    {
        private string Nimi;
        private string Asukoht;



        public Kangelane( string nimi, string asukoht)
        {
            Nimi1 = nimi;
            Asukoht1 = asukoht;

        }

        public string Nimi1 { get => Nimi; set => Nimi = value; }
        public string Asukoht1 { get => Asukoht; set => Asukoht = value; }

        public virtual int Päästa(int ohus)
        {
            

            return (int)Math.Round(ohus * 0.95, 0);
        }

        public override string ToString()
        {
            return Nimi1 + " Kaitseb " + Asukoht1;
        }
    }
}
