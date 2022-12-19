using System.ComponentModel.DataAnnotations;

namespace Ehali
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weher seher = new Weher("seher", 4000);
            Olke olke = new Olke("olke");
            olke.olkeGir(olke, seher);
            olke.FABP(1, 1000000);
                
                


            

           
            
        }
    }
}