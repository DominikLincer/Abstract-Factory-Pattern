using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clothes_Factory.Abstract_products;
using Clothes_Factory.Factories;

namespace Clothes_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client entrepreneur = new Client(new ElegantClothesFactory());
            entrepreneur.DescribeYourClothes();
            Console.WriteLine($"Entrepreneur: {entrepreneur.DescribeYourClothes()} \n");

            Client student = new Client(new CasualClothesFactory());
            Console.WriteLine($"Student: {student.DescribeYourClothes()}"); 

            Console.ReadKey();
        }
    }
}
