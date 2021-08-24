using System;
using System.Collections.Generic;
using System.Text;

namespace TugasOOP
{
    class Barang
    {
        public int price { get; set; }
        public string name { get; set; }

        public Barang() { 
        }
        public Barang(string name,int price) {
            this.name = name;
            this.price = price;
        }
        public virtual void show() {
            Console.WriteLine();
        }

    }
}
