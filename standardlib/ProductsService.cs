using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace standardlib
{
    public class ProductsService : IProductsService
    {

        private List<Product> _productItems;

        public ProductsService()
        {
            _productItems = new List<Product>();
            seedprodcts();
        }

        private void seedprodcts()
        {
            var products = new List<Product> { new Product { ID = 1, Name = "Rakesh", Brand = "Chocolate" },
            new Product { ID=2, Name="Akshat", Brand="Vanila"}};
            _productItems.AddRange(products);

        }

        public List<Product> GetProducts()
        {
            return _productItems;
        }

        public Product AddProduct(Product productItem)
        {
            _productItems.Add(productItem);
            return productItem;
        }

        public Product UpdateProduct(int id, Product productItem)
        {
            for (var index = _productItems.Count - 1; index >= 0; index--)
            {
                if (_productItems[index].ID == id)
                {
                    _productItems[index] = productItem;
                }
            }
            return productItem;
        }

        public int DeleteProduct(int id)
        {
            for (var index = _productItems.Count - 1; index >= 0; index--)
            {
                if (_productItems[index].ID == id)
                {
                    _productItems.RemoveAt(index);
                }
            }

            return id;
        }


    }
}
