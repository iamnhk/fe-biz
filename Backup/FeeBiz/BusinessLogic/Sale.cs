using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class Sale
    {
        private int saleID;
        private int numberOfPackets;
        private int farmerToCompanyRating; // 1..5
        private int companyToFarmerRating; // 1..5        
        private Product product; // the product sold

        //Constructors
        public Sale()
        {
            this.saleID = 0;
            this.numberOfPackets = 0;
            this.farmerToCompanyRating = 0;
            this.companyToFarmerRating = 0;            
            this.product = new Product();
        }

        public Sale(int saleID, int numberOfPackets, int farmerToCompanyRating, int companyToFarmerRating,
            int productID, string productName, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime productRegistrationDate, int categoryID, string type, string subType)
        {
            this.saleID = saleID;
            this.numberOfPackets = numberOfPackets;
            this.farmerToCompanyRating = farmerToCompanyRating;
            this.companyToFarmerRating = companyToFarmerRating;
            this.product = new Product(productID, productName, offerExpiry, totalQuantity, packetSize, packetSizeUnit,
                active, price, quality, productRegistrationDate, categoryID, type, subType);
        }

        public Sale(int numberOfPackets, int farmerToCompanyRating, int companyToFarmerRating,
            int productID, string productName, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime productRegistrationDate, int categoryID, string type, string subType)
        {
            this.saleID = 0;
            this.numberOfPackets = numberOfPackets;
            this.farmerToCompanyRating = farmerToCompanyRating;
            this.companyToFarmerRating = companyToFarmerRating;
            this.product = new Product(productID, productName, offerExpiry, totalQuantity, packetSize, packetSizeUnit,
                active, price, quality, productRegistrationDate, categoryID, type, subType);
        }

        public Sale(int saleID, int numberOfPackets, int farmerToCompanyRating, int companyToFarmerRating, 
            Product product)
        {
            this.saleID = saleID;
            this.numberOfPackets = numberOfPackets;
            this.farmerToCompanyRating = farmerToCompanyRating;
            this.companyToFarmerRating = companyToFarmerRating;            
            this.product = product;
        }

        public Sale(int numberOfPackets, int farmerToCompanyRating, int companyToFarmerRating,
            Product product)
        {
            this.saleID = 0;
            this.numberOfPackets = numberOfPackets;
            this.farmerToCompanyRating = farmerToCompanyRating;
            this.companyToFarmerRating = companyToFarmerRating;
            this.product = product;
        }

        //Properties
        public int SaleID
        {
            get
            {
                return this.saleID;
            }
            set
            {
                this.saleID = value;

            }
        }

        public int NumberOfPackets
        {
            get
            {
                return this.numberOfPackets;
            }
            set
            {
                this.numberOfPackets = value;

            }
        }

        public int FarmerToCompanyRating
        {
            get
            {
                return this.farmerToCompanyRating;
            }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    this.farmerToCompanyRating = value;
                }
                else
                {
                    Console.WriteLine("Farmer to company rating must be in the range 0..5");
                }

            }
        }

        public int CompanyToFarmerRating
        {
            get
            {
                return this.companyToFarmerRating;
            }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    this.companyToFarmerRating = value;
                }
                else
                {
                    Console.WriteLine("Company to farmer rating must be in the range 0..5");
                }

            }
        }
                
        public Product Product
        {
            get
            {
                return this.product;
            }
            set
            {
                this.product = value;

            }
        }


        //Methods


    }
}
