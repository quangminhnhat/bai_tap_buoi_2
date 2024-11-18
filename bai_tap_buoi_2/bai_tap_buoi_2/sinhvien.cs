using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_buoi_2
{
    internal class sinhvien
    {
        public int ID;
        public string name;
        public int age;

        

        public sinhvien(int iD, string name, int age)
        {
            ID = iD;
            this.name = name;
            this.age = age;
        }

        public override string ToString() {
            return $"Id:{ID},ten:{name},tuoi:{age}";
        }


    }
}
