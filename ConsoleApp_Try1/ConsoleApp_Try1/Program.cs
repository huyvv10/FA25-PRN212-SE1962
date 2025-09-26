//using namespace std;

internal class Program
{
    public delegate int MyCal(int a, int b);
    public static int sum(int a, int b) => a + b;
    public static int sub(int a, int b) => a - b;
    public static int product(int a, int b) => a * b;

    private static void Main(string[] args)
    {
        MyCal TinhToan = new MyCal(sum);
        

        Console.Write("Input n = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Input b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(TinhToan.Invoke(a, b));
        TinhToan = new MyCal(product);
        Console.WriteLine(TinhToan.Invoke(a, b));
        TinhToan = new MyCal(sub);
        Console.WriteLine(TinhToan.Invoke(a, b));

    }

    static (int max, int min) GetMaxMin(int[] arr)
    {
        int max = arr[0], min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        return (max, min);
    }


    static void swap(int x, int y)
    {
        int t = x; x = y; y = t;
        Console.WriteLine($"Inside Swap: x = {x}, y = {y}");
    }
    static void swap2(ref int x, ref int y)
    {
        int t = x; x = y; y = t;
        Console.WriteLine($"Inside Swap2: x = {x}, y = {y}");
    }
}
