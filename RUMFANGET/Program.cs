using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUMFANGET
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Intast Længde");
            double længde = double.Parse(Console.ReadLine());

            Console.WriteLine("Intast Brede");
            double brede = double.Parse(Console.ReadLine());

            Console.WriteLine("Intast Højde");
            double højde = double.Parse(Console.ReadLine());

            Console.WriteLine("Rumfanget er " + længde * brede * højde);
            Console.ReadLine();
        }
    }
}
