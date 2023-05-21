using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class CompanyFactory
    {
        public static Company createCompany()
        {
            return new Company();
        }

        public static Company createCompany(int businessID, string phone, string fax, string email, string password, DateTime registrationDate,
            bool registrationConfirmation, string addressLine1, string addressLine2, string postCode, string city, string country,
            string verificationCode, string companyName, string contactPersonName, string branchName)
        {
            return new Company(businessID, phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2, postCode,
                city, country, verificationCode, companyName, contactPersonName, branchName);
        }

        public static Company createCompany(string phone, string fax, string email, string password, DateTime registrationDate,
            bool registrationConfirmation, string addressLine1, string addressLine2, string postCode, string city, string country,
            string verificationCode, string companyName, string contactPersonName, string branchName)
        {
            return new Company(phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, addressLine2, postCode,
                city, country, verificationCode, companyName, contactPersonName, branchName);
        }




    }
}
