using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class Business
    {
        private int businessID; 
        private string phone;
        private string fax;
        private string email; // email is used as username
        private string password;
        private DateTime registrationDate;
        private bool registrationConfirmation; //if the registration has been verified via Confirmation Email

        private string addressLine1;
        private string addressLine2;
        private string postCode;
        private string city;
        private string country;
        private string verificationCode;

        //Constructors
        public Business() 
        {
            this.businessID = 0;
            this.phone = string.Empty;
            this.fax = string.Empty;
            this.email = string.Empty;
            this.password = string.Empty;
            this.registrationDate = DateTime.Today;
            this.registrationConfirmation = false;            

            this.addressLine1 = string.Empty;
            this.addressLine2 = string.Empty;
            this.postCode = string.Empty;
            this.city = string.Empty;
            this.country = string.Empty;
            this.verificationCode = string.Empty;
        }
                
        public Business(int businessID, string phone, string fax, string email, string password, DateTime registrationDate, 
            bool registrationConfirmation, string addressLine1, string addressLine2, string postCode, string city,
            string country, string verificationCode)
        {
            this.businessID = businessID;
            this.phone = phone;
            this.fax = fax;
            this.email = email;
            this.password = password;
            this.registrationDate = registrationDate;
            this.registrationConfirmation = registrationConfirmation;

            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.postCode = postCode;
            this.city = city;
            this.country = country;
            this.verificationCode = verificationCode;
        }

        public Business(string phone, string fax, string email, string password, DateTime registrationDate,
            bool registrationConfirmation, string addressLine1, string addressLine2, string postCode, string city,
            string country, string verificationCode)
        {
            this.businessID = 0;
            this.phone = phone;
            this.fax = fax;
            this.email = email;
            this.password = password;
            this.registrationDate = registrationDate;
            this.registrationConfirmation = registrationConfirmation;

            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.postCode = postCode;
            this.city = city;
            this.country = country;
            this.verificationCode = verificationCode;
        }
        
        //Properties
        public int BusinessID
        {
            get
            {
                return this.businessID;
            }
            set
            {
                this.businessID = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                this.fax = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
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

        public bool RegistrationConfirmation
        {
            get
            {
                return this.registrationConfirmation;
            }
            set
            {
                this.registrationConfirmation = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return this.addressLine1;
            }
            set
            {
                this.addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return this.addressLine2;
            }

            set
            {
                this.addressLine2 = value;
            }
        }

        public string PostCode
        {
            get
            {
                return this.postCode;
            }

            set
            {
                this.postCode = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.city = value;
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.country = value;
            }
        }

        public string VerificationCode
        {
            get
            {
                return this.verificationCode;
            }

            set
            {
                this.verificationCode = value;
            }
        }

        //Methods

    }
}
