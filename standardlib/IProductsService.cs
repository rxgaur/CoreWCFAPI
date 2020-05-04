using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace standardlib
{
    public interface IProductsService
    {
        List<Product> GetProducts();

        Product AddProduct(Product productItem);

        Product UpdateProduct(int id, Product productItem);

        int DeleteProduct(int id);


    }
}
