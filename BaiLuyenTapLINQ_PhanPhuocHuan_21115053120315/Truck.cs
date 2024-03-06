using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLuyenTapLINQ_PhanPhuocHuan_21115053120315
{
    internal class Truck:Vehicle
    {
        public float capacity {  get; set; }
        public Company ownerCompany { get; set; }
        public Truck(Company company, float capacity ,int id, float price, DateTime dateOfProduct, string name, Manufactorer manufactorer) : base(id, price, dateOfProduct, name, manufactorer)
        {
            this.capacity = capacity;
            this.ownerCompany = company;
        }

        public override void show()
        {
            base.show();
            Console.WriteLine($"Capacity: {capacity}");
            Console.WriteLine($"Owner Company: {ownerCompany}");
        }

    }
}
