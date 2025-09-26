using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        public void AddNewCar2(string id, string name, int color, double price)
        {
            Car x = new Car(id, name, color, price);
            carList.Add(x);
        }
        public void ReadData(string fname)
        {
            if (File.Exists(fname))
            {
                //CarManagement defaultList = new CarManagement();
                string[] lines = File.ReadAllLines(fname);
                foreach (string line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] part = line.Trim().Split(';');
                        if (part.Length == 4)
                        {
                            string _id = part[0].Trim();
                            string _name = part[1].Trim();
                            int _color = int.Parse(part[2].Trim());
                            double _price = double.Parse(part[3].Trim());
                            AddNewCar2(_id, _name, _color, _price);
                        }
                    }
                }

            }
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

        public void SearchCarByName()
        {
            Console.Write("Input car name to search: ");
            string _name = Console.ReadLine();
            bool found = false;
            List<Car> searchCarList = new List<Car>();
            foreach (Car car in carList)
            {
                if (car.GetName().ToLower().Contains(_name.Trim().ToLower()))
                {
                    searchCarList.Add(car);
                    found = true;
                }
            }
            if (!found) Console.WriteLine($"Find not found car with name as {_name}");
            else
            {
                DisplayCarList2(searchCarList);

                //Console.WriteLine($"{"ID",-5} {"Name",-20} {"Color",-5} {"Price",10}");
                //Console.WriteLine($"{"--",-5} {"----",-20} {"-----",-5} {"-----",10}");                
                //foreach (var car in searchCarList)
                //{
                //    Console.WriteLine(car.ToInfo());
                //}
            }
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
        public void DisplayCarList2(List<Car> listCar)
        {
            Console.WriteLine($"{"ID",-5} {"Name",-20} {"Color",-5} {"Price",10}");
            Console.WriteLine($"{"--",-5} {"----",-20} {"-----",-5} {"-----",10}");
            foreach (var car in listCar)
            {
                Console.WriteLine(car.ToInfo());
            }
        }
    }
}
