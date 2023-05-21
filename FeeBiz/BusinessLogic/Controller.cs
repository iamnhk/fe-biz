using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
  public class Controller
    {
        PersistenceFacade persistenceFacade = new PersistenceFacade();

        //Constructors
        public Controller()
        {
        
        }

        //Methods
        public int addFarmer(string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation,
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string bankAccountNumber, string bankAccountTitle, string iBAN, string swiftBIC, string bankName, string bankBranchName)
        {
            //if successful, the method returns newFarmerID OR returns -1 otherwise
            Farmer farmer = FarmerFactory.createFarmer(phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1,
                addressLine2, postCode, city, country, verificationCode, name, bankAccountNumber, bankAccountTitle, iBAN, swiftBIC, bankName, bankBranchName);
            int newFarmerID = persistenceFacade.insertFarmer(farmer);
            return newFarmerID;
        }

        public int addCategory(string type, string subType)
        {
            //if successful, the method returns newCategoryID OR returns -1 otherwise
            Category category = new Category(type, subType);
            int newCategoryID = persistenceFacade.insertCategory(category);
            return newCategoryID;
        }

        public int addProduct(string name, DateTime offerExpiry, int totalQuantity, int packetSize, string packetSizeUnit,
            bool active, double price, int quality, DateTime registrationDate, int categoryID, int farmerID)
        {
            //if successful, the method returns newProductID OR returns -1 otherwise
            Category category = new Category();
            category.CategoryID = categoryID;
            Product product = ProductFactory.createProduct(name, offerExpiry, totalQuantity, packetSize, packetSizeUnit, active, price, 
                quality, registrationDate, category);
            int newProductID = persistenceFacade.insertProduct(product, farmerID);
            return newProductID;            
        }

        public int renewProduct(DateTime renewalDate, int productID, DateTime newOfferExpiry)
        {
            //if successful, the method returns newRenewalID OR returns -1 otherwise
            Renewal renewal = RenewalFactory.createRenewal(renewalDate);
            int newRenewalID = persistenceFacade.insertRenewal(renewal, productID);
            //This only records that on this specific date (today), the offer expiry of a particular product was renewed
            //the new date for offer expiry is still not updated in the Product table
            //the following statment updates OfferExpiry in the product table to a new OfferExpiry date.
            persistenceFacade.updateProductOfferExpiry(productID, newOfferExpiry);
            return newRenewalID;
        }


        public void changeTotalQuantityOfProduct(int productID, int newTotalQuantity)
        {
            persistenceFacade.updateTotalQuantityOfProduct(productID, newTotalQuantity);        
        }

        public bool checkProductStatus(int productID)
        {
            return persistenceFacade.checkProductStatus(productID);
        }

        
        public void markProductAsActiveORInactive(int productID, bool newStatus)
        {
            persistenceFacade.markProductAsActiveORInactive(productID, newStatus);        
        }

        public int addCompany(string phone, string fax, string email, string password, DateTime registrationDate,
            bool registrationConfirmation, string addressLine1, string addressLine2, string postCode, string city, string country,
            string verificationCode, string companyName, string contactPersonName, string branchName)
        {
            //if successful, the method returns newCompanyID OR returns -1 otherwise
            Company company = CompanyFactory.createCompany(phone, fax, email, password, registrationDate,
                registrationConfirmation, addressLine1, addressLine2, postCode, city, country, verificationCode, companyName, contactPersonName, branchName);
            int newCompanyID = persistenceFacade.insertCompany(company);
            return newCompanyID;
        }

        public bool confirmRegistration(string email, string verificationCode)
        {
            bool confirmed = false;
            string resultOfVerification = persistenceFacade.checkVerificationCode(email, verificationCode);
            if (resultOfVerification.Equals("Farmer"))
            {
                // verificationCode was found in Farmer table, so update RegistrationConfirmation in farmer table
                persistenceFacade.confirmFarmerRegistration(email);                
                confirmed = true;
            }
            else if (resultOfVerification.Equals("Company"))
            {
                // verificationCode was found in Company table, so now update RegistrationConfirmation in company table                
                persistenceFacade.confirmCompanyRegistration(email);
                confirmed = true;
            }
            return confirmed;
        }

        public int addOrder(string orderName, DateTime orderDate, int quantityOrdered, string unit, 
            int minimumQuality, int categoryID, int companyID)
        {
            //if successful, the method returns newOrderID OR returns -1 otherwise
            Category category = new Category();
            category.CategoryID = categoryID;
            Order order = new Order(orderName, orderDate, quantityOrdered, unit, minimumQuality, category);
            int newOrderID = persistenceFacade.insertOrder(order, companyID);
            return newOrderID;
        }

        public int addSale(int numberOfPackets, int farmerToCompanyRating, int companyToFarmerRating,
            int productID, int orderID)
        {
            //if successful, the method returns newSaleID OR returns -1 otherwise
            Product product = new Product();
            product.ProductID = productID;
            Sale sale = new Sale(numberOfPackets, farmerToCompanyRating, companyToFarmerRating, product);
            int newSaleID = persistenceFacade.insertSale(sale, orderID);
            return newSaleID;
        }

        public void rateFarmer(int saleID, int companyToFarmerRating)
        {
            persistenceFacade.updateCompanyToFarmerRating(saleID, companyToFarmerRating);
        }

        public void rateCompany(int saleID, int farmerToCompanyRating)
        {
            persistenceFacade.updateFarmerToCompanyRating(saleID, farmerToCompanyRating);        
        }
        
        public string login(string email, string password)
        {
            //returns "Farmer", "Company", or "Invalid".
            return persistenceFacade.authenticate(email, password);
        }

        public int getBusinessID(string email)
        {
            //if email exists in Farmer table, then returns FarmerID
            //or if email exists in Company table, then returns CompanyID
            //if email is not found in any of Farmer and Compnay tables, then returns -1
            return persistenceFacade.getBusinessID(email);            
        }

        public List<string> getAllUniqueCategoryTypes()
        {
            return persistenceFacade.getAllUniqueCategoryTypes();        
        }

        public List<string> getAllSubTypesOfAType(string type)
        {
            return persistenceFacade.getAllSubTypesOfAType(type);
        }

        public List<Package> getAllPackagesForAnOrder(int categoryID, string unit, int minimumQuality)        
        {
            //the method makes and returns a list of packages from the database to fulfil an order
            //each package in the list contains following information: [ProductID], [ProductName], [OfferExpiry], 
            //                                                         [AvailableQuantity], 
            //                                                         [PacketSize], [Price], [Quality])
            //NB: order.QuantityOrdered represents raw quantity e.g., quantity in KGs
            //NB: product.totalQuantity represents number of packets of a given size e.g., 20 packets
            //NB: sale.numberOfPackets also represents number of packets of a given size
            //NB: package.availableQuantity also represents number of packets of a given size
            Category category = new Category();
            category.CategoryID = categoryID;
            Order order = new Order();
            order.Category = category;
            order.Unit = unit;
            order.MinimumQuality = minimumQuality;
            List<Package> packageList = persistenceFacade.getAllPackagesForAnOrder(order);
            for (int i = 0; i < packageList.Count(); i++)
            {
                int soldQuantity = persistenceFacade.getAllSoldQuantitiesOfAProduct(packageList.ElementAt(i).ProductID);
                packageList.ElementAt(i).AvailableQuantity -= soldQuantity;            
            }
            return packageList;
        }

        public bool changePassword(string email, string oldPassword, string newPassword)
        {
            bool passwordChanged = persistenceFacade.changeFarmerPassword(email, oldPassword, newPassword);
            if (passwordChanged == true)
            {
                return true;//returns true if the password was changed in Farmer table
            }
            passwordChanged = persistenceFacade.changeCompanyPassword(email, oldPassword, newPassword);
            if (passwordChanged == true)
            {
                return true;//returns true if the password was changed in Company table
            }
            return passwordChanged;//returns false if the password could not be changed        
        }

        public List<Product> getAllProductsOfAFarmer(int farmerID)
        {
            //the methods selects and returns all products of a farmer that the farmer has registered/addded
            List<Product> productList = persistenceFacade.getAllProductsOfAFarmer(farmerID);
            for (int i = 0; i < productList.Count(); i++)
            {
                int soldQuantity = persistenceFacade.getAllSoldQuantitiesOfAProduct(productList.ElementAt(i).ProductID);
                productList.ElementAt(i).SoldQuantity = soldQuantity;                
            }
            return productList;
        }

        public List<Renewal> getAllRenewalsOfAProduct(int productID)
        {
            //the methods selects and returns all renewals of a product
            return persistenceFacade.getAllRenewalsOfAProduct(productID);        
        }

        public List<Order> getAllOrdersOfACompany(int companyID)
        {
            //the methods selects and returns all orders of a company that the company has made
            return persistenceFacade.getAllOrdersOfACompany(companyID);        
        }

        public List<Sale> getAllSalesOfAProduct(int productID)
        {
            //the methods selects and returns all sales of a product. A farmer can view all his/her products 
            //by calling getAllProductsOfAFarmer() method defined above. Then, the farmer can call this method 
            //for any product to view all sales of that product.
            return persistenceFacade.getAllSalesOfAProduct(productID);        
        }

        public List<Sale> getAllSalesInAnOrder(int orderID)
        {
            //the methods selects and returns all sales in an order. A company can view all its orders
            //by calling getAllOrdersOfACompany() method defined above. Then, the company can call this method 
            //for any order to view all sales in that order.
            return persistenceFacade.getAllSalesInAnOrder(orderID);
        }

        public Farmer viewFarmerProfile(int farmerID)
        {
            //the methods returns a farmer profile containing following 16 items
            /*
             farmer.Phone, farmer.Fax, farmer.Email, farmer.RegistrationDate, farmer.AddressLine1, 
             farmer.AddressLine2, farmer.PostCode, farmer.City, farmer.Country, farmer.Name, 
             farmer.BankAccountNumber, farmer.BankAccountTitle, farmer.IBAN, farmer.SwiftBIC, 
             farmer.BankName, farmer.BankBranchName
            */
            Farmer farmer = persistenceFacade.viewFarmerProfile(farmerID);
            if (farmer.BusinessID == farmerID)
            {
                return farmer;//if farmer profile is found in the DB, then return the profile
            }
            return null; //otherwise, return null
        }

        public Company viewCompanyProfile(int companyID)
        {
            //the methods returns a company profile containing following 12 items
            /*
             Phone, Fax, Email, RegistrationDate, AddressLine1, 
             AddressLine2, PostCode, City, Country, CompanyName, 
             ContactPersonName, BranchName
            */
            Company company = persistenceFacade.viewCompanyProfile(companyID);
            if (company.BusinessID == companyID)
            {
                return company;//if company profile is found in the DB, then return the profile
            }
            return null; //otherwise, return null

        
        }

        public void editFarmerProfile(int farmerID, string newPhone, string newFax, string newAddressLine1, 
            string newAddressLine2, string newPostCode, string newCity, string newCountry, string newFarmerName,
            string newBankAccountNumber, string newBankAccountTitle, string newIBAN, string newSwiftBIC, 
            string newBankName, string newBankBranchName)
        {
            // the method updates 14 attributes: Phone, Fax, AddressLine1, AddressLine2, PostCode, City, Country, 
            // FarmerName, BankAccountNumber, BankAccountTitle, IBAN, SwiftBIC, BankName, BankBranchName 
            // where farmerID is found in the Farmer table
            Farmer farmer = new Farmer();
            farmer.BusinessID = farmerID;
            farmer.Phone = newPhone;
            farmer.Fax = newFax;
            farmer.AddressLine1 = newAddressLine1;
            farmer.AddressLine2 = newAddressLine2;
            farmer.PostCode = newPostCode;
            farmer.City = newCity;
            farmer.Country = newCountry;
            farmer.Name = newFarmerName;
            farmer.BankAccountNumber = newBankAccountNumber;
            farmer.BankAccountTitle = newBankAccountTitle;
            farmer.IBAN = newIBAN;
            farmer.SwiftBIC = newSwiftBIC;
            farmer.BankName = newBankName;
            farmer.BankBranchName = newBankBranchName;
            persistenceFacade.updateFarmerProfile(farmer);
        
        }

        public void editCompanyProfile(int companyID, string newPhone, string newFax, string newAddressLine1,
            string newAddressLine2, string newPostCode, string newCity, string newCountry, string newCompanyName,
            string newContactPersonName, string newBranchName)
        {
            // the method updates 10 attributes: Phone, Fax, AddressLine1, AddressLine2, PostCode, City, Country, 
            // CompanyName, ContactPersonName, BranchName
            // where companyID is found in the Company table
            Company company = new Company();
            company.BusinessID = companyID;
            company.Phone = newPhone;
            company.Fax = newFax;
            company.AddressLine1 = newAddressLine1;
            company.AddressLine2 = newAddressLine2;
            company.PostCode = newPostCode;
            company.City = newCity;
            company.Country = newCountry;
            company.CompanyName = newCompanyName;
            company.ContactPersonName = newContactPersonName;
            company.BranchName = newBranchName;
            persistenceFacade.updateCompanyProfile(company);
        }

        public int getCategroyID(string type, string subType)
        {
            //the methods returns categoryID from category table where Type and SubType matches
            //if no record is found, then -1 is returned
            return persistenceFacade.getCategroyID(type, subType);
        }

        public string getFarmerOrCompanyName(string email)
        {
            //the method returns FarmerName if it was a farmer
            //or if it was a company, then it returns CompanyName
            //if no record is found, then it returns string.Empty
            return persistenceFacade.getFarmerOrCompanyName(email);        
        }

    }
}
