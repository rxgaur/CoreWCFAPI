using standardlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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
