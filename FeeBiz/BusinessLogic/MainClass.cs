using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    class MainClass
    {
        static void Main(string[] args)
        {  
            Controller controller = new Controller();
            //Console.WriteLine(controller.addFarmer("1234544444", "1234555555", "farmer2@febiz.com", "farmer2pw",
              //DateTime.Today, false, "Halinen", "Halinen", "20540", "Turku", "Finland", "1251251250", "abc", "BankAc334466", "farmer2", 
              //"FI111444555", "NNHHSSAA", "Bank Name", "Bank Branch Name"));

            //Console.WriteLine(controller.addCategory("Sugar", "Date Sugar"));

            //Console.WriteLine(controller.addProduct("Product4", new DateTime(2011, 4, 25), 100, 10, "KG", true, 7, 5, 
              //  DateTime.Today, 1, 1));

            //Console.WriteLine(controller.renewProduct(DateTime.Today, 2, new DateTime(2011, 4, 12)));

            //controller.changeTotalQuantityOfProduct(1, 80);

            //Console.WriteLine(controller.checkProductStatus(2));
            
            //controller.markProductAsActiveORInactive(1, true);

            //Console.WriteLine(controller.addCompany("444426788", "555256789", "company2@febiz.com", "company2pw", 
              //  DateTime.Today, false, "Halinen", "Halinen", "20540", "Turku", "Finland", "3453453455", "company2", 
              //  "contact person", "company branch"));

            //Console.WriteLine(controller.confirmRegistration("company1@febiz.com", "3453453455"));

            //Console.WriteLine(controller.addOrder("order3", DateTime.Today, 20, "KG", 3, 2, 1));

            //Console.WriteLine(controller.addSale(10, 3, 2, 2, 2));

            //controller.rateFarmer(1, 1);

            //controller.rateCompany(2, 1);

            //Console.WriteLine(controller.login("company2@febiz.com", "company2pw"));

            //Console.WriteLine(controller.getBusinessID("company2@febiz.com"));

            //List<string> types = controller.getAllUniqueCategoryTypes();
            //for (int i = 0; i < types.Count(); i++)
              //  Console.WriteLine(types.ElementAt(i));

            //List<string> subTypes = controller.getAllSubTypesOfAType("Sugar");
            //for (int i = 0; i < subTypes.Count(); i++)
              //Console.WriteLine(subTypes.ElementAt(i));

            /*List<Package> packages = controller.getAllPackagesForAnOrder(2, "KG", 3);
            for (int i = 0; i < packages.Count(); i++)
            {
                Console.WriteLine(packages.ElementAt(i).ProductID);
                Console.WriteLine(packages.ElementAt(i).ProductName);
                Console.WriteLine(packages.ElementAt(i).OfferExpiry);
                Console.WriteLine(packages.ElementAt(i).AvailableQuantity);
                Console.WriteLine(packages.ElementAt(i).PacketSize);
                Console.WriteLine(packages.ElementAt(i).Price);
                Console.WriteLine(packages.ElementAt(i).Quality);
                Console.WriteLine();
            }*/

            //Console.WriteLine(controller.changePassword("company1@febiz.com", "company1newpw22", "company1newpw23"));
            //Console.WriteLine(controller.changePassword("farmer1@febiz.com", "farmer1newpw", "farmer1newpw2"));

            /*List<Product> products = controller.getAllProductsOfAFarmer(2);
            for (int i = 0; i < products.Count(); i++)
            {
                Console.WriteLine(products.ElementAt(i).ProductID);
                Console.WriteLine(products.ElementAt(i).Name);
                Console.WriteLine(products.ElementAt(i).OfferExpiry);
                Console.WriteLine(products.ElementAt(i).TotalQuantity);
                Console.WriteLine(products.ElementAt(i).PacketSize);
                Console.WriteLine(products.ElementAt(i).PacketSizeUnit);
                Console.WriteLine(products.ElementAt(i).Active);
                Console.WriteLine(products.ElementAt(i).Price);
                Console.WriteLine(products.ElementAt(i).Quality);
                Console.WriteLine(products.ElementAt(i).RegistrationDate);
                Console.WriteLine(products.ElementAt(i).Category.CategoryID);
                Console.WriteLine();
            }*/

            /*List<Renewal> renewals = controller.getAllRenewalsOfAProduct(2);
            for (int i = 0; i < renewals.Count(); i++)
            {
                Console.WriteLine(renewals.ElementAt(i).RenewalID);
                Console.WriteLine(renewals.ElementAt(i).RenewalDate);                
                Console.WriteLine();
            }*/

            /*List<Order> orders = controller.getAllOrdersOfACompany(2);
            for (int i = 0; i < orders.Count(); i++)
            {
                Console.WriteLine(orders.ElementAt(i).OrderID);
                Console.WriteLine(orders.ElementAt(i).OrderName);
                Console.WriteLine(orders.ElementAt(i).OrderDate);
                Console.WriteLine(orders.ElementAt(i).QuantityOrdered);
                Console.WriteLine(orders.ElementAt(i).Unit);
                Console.WriteLine(orders.ElementAt(i).MinimumQuality);
                Console.WriteLine(orders.ElementAt(i).Category.CategoryID);                
                Console.WriteLine();
            }*/

            /*List<Sale> sales = controller.getAllSalesOfAProduct(3);
            for (int i = 0; i < sales.Count(); i++)
            {
                Console.WriteLine(sales.ElementAt(i).SaleID);
                Console.WriteLine(sales.ElementAt(i).NumberOfPackets);
                Console.WriteLine(sales.ElementAt(i).FarmerToCompanyRating);
                Console.WriteLine(sales.ElementAt(i).CompanyToFarmerRating);                
                Console.WriteLine();
            }*/

            /*List<Sale> sales = controller.getAllSalesInAnOrder(2);
            for (int i = 0; i < sales.Count(); i++)
            {
                Console.WriteLine(sales.ElementAt(i).SaleID);
                Console.WriteLine(sales.ElementAt(i).NumberOfPackets);
                Console.WriteLine(sales.ElementAt(i).FarmerToCompanyRating);
                Console.WriteLine(sales.ElementAt(i).CompanyToFarmerRating);
                Console.WriteLine(sales.ElementAt(i).Product.ProductID);
                Console.WriteLine();
            }*/

            /*Farmer farmer = controller.viewFarmerProfile(2);
            if (farmer != null)
            {
                Console.WriteLine(farmer.Phone);
                Console.WriteLine(farmer.Fax);
                Console.WriteLine(farmer.Email);
                Console.WriteLine(farmer.RegistrationDate);
                Console.WriteLine(farmer.AddressLine1);
                Console.WriteLine(farmer.AddressLine2);
                Console.WriteLine(farmer.PostCode);
                Console.WriteLine(farmer.City);
                Console.WriteLine(farmer.Country);
                Console.WriteLine(farmer.Name);
                Console.WriteLine(farmer.BankAccountNumber);
                Console.WriteLine(farmer.BankAccountTitle);
                Console.WriteLine(farmer.IBAN);
                Console.WriteLine(farmer.SwiftBIC);
                Console.WriteLine(farmer.BankName);
                Console.WriteLine(farmer.BankBranchName);            
            }*/

            /*Company company = controller.viewCompanyProfile(2);
            if (company != null)
            {
                Console.WriteLine(company.Phone);
                Console.WriteLine(company.Fax);
                Console.WriteLine(company.Email);
                Console.WriteLine(company.RegistrationDate);
                Console.WriteLine(company.AddressLine1);
                Console.WriteLine(company.AddressLine2);
                Console.WriteLine(company.PostCode);
                Console.WriteLine(company.City);
                Console.WriteLine(company.Country);
                Console.WriteLine(company.CompanyName);
                Console.WriteLine(company.ContactPersonName);
                Console.WriteLine(company.BranchName);                
            }*/

            //controller.editFarmerProfile(1, "111222333", "111333444", "Halinen", "Halinen", "20540", "Tampere", "Sweden",
              //  "New Farmer", "FI1234567890", "New Farmer", "FI1234567890", "NNDDEEAA", "Nordea", "Nordea Tampere");

            //controller.editCompanyProfile(1, "111222222", "222333333", "Halinen", "Halinen", "20500", "Tampere", "Sweden",
              //  "New Company", "New Person", "New Branch");
            
            Console.WriteLine("Press any key to continue");            
            Console.ReadKey();
        }
    }
}
