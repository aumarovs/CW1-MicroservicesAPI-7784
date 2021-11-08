using CW1_MicroservicesAPI_7784.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW1_MicroservicesAPI_7784.Repository
{
    interface IProductRepository
    {
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int Id);
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
    }
}
