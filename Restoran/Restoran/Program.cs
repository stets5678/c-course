using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Program
    {
        static void Main(string[] args)
        {
            string produkt1, produkt2, produkt3;
            float price1, price2, price3;
            string staff;
            Console.WriteLine("Вкажіть назву продукту");
            produkt1 = Console.ReadLine();
            produkt2 = Console.ReadLine();
            produkt3 = Console.ReadLine();

            Console.WriteLine("вкажыть ціну");
            price1 = float.Parse(Console.ReadLine());
            price2 = float.Parse(Console.ReadLine());
            price3 = float.Parse(Console.ReadLine());


            Console.WriteLine("Ім'я офіціанта");
            staff = Console.ReadLine();


            Console.WriteLine("Bill:" + " " + staff + "\n" + produkt1 + " " + price1 +"$");
            Console.WriteLine( " " + produkt2 + " " + price2 + " $");
            Console.WriteLine( " " + produkt3 + " " + price3 + " $");
            Console.WriteLine("____________");
            Console.WriteLine("sum:" + "$" + (price1 + price2 + price3));









        }
    }
}
