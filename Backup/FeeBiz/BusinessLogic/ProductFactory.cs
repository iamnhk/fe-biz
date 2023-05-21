using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    class ProductFactory
    {
        public static Product createProduct()
        {
            return new Product();
        }

        public static Product createProduct(int productID, string name, DateTime offerExpiry, int totalQuantity, int packetSize, 
            string packetSizeUnit, bool active, double price, int quality, DateTime registrationDate, int categoryID, string type, string subType)
        {
            return new Product(productID, name, offerExpiry, totalQuantity, packetSize, packetSizeUnit, active, price, 
                quality, registrationDate, categoryID, type, subType);
        }

        public static Product createProduct(string name, DateTime offerExpiry, int totalQuantity, int packetSize,
            string packetSizeUnit, bool active, double price, int quality, DateTime registrationDate, int categoryID, string type, string subType)
        {
            return new Product(name, offerExpiry, totalQuantity, packetSize, packetSizeUnit, active, price,
                quality, registrationDate, categoryID, type, subType);
        }

        public static Product createProduct(int productID, string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime registrationDate, Category category)
        {
            return new Product(productID, name, offerExpiry, totalQuantity, packetSize, packetSizeUnit, active, price,
                quality, registrationDate, category);
        }

        public static Product createProduct(string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime registrationDate, Category category)
        {
            return new Product(name, offerExpiry, totalQuantity, packetSize, packetSizeUnit, active, price,
                quality, registrationDate, category);
        }

    }
}
