using System.Diagnostics;
using ConsoleCarManagement;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManagement myCarList = new CarManagement();
        int sel = 0;
        do
        {
            Menu();
            int.TryParse(Console.ReadLine(), out sel);
            switch (sel)
            {
                case 1:
                    //myCarList.AddNewCar();
                    myCarList.AddNewCar2("A2", "Toyota Camry", 2, 45000);
                    myCarList.AddNewCar2("A3", "Honda CR-V", 5, 60000);
                    myCarList.AddNewCar2("A4", "Ford Ranger", 4, 52000);
                    myCarList.AddNewCar2("A5", "Nissan X-Trail", 3, 58000);
                    myCarList.AddNewCar2("A6", "Hyundai Tucson", 2, 49000);
                    myCarList.DisplayCarList();
                    break;
                case 2:
                    myCarList.DisplayCarList(); break;
                case 3:
                    myCarList.UpdateCarInfo();
                    break;
                case 4:
                    myCarList.SearchCarByName();
                    break;
                case 5:
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid selection"); break;
            }
        } while (sel!=0);

    }
    public static void Menu()
    {
        Console.WriteLine("1. Add a new car");
        Console.WriteLine("2. Display car list");
        Console.WriteLine("3. Update car info");
        Console.WriteLine("4. Search car by name");
        Console.WriteLine("5. Remove car by its ID");
        Console.WriteLine("6. Sort by name");
        Console.WriteLine("7. Sort by Price Desc");
        Console.WriteLine("0. Quit");
        Console.Write("What is your selection: ");
    }

}