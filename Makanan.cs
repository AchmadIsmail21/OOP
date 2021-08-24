using System;
using System.Collections.Generic;
using System.Text;

namespace TugasOOP
{
    class Makanan : Barang
    {
        

        public Makanan() {
        }
        public Makanan(string name, int price) {
            this.name = name;
            this.price = price;
        }
        public override void show()
        {
            Console.WriteLine("Silahkan Pilih Makanan Anda : ");
        }


    }
}
