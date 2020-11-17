using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavicPonavljanje5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi cijenu bez pdv-a");
            double bezpdva = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite istu cijenu sa pdv-om");
            
            double sapdvom = bezpdva * 1.25;

            Console.WriteLine("Cijena s PDV-om je :" + sapdvom);

            Console.ReadKey();
        }
    }
}
