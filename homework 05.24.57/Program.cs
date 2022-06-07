using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            do
            {
                Console.WriteLine("1.product elave et");
                Console.WriteLine("2.productlari sat");
                Console.WriteLine("3.productlara bax");
                Console.WriteLine("4.cix");

                Console.WriteLine("\n emeliyyati secin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                       
                        break;
                    case "2":
                        Console.WriteLine("product satilacaq");
                        break;
                    case "3":
                        Console.WriteLine("productlara baxilacaq");
                        goto case "1";
                        
                    case "4":
                        Console.WriteLine("sistemden cixacaq");
                        break;
                }
                while (opt != "4") ;
                static product GetProductFromConsole()
                {
                    Console.WriteLine("mehsulun nomresini daxil edin:");
                    string no = Console.ReadLine();

                    Console.WriteLine("mehsulun adini daxil edin:");
                    string name = Console.ReadLine();



                    string priceStr;
                    double price;

                    do
                    {
                        Console.WriteLine("mehsulun qiymetini daxil edin:");
                        priceStr = Console.ReadLine();
                    } while (!double.TryParse(priceStr, out price) || price < 0);



                    string countStr;
                    int count;
                    do
                    {
                        Console.WriteLine("mehsulun sayini daxil edin:");
                        countStr = Console.ReadLine();
                    } while (int.TryParse(countStr, out count) || count < 0);


                    Product product = new Product

                    {
                        No = no,
                        Name = name,
                        Count = count,
                        Price = price



                    };

                } 

        }
       
        }
    }
}
