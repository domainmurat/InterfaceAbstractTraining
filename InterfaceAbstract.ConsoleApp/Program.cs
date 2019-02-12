using InterfaceAbstractDemo.Adaptors;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdaptor());
            baseCustomerManager.Save(new Customer()
            {
                FirstName = "Murat Can",
                LastName = "Oğuzhan",
                BirthDate = new DateTime(1991, 8, 20),
                NationalId = 11111111111
            });

            Console.Read();
        }
    }
}
