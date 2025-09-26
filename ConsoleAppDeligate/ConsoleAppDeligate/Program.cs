using System.Threading.Channels;

public class Program
{
    //public static int sum(int a, int b)
    //{
    //    return a + b;
    //}
    public delegate int MyCalculate(int a, int b);
    public static int sum(int a, int b) => a + b;
    public static int substract(int a, int b) => a - b;
    public static int product(int a, int b) => a * b;
    public static void show(string s)=> Console.WriteLine(s);
    private static void Main(string[] args)
    {
        Console.Write("Input a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Input b = ");
        int b = int.Parse(Console.ReadLine());

        //int rs = sum(a, b);
        MyCalculate myCal = new MyCalculate(sum);
        Console.WriteLine($"Total: "+ myCal(a, b));

        myCal = new MyCalculate(substract);
        Console.WriteLine($"Subtract: "+myCal(a, b));

        myCal = new MyCalculate(product);
        Console.WriteLine($"Product: "+myCal(a, b));

        Console.WriteLine($"Product: "+myCal.Invoke(6, 7));

        
    }
}