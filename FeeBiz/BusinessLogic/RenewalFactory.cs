using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    class RenewalFactory
    {
        public static Renewal createRenewal()
        {
            return new Renewal();
        }

        public static Renewal createRenewal(int renewalID, DateTime renewalDate)
        {
            return new Renewal(renewalID, renewalDate);
        }

        public static Renewal createRenewal(DateTime renewalDate)
        {
            return new Renewal(renewalDate);
        }
    }
}
