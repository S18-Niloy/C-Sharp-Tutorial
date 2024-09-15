using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    interface Bank
    {
        abstract public void Credit(int amount);
        abstract public void Debit(int amount);
        abstract public bool Login(int pincode);
        abstract public void Checkbalance();
    }
}
