using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class Company : Business
    {
        private string companyName;
        private string contactPersonName;
        private string branchName;
        private List<Order> orders = new List<Order>();

        //Constructors
        public Company()
            : base()
        {
            this.companyName = string.Empty;
            this.contactPersonName = string.Empty;
            this.branchName = string.Empty;        
        }

        public Company(int businessID, string phone, string fax, string email, string password, DateTime registrationDate, 
            bool registrationConfirmation, string addressLine1, string addressLine2, string postCode, string city, string country,
            string verificationCode, string companyName, string contactPersonName, string branchName)
            : base(businessID, phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1, 
                   addressLine2, postCode, city, country, verificationCode)
        {
            this.companyName = companyName;
            this.contactPersonName = contactPersonName;
            this.branchName = branchName;
        }

        public Company(string phone, string fax, string email, string password, DateTime registrationDate,
            bool registrationConfirmation, string addressLine1, string addressLine2, string postCode, string city, string country,
            string verificationCode, string companyName, string contactPersonName, string branchName)
            : base(phone, fax, email, password, registrationDate, registrationConfirmation, addressLine1,
                   addressLine2, postCode, city, country, verificationCode)
        {
            this.companyName = companyName;
            this.contactPersonName = contactPersonName;
            this.branchName = branchName;
        }

        //Properties
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }

        public string ContactPersonName
        {
            get
            {
                return this.contactPersonName;
            }
            set
            {
                this.contactPersonName = value;
            }
        }

        public string BranchName
        {
            get
            {
                return this.branchName;
            }
            set
            {
                this.branchName = value;
            }
        }

        public List<Order> Orders
        {
            get
            {
                return this.orders;
            }
            set
            {
                this.orders = value;
            }
        }

        //Methods

    }
}
