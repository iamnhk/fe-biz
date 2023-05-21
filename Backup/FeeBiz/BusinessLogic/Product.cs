using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
   public class Product
    {
        private int productID;
        private string name;
        private DateTime offerExpiry;
        private int totalQuantity;
        private int soldQuantity;  // is derived from the Sale table      
        private int packetSize;
        private string packetSizeUnit;//for example KG
        private bool active;
        private double price;
        private int quality;// 1..5
        private DateTime registrationDate;
        private Category category;
        private List<Renewal> renewals = new List<Renewal>();
        
        
        //Constructors
        public Product()
        {
            this.productID = 0;
            this.name = string.Empty;
            this.offerExpiry = DateTime.Today;
            this.totalQuantity = 0;
            this.soldQuantity = 0;
            this.packetSize = 0;
            this.packetSizeUnit = "KG";
            this.active = true;
            this.price = 0.0;
            this.quality = 1;
            this.registrationDate = DateTime.Today;
            this.category = new Category();            
        }

        public Product(int productID, string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit, 
            bool active, double price, int quality, DateTime registrationDate, 
            int categoryID, string type, string subType)
        {
            this.productID = productID;
            this.name = name;
            this.offerExpiry = offerExpiry;
            this.totalQuantity = totalQuantity;            
            this.packetSize = packetSize;
            this.packetSizeUnit = packetSizeUnit;
            this.active = active;
            this.price = price;
            this.quality = quality;
            this.registrationDate = registrationDate;
            this.category = new Category(categoryID, type, subType);
        }

        public Product(string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime registrationDate,
            int categoryID, string type, string subType)
        {
            this.productID = 0;
            this.name = name;
            this.offerExpiry = offerExpiry;
            this.totalQuantity = totalQuantity;
            this.packetSize = packetSize;
            this.packetSizeUnit = packetSizeUnit;
            this.active = active;
            this.price = price;
            this.quality = quality;
            this.registrationDate = registrationDate;
            this.category = new Category(categoryID, type, subType);
        }

        public Product(int productID, string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime registrationDate, Category category)
        {
            this.productID = productID;
            this.name = name;
            this.offerExpiry = offerExpiry;
            this.totalQuantity = totalQuantity;            
            this.packetSize = packetSize;
            this.packetSizeUnit = packetSizeUnit;
            this.active = active;
            this.price = price;
            this.quality = quality;
            this.registrationDate = registrationDate;
            this.category = category;
        }

        public Product(string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime registrationDate, Category category)
        {
            this.productID = 0;
            this.name = name;
            this.offerExpiry = offerExpiry;
            this.totalQuantity = totalQuantity;
            this.packetSize = packetSize;
            this.packetSizeUnit = packetSizeUnit;
            this.active = active;
            this.price = price;
            this.quality = quality;
            this.registrationDate = registrationDate;
            this.category = category;
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
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
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

        public int TotalQuantity
        {
            get
            {
                return this.totalQuantity;
            }
            set
            {
                this.totalQuantity = value;
            }
        }

        public int SoldQuantity
        {
            get
            {
                return this.soldQuantity;
            }
            set
            {
                this.soldQuantity = value;
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

        public string PacketSizeUnit
        {
            get
            {
                return this.packetSizeUnit;
            }
            set
            {
                this.packetSizeUnit = value;
            }
        }

        public bool Active
        {
            get
            {
                return this.active;
            }
            set
            {
                this.active = value;
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

        public DateTime RegistrationDate
        {
            get
            {
                return this.registrationDate;
            }
            set
            {
                this.registrationDate = value;
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

        public List<Renewal> Renewals
        {
            get
            {
                return this.renewals;
            }
            set
            {
                this.renewals = value;
            }
        }
              

        
        //Methods
        public void addRenewal(Renewal renewal)
        {
            this.renewals.Add(renewal);
        }
        
        public void addRenewal(int renewalID, DateTime renewalDate)
        {
            this.renewals.Add(new Renewal(renewalID, renewalDate));
        }

        

    }
}
