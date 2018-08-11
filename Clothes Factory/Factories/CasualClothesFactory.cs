using Clothes_Factory.Abstract_products;
using Clothes_Factory.Products;

namespace Clothes_Factory.Factories
{
    class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}
