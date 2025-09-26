using System;
using System.Threading.Channels;

public class Program
{
    public static int sum(int a, int b) => a + b;
    public static int substract(int a, int b) => a - b;
    public static int product(int a, int b) => a * b;
    public static void show(string s) => Console.WriteLine(s);

    private static void Main(string[] args)
    {
        Func<int, int, int> myFunc = substract;     //int myFunc(int, int)
        int rs = myFunc(5, 6);
        Console.WriteLine($"Result: "+rs);

        Action <string> actName = show; // void actName(string)
        actName(Console.ReadLine());
    }
}