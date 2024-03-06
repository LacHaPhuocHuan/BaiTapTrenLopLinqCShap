using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLuyenTapLINQ_PhanPhuocHuan_21115053120315
{
    internal class Company
    {
        public int id {  get; set; }
        public String name {  get; set; }
        public Company(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
