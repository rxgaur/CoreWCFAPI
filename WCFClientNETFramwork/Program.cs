using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClientNETFramwork
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService.ProductsServiceSoapClient ps = new ProductService.ProductsServiceSoapClient();
            var products = ps.GetProducts().ToList();

            products.ForEach(x => Console.WriteLine($"id is {x.ID}, Name is {x.Name} and Brand is {x.Brand}"));
        }
    }
}
