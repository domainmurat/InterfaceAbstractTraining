using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    //Uygulamaya yazacagimiz bir ozelligi yarin baska bir musteride isteyebilir veya biz yarin baska birseydede kullanabilirz.
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
