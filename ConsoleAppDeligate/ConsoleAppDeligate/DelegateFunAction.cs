using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDeligate
{
    internal class DelegateFunAction
    {

        public delegate int MyCalculate(int a, int b);
        public static int sum(int a, int b) => a + b;
        public static int substract(int a, int b) => a - b;
        public static int product(int a, int b) => a * b;
        private static void Main(string[] args)
        {
            Func<int, int, int> myFunc = sum;
            int rs = myFunc(5, 6);
            Console.WriteLine(rs);

        } 
    }

}
