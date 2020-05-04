using standardlib;
using System.Collections.Generic;
using System.ServiceModel;

namespace ProductService
{
    [ServiceContract]
    public interface IProductsServiceSoap
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        Product AddProduct(Product productItem);

        [OperationContract]
        Product UpdateProduct(int id, Product productItem);

        [OperationContract]
        int DeleteProduct(int id);
    }
}