using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ehali
{
    internal class Weher
    {

        public string Name;
        public int Population;

        public Weher(string name,int population)

        {
            Name = name;
             Population = population;

        }

        public override string ToString()
        {
            return Name;
        }
    }






    //public void FindAllByPopulation(string name,int population)
    //    {
    //        for (int i = 0; i < Population; i++)
    //        {
    //        geri:
    //            if (Population > 300000)
    //            {
    //                Console.WriteLine(name);
    //            }
    //            else
    //            {
    //                Console.WriteLine("Ehali sayi azdir");
    //            }
    //            goto geri;
    //        }


}
    

