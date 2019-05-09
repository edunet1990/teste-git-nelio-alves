using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Testes
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int total = (a > b) ? a += 10 : b += 10;
            Console.WriteLine("Alteração 1");
            Console.WriteLine("Alteração 2");
            Console.WriteLine(total);
            Console.ReadKey();
        }

        
    }
    public class Employee
    {
    }

}
