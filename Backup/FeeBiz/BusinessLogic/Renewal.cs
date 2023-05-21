using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class Renewal
    {
        private int renewalID;
        private DateTime renewalDate;

        //Constructors
        public Renewal()
        {
            this.renewalID = 0;
            this.renewalDate = DateTime.Today;            
        }

        public Renewal(int renewalID, DateTime renewalDate)
        {
            this.renewalID = renewalID;
            this.renewalDate = renewalDate;
        }

        public Renewal(DateTime renewalDate)
        {
            this.renewalID = 0;
            this.renewalDate = renewalDate;
        }

        //Properties
        public int RenewalID
        {
            get
            {
                return this.renewalID;
            }
            set
            {
                this.renewalID = value;
            }
        }

        public DateTime RenewalDate
        {
            get
            {
                return this.renewalDate;
            }
            set
            {
                this.renewalDate = value;
            }
        }

        //Methods

        
    }
}
