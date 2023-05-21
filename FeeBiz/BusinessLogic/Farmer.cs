using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class Farmer: Business
    {
        private string name;

        private string bankAccountNumber;
        private string bankAccountTitle;
        private string iBAN; //International Bank Account Number
        private string swiftBIC; //Swift/BIC
        private string bankName;
        private string bankBranchName;

        private List<Product> products = new List<Product>(); // farmer's list of products
        
        //Constructors
        public Farmer()
            : base()
        {
            this.name = string.Empty;

            this.bankAccountNumber = string.Empty;
            this.bankAccountTitle = string.Empty;
            this.iBAN = string.Empty;
            this.swiftBIC = string.Empty;
            this.bankName = string.Empty;
            this.bankBranchName = string.Empty;
        }

        public Farmer(int businessID, string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation, 
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string bankAccountNumber, string bankAccountTitle, string iBAN, string swiftBIC, string bankName, string bankBranchName)
            : base(businessID, phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2, 
                   postCode, city, country, verificationCode)
        {
            this.name = name;

            this.bankAccountNumber = bankAccountNumber;
            this.bankAccountTitle = bankAccountTitle;
            this.iBAN = iBAN;
            this.swiftBIC = swiftBIC;
            this.bankName = bankName;
            this.bankBranchName = bankBranchName;
        }

        public Farmer(string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation,
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string bankAccountNumber, string bankAccountTitle, string iBAN, string swiftBIC, string bankName, string bankBranchName)
            : base(phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2,
                   postCode, city, country, verificationCode)
        {
            this.name = name;

            this.bankAccountNumber = bankAccountNumber;
            this.bankAccountTitle = bankAccountTitle;
            this.iBAN = iBAN;
            this.swiftBIC = swiftBIC;
            this.bankName = bankName;
            this.bankBranchName = bankBranchName;
        }

        public Farmer(int businessID, string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation,
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string bankAccountNumber, string bankAccountTitle, string bankName, string bankBranchName)
            : base(businessID, phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2,
                   postCode, city, country, verificationCode)
        {
            this.name = name;

            this.bankAccountNumber = bankAccountNumber;
            this.bankAccountTitle = bankAccountTitle;
            this.iBAN = string.Empty;
            this.swiftBIC = string.Empty;
            this.bankName = bankName;
            this.bankBranchName = bankBranchName;
        }

        public Farmer(string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation,
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string bankAccountNumber, string bankAccountTitle, string bankName, string bankBranchName)
            : base(phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2,
                   postCode, city, country, verificationCode)
        {
            this.name = name;

            this.bankAccountNumber = bankAccountNumber;
            this.bankAccountTitle = bankAccountTitle;
            this.iBAN = string.Empty;
            this.swiftBIC = string.Empty;
            this.bankName = bankName;
            this.bankBranchName = bankBranchName;
        }

        public Farmer(int businessID, string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation,
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string iBAN, string swiftBIC)
            : base(businessID, phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2,
                   postCode, city, country, verificationCode)
        {
            this.name = name;

            this.bankAccountNumber = string.Empty;
            this.bankAccountTitle = string.Empty;
            this.iBAN = iBAN;
            this.swiftBIC = swiftBIC;
            this.bankName = string.Empty;
            this.bankBranchName = string.Empty;
        }

        public Farmer(string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation,
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string iBAN, string swiftBIC)
            : base(phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2,
                   postCode, city, country, verificationCode)
        {
            this.name = name;

            this.bankAccountNumber = string.Empty;
            this.bankAccountTitle = string.Empty;
            this.iBAN = iBAN;
            this.swiftBIC = swiftBIC;
            this.bankName = string.Empty;
            this.bankBranchName = string.Empty;
        }

        //Properties
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

        public string BankAccountNumber
        {
            get
            {
                return this.bankAccountNumber;
            }
            set
            {
                this.bankAccountNumber = value;
            }
        }

        public string BankAccountTitle
        {
            get
            {
                return this.bankAccountTitle;
            }
            set
            {
                this.bankAccountTitle = value;
            }
        }

        public string IBAN
        {
            get
            {
                return this.iBAN;
            }
            set
            {
                this.iBAN = value;
            }
        }

        public string SwiftBIC
        {
            get
            {
                return this.swiftBIC;
            }
            set
            {
                this.swiftBIC = value;
            }
        }

        public string BankName
        {
            get
            {
                return this.bankName;
            }
            set
            {
                this.bankName = value;
            }
        }

        public string BankBranchName
        {
            get
            {
                return this.bankBranchName;
            }
            set
            {
                this.bankBranchName = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
            set
            {
                this.products = value;
            }
        }

        //Methods
        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public void addProduct(int productID, string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime registrationDate, int categoryID, string type, string subType)
        {
            products.Add(new Product(productID, name, offerExpiry, totalQuantity, packetSize, packetSizeUnit,
                active, price, quality, registrationDate, categoryID, type, subType));
        }

        public void addProduct(int productID, string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime registrationDate, Category category)
        {
            products.Add(new Product(productID, name, offerExpiry, totalQuantity, packetSize, packetSizeUnit,
                active, price, quality, registrationDate, category));
        }

        
    }
}
