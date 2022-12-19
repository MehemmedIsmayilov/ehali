using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ehali
{
    internal class Olke
    {

        string Name1;
        int TotalPopulation;
        public Weher[] seher;

        public Olke(string name1)
        {
            Name1 = name1;
            TotalPopulation = 0;
        }
        public void olkeGir(Olke olke, Weher seher)
        {
            Array.Resize(ref this.seher, this.seher.Length + 1);
            this.seher[this.seher.Length - 1] = seher;
            TotalPopulation += seher.Population;

        }

        public void FABP(int az, int cox)
        {
            foreach (var weher in seher)
            {
                if (weher.Population > az)
                {
                    if (weher.Population < cox)
                    {
                        Console.WriteLine(weher);
                    }
                }
            }





        }
    }
}
