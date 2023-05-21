using CustomerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public abstract class CustomerFactory
    {
        public ICustomer GetCustomer()
        {
            ICustomer myCust = this.CreateCustomer();
            myCust.AddPoints();
            myCust.AddDiscount();
            return myCust;
        }
        public abstract ICustomer CreateCustomer();
    }

    public class GoldCustomerFactory : CustomerFactory
    {
        public override ICustomer CreateCustomer()
        {
            GoldCustomer objCust = new GoldCustomer();
            objCust.GoldOperation();
            return objCust;
        }
    }
    public class SilverCustomerFactory : CustomerFactory
    {
        public override ICustomer CreateCustomer()
        {
            SilverCustomer objCust = new SilverCustomer();
            objCust.SilverOperation();
            return objCust;
        }
    }

}
