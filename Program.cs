using System;
using System.Collections.Generic;

namespace TugasOOP
{
    class Program
    {
        public static int selectMenu;

        //FOOD MENU
        public static Makanan food = new Makanan();
        public static Makanan[] foods = new Makanan[4];
        public static int muchFood;
        public static string selectedFood;
       
        public static int totalPriceFood;

        //DRINK MENU
        public static Minuman drink = new Minuman();
        public static Minuman[] drinks = new Minuman[10];
        public static int muchDrink;
        public static string selectedDrink;
        public static int totalPriceDrink;

        public static int countItems = 0;


        
        static void Main(string[] args)
        {
                start:
                Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("Sistem Kasir Sederhana");
            Console.WriteLine("1. Pesan Makanan");
            Console.WriteLine("2. Pesan Minuman");
            Console.WriteLine("3. Cetak Pesanan");
            Console.Write("Input Pilihan Anda : ");
            try
            {
                selectMenu = Convert.ToInt32(Console.ReadLine());
                switch (selectMenu)
                {
                    case 1:
                        FoodMenu();
                        break;
                    case 2:
                        DrinkMenu();
                        break;
                    case 3:
                        PrintMenu();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Input tidak boleh kosong / menggunakan huruf");
            }
            
        }

        static void FoodMenu() {
            
            int select;
            /*foodMenus.Add(new Makanan {nameFood = "Nasi Goreng", price = 15000 });
            foodMenus.Add(new Makanan {nameFood = "Mie Goreng Telor", price = 15000 });
            foodMenus.Add(new Makanan {nameFood = "Soto Ayam", price = 20000 });*/
            foods[0] = new Makanan {name = "Nasi Goreng", price = 15000 };
            foods[1] = new Makanan { name = "Mie Goreng", price = 15000 };
            foods[2] = new Makanan { name = "Soto Ayam", price = 20000 };
            
            Console.WriteLine($"1. {foods[0].name}\t Price : {foods[0].price}");
            Console.WriteLine($"2. {foods[1].name}\t Price : {foods[1].price}");
            Console.WriteLine($"3. {foods[2].name}\t Price : {foods[2].price}");
            try {
                food.show();
                select = Convert.ToInt32(Console.ReadLine());
                switch (select) {
                    case 1:
                        Console.WriteLine(foods[0].name);
                        Console.WriteLine(foods[0].price);
                        break;
                    case 2:
                        Console.WriteLine(foods[1].name);
                        Console.WriteLine(foods[1].price);
                        break;
                    case 3:
                        Console.WriteLine(foods[2].name);
                        Console.WriteLine(foods[2].price);
                        break;
                    default:
                        Console.WriteLine("Makanan Tidak Ada Di Menu");
                        break;
                }
                Console.Clear();
                selectedFood = foods[select - 1].name;
                Console.WriteLine($"Menu Makan Telah Dipilih : {selectedFood}");
                Console.Write("Berapa Banyak yang ingin di pesan : ");
                muchFood = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine($"Total Makanan yang di pesan : {muchFood} {selectedFood}");
                totalPriceFood = foods[select - 1].price * muchFood;
                Console.WriteLine($"Total Harga Makanan : {totalPriceFood}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Inputan Tidak Boleh Menggunakan Huruf / Kosong");
            }
            BackToMenu();

        }
        static void DrinkMenu(){

            int select;

            drinks[0] = new Minuman { name = "ES Jeruk", price = 7000};
            drinks[1] = new Minuman { name = "ES Teh Manis", price = 5000 };
            drinks[2] = new Minuman { name = "Mineral Dingin", price = 3000};
            drinks[3] = new Minuman { name = "Jeruk Hangat", price = 5000 };
            drinks[4] = new Minuman { name = "Teh Manis Hangat", price = 3000 };
            drinks[5] = new Minuman { name = "Mineral", price = 3000 };

            Console.WriteLine($"1. {drinks[0].name}\t\t Price : {drinks[0].price}");
            Console.WriteLine($"2. {drinks[1].name}\t\t Price : {drinks[1].price}");
            Console.WriteLine($"3. {drinks[2].name}\t Price : {drinks[2].price}");
            Console.WriteLine($"4. {drinks[3].name}\t\t Price : {drinks[3].price}");
            Console.WriteLine($"5. {drinks[4].name}\t Price : {drinks[4].price}");
            Console.WriteLine($"6. {drinks[5].name}\t\t Price : {drinks[5].price}");

            try {
                drink.show();
                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine(drinks[0].name);
                        Console.WriteLine(drinks[0].price);
                        break;
                    case 2:
                        Console.WriteLine(drinks[1].name);
                        Console.WriteLine(drinks[1].price);
                        break;
                    case 3:
                        Console.WriteLine(drinks[2].name);
                        Console.WriteLine(drinks[2].price);
                        break;
                    case 4:
                        Console.WriteLine(drinks[3].name);
                        Console.WriteLine(drinks[3].price);
                        break;
                    case 5:
                        Console.WriteLine(drinks[4].name);
                        Console.WriteLine(drinks[4].price);
                        break;
                    case 6:
                        Console.WriteLine(drinks[5].name);
                        Console.WriteLine(drinks[5].price);
                        break;
                    default:
                        Console.WriteLine("Minuman Tidak Ada Di Menu");
                        break;
                }
                Console.Clear();

                selectedDrink = drinks[select - 1].name;
                Console.WriteLine($"Menu Minum Telah Dipilih : {selectedDrink}");
                Console.Write("Berapa Banyak yang ingin di pesan : ");
                muchDrink = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Total Minuman yang di pesan : {muchDrink} {selectedDrink}");
                totalPriceDrink = drinks[select - 1].price * muchDrink;
                Console.WriteLine($"Total Harga Minuman: {totalPriceDrink}");
            }
            catch (Exception e) {
                Console.WriteLine("Inputan Tidak Boleh Menggunakan Huruf / Kosong");
            }
            BackToMenu();
        }
        static void PrintMenu() {
            Console.Clear();
            Console.WriteLine($"Makanan Yang Di Pilih : \t{muchFood} {selectedFood}");
            Console.WriteLine($"Minuman Yang Di Pilih : \t{muchDrink} {selectedDrink}");
            Console.WriteLine($"Total Harga : \t{totalPriceFood + totalPriceDrink}");
        }

        static void BackToMenu()
        {
            Console.ReadKey(true);
            Menu();
        }
    }
}
