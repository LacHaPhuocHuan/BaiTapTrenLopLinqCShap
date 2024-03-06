using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLuyenTapLINQ_PhanPhuocHuan_21115053120315
{
    internal class Car: Vehicle
    {
      

        public int sittingNumber {  get; set; }

        public Car(int sittingNumber,int id, float price, DateTime dateOfProduct, string name, Manufactorer manufactorer) : base(id, price, dateOfProduct, name, manufactorer)
        {
            this.sittingNumber = sittingNumber;
        }

        public override void show()
        {
            base.show();
            Console.WriteLine($"Siiting Number: {sittingNumber}");
        }
    }
}
