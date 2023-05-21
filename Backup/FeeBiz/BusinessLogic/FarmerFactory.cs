using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    class FarmerFactory
    {        
        public static Farmer createFarmer()
        {
            return new Farmer();
        }

        public static Farmer createFarmer(int businessID, string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation,
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string bankAccountNumber, string bankAccountTitle, string iBAN, string swiftBIC, string bankName, string bankBranchName)
        {
            return new Farmer(businessID, phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2, postCode, city,
                country, verificationCode, name, bankAccountNumber, bankAccountTitle, iBAN, swiftBIC, bankName, bankBranchName);
        }

        public static Farmer createFarmer(string phone, string fax, string email, string password, DateTime registrationDate, bool registrationConfirmation,
            string addressLine1, string addressLine2, string postCode, string city, string country, string verificationCode, string name,
            string bankAccountNumber, string bankAccountTitle, string iBAN, string swiftBIC, string bankName, string bankBranchName)
        {
            return new Farmer(phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2, postCode, city,
                country, verificationCode, name, bankAccountNumber, bankAccountTitle, iBAN, swiftBIC, bankName, bankBranchName);
        }
        
    }
}
