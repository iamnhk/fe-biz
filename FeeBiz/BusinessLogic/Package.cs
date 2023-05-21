using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class Package
    {
        private int productID;
        private string productName;
        private DateTime offerExpiry;
        private int availableQuantity; // available no. of packets
        private int packetSize;
        private double price;
        private int quality;// 1..5
        
        //Constructors
        public Package()
        {
            this.productID = 0;
            this.productName = string.Empty;
            this.offerExpiry = DateTime.Today;
            this.availableQuantity = 0;
            this.packetSize = 0;
            this.price = 0.0;
            this.quality = 1;
        }

        public Package(int productID, string productName, DateTime offerExpiry, int availableQuantity, int packetSize, 
            double price, int quality)
        {
            this.productID = productID;
            this.productName = productName;
            this.offerExpiry = offerExpiry;
            this.availableQuantity = availableQuantity;
            this.packetSize = packetSize;
            this.price = price;
            this.quality = quality;            
        }

        public Package(string productName, DateTime offerExpiry, int availableQuantity, int packetSize,
            double price, int quality)
        {
            this.productID = 0;
            this.productName = productName;
            this.offerExpiry = offerExpiry;
            this.availableQuantity = availableQuantity;
            this.packetSize = packetSize;
            this.price = price;
            this.quality = quality;
        }
        
        //Properties
        public int ProductID
        {
            get
            {
                return this.productID;
            }
            set
            {
                this.productID = value;
            }
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }

        public DateTime OfferExpiry
        {
            get
            {
                return this.offerExpiry;
            }
            set
            {
                this.offerExpiry = value;
            }
        }

        public int AvailableQuantity
        {
            get
            {
                return this.availableQuantity;
            }
            set
            {
                this.availableQuantity = value;
            }
        }

        public int PacketSize
        {
            get
            {
                return this.packetSize;
            }
            set
            {
                this.packetSize = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public int Quality
        {
            get
            {
                return this.quality;
            }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    this.quality = value;
                }
                else
                {
                    Console.WriteLine("Product quality must be in the range 1..5");
                }

            }
        }
                
        //Methods
        

    }
}
