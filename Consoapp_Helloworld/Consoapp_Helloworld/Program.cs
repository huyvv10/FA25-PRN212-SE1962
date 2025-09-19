using System;
using System.Collections.Generic;
using System.Linq;

namespace Consoapp_Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n = ");
            int n = int.Parse(Console.ReadLine());
            //if (OddEven(n))
            //    Console.WriteLine($"{n} is an even number");
            //else Console.WriteLine($"{n} is an odd number");
            //Console.Write("Input a month: ");
            //n = int.Parse(Console.ReadLine());
            //DaysOfMonth(n);
            string primeNo = (IsPrime(n) ? $"{n} is a prime number" : $"{n} is not a prime number");
            Console.WriteLine( primeNo );
            ListPrimeToN(n);
            ListTheFirstNPrime(n);  
            Console.WriteLine($"The total value of {n} prime numbers: "+SumTheFirstNPrime(n));
            //CuuChuong(n);
            //CuuChuong();
            //int[] arr = new int[n];
            //InputArr(arr);
            //DisplayArr(arr);
            //SortArrAsc(arr);
            //SortArrDesc(arr);
            int[] arr = new int[] { 5,6,4,8,2,9,3};
            FindMinMax(arr);
        }
        public static (int min, int max) FindMinMax(int[] arr)
        {
            min = arr[0]; max = arr[0];
            for (int i = 1; i<arr.Length; i++)
            {
                if (arr[i]>max) max = arr[i];
                if (arr[i]>min) min = arr[i];
            }
            return (min, max);
        }

        static void SortArrDesc(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine();
            DisplayArr(arr);
        }
        static void SortArrAsc(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine();
            DisplayArr(arr);
        }
        static void InputArr(int[] arr)
        {
            Console.WriteLine("Input the element of array:");
            for (int i = 0;i<arr.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void DisplayArr(int[] arr)
        {
            Console.WriteLine("The list of elements in the array:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }
        static void CuuChuong()
        {
            for(int i = 1; i<=10; i++)
            {
                for (int j = 2; j < 10; j++)
                    Console.Write($"{j} x {i} = {i * j}\t");
                Console.WriteLine();
            }
        }

        static void CuuChuong(int n)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n*i}");
            Console.WriteLine() ;
        }
        //Calculate the total of the first n prime number
        static int SumTheFirstNPrime(int n)
        {
            int count = 0, i = 2, sum=0;
            do
            {
                if (IsPrime(i))
                {
                    sum += i;
                    count++;
                }
                i++;
            }while (count < n);
            return sum;
        }

        //List the first n prime number
        static void ListTheFirstNPrime(int n)
        {
            int count = 0, i=2;
            while (count != n)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                    count++;
                }
                i++;
            }
            Console.WriteLine();
        }
        static void ListPrimeToN(int n)
        {
            if (n < 2)
            {
                Console.WriteLine("Prime number must be greater than 2.");
                return;
            }
            int i = 2;
            while (i <= n)
            {
                if (IsPrime(i)) Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine();
        }
        static bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static bool OddEven(int n) { 
            return n % 2 == 0;
        }

        static void DaysOfMonth(int n)
        {
            switch (n) { 
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"{n} has 31 days.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"{n} has 30 days.");
                    break;
                case 2:
                    Console.WriteLine($"{n} has 28 or 29 days.");
                    break;
                default:
                    Console.WriteLine($"{n} is not a month in the year.");
                    break;
            }
        }

    }
}
