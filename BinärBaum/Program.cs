using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinärBaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Binaerbaum<int> baum = new Binaerbaum<int>();
            
            System.Console.WriteLine("Ist der Baum leer? " + baum.IstLeer());
            Console.ReadLine();
        }
    }
}
