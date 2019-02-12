using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adaptors
{
    public class MernisServiceAdaptor : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient();
            return kPSPublicSoapClient.TCKimlikNoDogrula(customer.NationalId, customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.BirthDate.Year);
        }
    }
}
