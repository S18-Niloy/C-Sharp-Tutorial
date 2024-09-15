using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Customer
    {
        public static void Main(String[] args)
        {
            Bank obj = new BankImplementation();
            obj.Debit(12000);
            Promotion obj1 = new BankImplementation();
            obj1.branding();
        }
    }
}
