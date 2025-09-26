using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCarManagement
{
    public class Car
    {
        private string id;
        private string name;
        private int color;
        private double price;

        public string Id { get { return id; } set { id = value; } }
        public Car() { }

        public Car(string id, string name, int color, double price)
        {
            this.id = id;
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public string ToInfo()
        {
            return $"{id,-5} {name,-20} {color,-5} {price,10}";
        }

        public string GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public int GetColor() { 
            return color;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetId(string _id)
        {
            this.id = _id;
        }
        public void SetName(string _name)
        {
            this.name = _name;
        }
        public void SetColor(int _color)
        {
            this.color = _color<0 ? 0: _color;
        }
        public void SetPrice(double _price)
        {
            this.price = _price < 0 ? 0 : _price;
        }        
    }
}
