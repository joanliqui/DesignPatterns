using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FabricMethod
{
    public class Factory
    {
        Dictionary<int, Producto> productDictionary;

        public Factory()
        {
            productDictionary = new Dictionary<int, Producto>();

            Producto product = new Pescado("Pescado Azul", 2f);
            productDictionary.Add(1, product);
            product = new Pescado("Pescado Rojo", 3f);
            product = new Yogur("Hacendado", 1.3f);
            productDictionary.Add(2, product);
        }

        public Producto CreateProduct(int key)
        {
            Producto product = null;
 
            productDictionary.TryGetValue(key, out product);
            Console.WriteLine(product.ToString());
            return product;
        }
    }
}
