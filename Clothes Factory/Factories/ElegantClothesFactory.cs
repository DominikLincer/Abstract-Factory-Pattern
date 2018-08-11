using Clothes_Factory.Abstract_products;
using Clothes_Factory.Products;

namespace Clothes_Factory.Factories
{
    class ElegantClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new SuitTrousers();
        }
    }
}
