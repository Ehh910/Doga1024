using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga1024
{
    internal class Bolygo
    {
        public string BolygoNeve { get; set; }

        public int  HoldakSzama { get; set; }

        public double Arany { get; set; }


        public Bolygo(string sor)
        {
            var atmeneti = sor.Split(';');
            this.BolygoNeve = atmeneti[0];
            this.HoldakSzama = int.Parse(atmeneti[1]);
            this.Arany = double.Parse(atmeneti[2]);
        }
    }
}
