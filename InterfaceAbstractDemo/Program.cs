using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            //customerManager.Save(
            //    new Entities.Customer { 
            //        DateOfBirth=new DateTime(1983,2,2),
            //        FirstName="Hüseyin", 
            //        LastName="Cesur",
            //        NationalityId="15506733932"
            //        }
            //    );

            BaseCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter()); 
            //Yukarıda MernisServiceAdapter verirsek Mernis'e göre, CustomerChechManager verirsek ona göre kontrol yapılacak.
            customerManager2.Save(
                new Entities.Customer
                {
                    DateOfBirth = new DateTime(1983, 2, 2),
                    FirstName = "Hüseyin",
                    LastName = "Cesur",
                    NationalityId = "15506733931" // :)
                }
                );
        }
    }
}
