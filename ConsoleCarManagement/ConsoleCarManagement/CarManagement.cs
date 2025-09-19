using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleCarManagement
{
    public class CarManagement
    {
        List<Car> carList = new List<Car>();

        public void AddNewCar()
        {
            Console.Write("Input car Id: ");
            string id = Console.ReadLine();
            Console.Write("Input car name: ");
            string name = Console.ReadLine();
            Console.Write("Input car color: ");
            int color = int.Parse(Console.ReadLine());
            Console.Write("Input car price: ");
            double price = double.Parse(Console.ReadLine());
            Car x = new Car(id, name, color, price);
            carList.Add(x);
        }

        public void UpdateCarInfo()
        {
            Console.Write("Input car ID to edit info: ");
            string _id = Console.ReadLine();
            bool found= false;
            foreach (Car car in carList)
            {
                if (car.GetId().ToLower().Equals(_id.Trim().ToLower()))
                {
                    Console.Write("Input new name: ");
                    string name = Console.ReadLine();
                    Console.Write("Input new color: ");
                    int color = int.Parse(Console.ReadLine());
                    Console.Write("Input new price: ");
                    double price = double.Parse(Console.ReadLine());
                    car.SetName(name);
                    car.SetColor(color);
                    car.SetPrice(price);
                    Console.WriteLine("Car info updated.");
                    found= true; break;
                }
            }
            if (!found) Console.WriteLine($"Find not found car with id as {_id}");
        }
        public void DisplayCarList()
        {            
            Console.WriteLine($"{"ID",-5} {"Name",-20} {"Color",-5} {"Price",10}");
            Console.WriteLine($"{"--",-5} {"----",-20} {"-----",-5} {"-----",10}");
            foreach (var car in carList)
            {
                Console.WriteLine(car.ToInfo());
            }
        }
    }
}
