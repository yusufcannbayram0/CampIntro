using System;

namespace OOP2
{
    class Program
    {
        //SOLID 
        //L -> birbirine benziyor diye inheritance yapılmaz
        static void Main(string[] args)
        {
            //Gerçek Müşteri - Engin Demiroğ
            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 1;
            individualCustomer.CustomerNo = "12345";
            individualCustomer.FirstName = "Engin";
            individualCustomer.LastName = "Demiroğ";
            individualCustomer.IdentityNo = "1234567890";

            //Tüzel Müşteri - Kodlama.io

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 2;
            corporateCustomer.CustomerNo = "54321";
            corporateCustomer.CompanyName = "Kodlama.io";
            corporateCustomer.TaxNo = "1234567890";


            Customer customer = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer);
            customerManager.Add(corporateCustomer);

            //Gerçek Müşteri - Tüzel Müşteri

        }
    }
}
