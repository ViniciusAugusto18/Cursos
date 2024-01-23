using Cursos.content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soma();
                
        }

         static void Soma()
        {
            var x = 0;
            var y = 0;
            Console.WriteLine("digite 1 numero ?", x);
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero",y);
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(x+y);
            Console.ReadLine();
            
        }
       
    }
}
