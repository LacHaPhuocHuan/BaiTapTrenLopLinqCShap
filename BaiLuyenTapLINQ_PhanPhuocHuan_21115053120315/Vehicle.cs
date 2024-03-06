using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLuyenTapLINQ_PhanPhuocHuan_21115053120315
{
    internal class Vehicle
    {
        public int id { get; set; }
        public float price { get; set; }
        public DateTime dateOfProduct { get; set; }
        public string name { get; set; }
        public Manufactorer manufactorer { get; set; }
        public Vehicle(int id, float price, DateTime dateOfProduct, string name, Manufactorer manufactorer)
        {
            this.id = id;
            this.price = price;
            this.dateOfProduct = dateOfProduct;
            this.name = name;
            this.manufactorer = manufactorer;
        }

        public virtual void show()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Date of Product: {dateOfProduct}");
            Console.WriteLine($"Manufactorer: {manufactorer.name}");
        }





    }
}
