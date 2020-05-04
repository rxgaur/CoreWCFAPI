using standardlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    public class ProductsServiceSoap : ProductsService,  IProductsServiceSoap 
    {
       
    }
}
