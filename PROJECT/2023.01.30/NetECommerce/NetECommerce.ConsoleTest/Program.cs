using NetECommerce.BLL.Concrete;
using NetECommerce.Entity.Entity;
using System;

namespace NetECommerce.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductRepository productRepository= new ProductRepository();

            foreach (var item in productRepository.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
