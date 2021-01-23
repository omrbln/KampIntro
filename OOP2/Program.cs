using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "1235";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.TcNo = "12345678910";


            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodalama.io";
            customer2.TaxNumber = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID = Yazılım Geliştirme Prensipleri

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
