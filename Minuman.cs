using System;
using System.Collections.Generic;
using System.Text;

namespace TugasOOP
{
    class Minuman : Barang
    {
        

        public Minuman() { 
        }
        public Minuman(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public override void show()
        {
            Console.WriteLine("Silahkan Pilih Minuman Anda :");
        }
    }
}
