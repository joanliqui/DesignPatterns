using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FabricMethod
{
    public class Factory
    {
        Dictionary<int, Product> productDictionary;

        public Factory()
        {
            productDictionary = new Dictionary<int, Product>();

            Product product = new Fish("Pescado Azul", 2f);
            productDictionary.Add(1, product);
            product = new Fish("Pescado Rojo", 3f);
            product = new Yoghurt("Hacendado", 1.3f);
            productDictionary.Add(2, product);
        }

        public Product CreateProduct(int key)
        {
            Product product = null;
 
            productDictionary.TryGetValue(key, out product);
            Console.WriteLine(product.ToString());
            return product;
        }
    }
}
