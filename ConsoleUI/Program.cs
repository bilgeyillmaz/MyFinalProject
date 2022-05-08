using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            //ProductDtoTest();

            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if(result.Success)
            {
                     foreach (var product in result.Data)
                    {
                        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                    }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
         
            Console.ReadLine();
        }

        private static void ProductDtoTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
            Console.ReadLine();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var c in categoryManager.GetAll())
            {
                Console.WriteLine(c.CategoryName);
            }
            Console.ReadLine();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(50, 100).Data) //metotların artık datası, message ı ve success durumu var 
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
