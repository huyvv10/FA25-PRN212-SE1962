internal class Program
{
    private static void Main(string[] args)
    {
        var student = new { name = "Huy", age = 18 };

        if (student is {name:"Huy", age: >= 18}){
            Console.WriteLine($"He is Huy and is valid adult");
        }


    }



    static (int max, int min) GetMaxMin(int[] arr)
    {
        int max = arr[0], min=arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        return (max, min);
    }


    static void swap(int x, int y)
    {
        int t = x; x = y; y=t;
        Console.WriteLine($"Inside Swap: x = {x}, y = {y}");
    }
    static void swap2(ref int x,ref int y)
    {
        int t = x; x = y; y = t;
        Console.WriteLine($"Inside Swap2: x = {x}, y = {y}");
    }
}
    