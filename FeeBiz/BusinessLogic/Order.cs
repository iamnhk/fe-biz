using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class Order
    {
        private int orderID;
        private string orderName;
        private DateTime orderDate;
        private int quantityOrdered;
        private string unit; // for example KG
        private int minimumQuality; // in the range 1..5
        private Category category;
        private List<Sale> sales = new List<Sale>();

        //Constructors
        public Order()
        {
            this.orderID = 0;
            this.orderName = string.Empty;
            this.orderDate = DateTime.Today;
            this.quantityOrdered = 0;
            this.unit = "KG";
            this.minimumQuality = 1;
            this.category = new Category();
        }

        public Order(int orderID, string orderName, DateTime orderDate, int quantityOrdered, string unit, 
            int minimumQuality, int categoryID, string type, string subType)
        {
            this.orderID = orderID;
            this.orderName = orderName;
            this.orderDate = orderDate;
            this.quantityOrdered = quantityOrdered;
            this.unit = unit;
            this.minimumQuality = minimumQuality;
            this.category = new Category(categoryID, type, subType);
        }

        public Order(string orderName, DateTime orderDate, int quantityOrdered, string unit,
            int minimumQuality, int categoryID, string type, string subType)
        {
            this.orderID = 0;
            this.orderName = orderName;
            this.orderDate = orderDate;
            this.quantityOrdered = quantityOrdered;
            this.unit = unit;
            this.minimumQuality = minimumQuality;
            this.category = new Category(categoryID, type, subType);
        }

        public Order(int orderID, string orderName, DateTime orderDate, int quantityOrdered, string unit, int minimumQuality,
            Category category)
        {
            this.orderID = orderID;
            this.orderName = orderName;
            this.orderDate = orderDate;
            this.quantityOrdered = quantityOrdered;
            this.unit = unit;
            this.minimumQuality = minimumQuality;
            this.category = category;
        }

        public Order(string orderName, DateTime orderDate, int quantityOrdered, string unit, int minimumQuality,
            Category category)
        {
            this.orderID = 0;
            this.orderName = orderName;
            this.orderDate = orderDate;
            this.quantityOrdered = quantityOrdered;
            this.unit = unit;
            this.minimumQuality = minimumQuality;
            this.category = category;
        }
        //Properties
        public int OrderID
        {
            get
            {
                return this.orderID;
            }
            set
            {
                this.orderID = value;
            }
        }

        public string OrderName
        {
            get
            {
                return this.orderName;
            }
            set
            {
                this.orderName = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return this.orderDate;
            }
            set
            {
                this.orderDate = value;
            }
        }

        public int QuantityOrdered
        {
            get
            {
                return this.quantityOrdered;
            }
            set
            {
                this.quantityOrdered = value;
            }
        }

        public string Unit
        {
            get
            {
                return this.unit;
            }
            set
            {
                this.unit = value;
            }
        }

        public int MinimumQuality
        {
            get
            {
                return this.minimumQuality;
            }
            set
            {
                this.minimumQuality = value;
            }
        }

        public Category Category
        {
            get
            {
                return this.category;
            }
            set
            {
                this.category = value;
            }
        }

        public List<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }
        //Methods

        public void addSale(Sale sale)
        {
            sales.Add(sale);
        
        }

        public void addSale(int saleID, int numberOfPackets, int farmerToCompanyRating, int companyToFarmerRating,
            int productID, string productName, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime productRegistrationDate, int categoryID, string type, string subType)
        {
            sales.Add(new Sale(saleID, numberOfPackets, farmerToCompanyRating, companyToFarmerRating, productID, 
                productName, offerExpiry, totalQuantity, packetSize,
                packetSizeUnit, active, price, quality, productRegistrationDate, categoryID, type, subType));

        }

        public void addSale(int saleID, int numberOfPackets, int farmerToCompanyRating, int companyToFarmerRating,
            Product product)
        {
            sales.Add(new Sale(saleID, numberOfPackets, farmerToCompanyRating, companyToFarmerRating, product));

        }

        
        

    }
}
