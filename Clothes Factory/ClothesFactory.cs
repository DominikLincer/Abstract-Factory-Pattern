using Clothes_Factory.Abstract_products;
using Clothes_Factory.Products;

namespace Clothes_Factory
{
    abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();
    }
}
