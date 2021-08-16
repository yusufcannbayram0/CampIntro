using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Gerçek/Bireysel müşteri
    // Miras - inheritance
    public class IndividualCustomer:Customer
    {       
        public string IdentityNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
