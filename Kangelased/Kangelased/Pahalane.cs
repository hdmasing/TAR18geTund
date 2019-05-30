using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Pahalane:Kangelane
    {
        public Pahalane(string Nimi, string Asukoht):base(Nimi, Asukoht)
        {

        }
        public override int Päästa(int ohus)
        {
            return 0;
        }
        public override string ToString()
        {
            return Nimi1 + "ohustab " + Asukoht1;
        }
    }
}
